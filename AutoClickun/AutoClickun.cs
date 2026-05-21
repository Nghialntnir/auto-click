using AutoClickun.Models;
using AutoClickun.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoClickun
{
    public partial class AutoClickun : Form
    {
        // ─── State ───────────────────────────────────────────────
        private List<ClickAction> _scriptList = new List<ClickAction>();
        private CancellationTokenSource _cts;
        private bool _isRunning = false;

        // Dùng để pick location: sau khi bấm Pick, hook chuột toàn cục
        private bool _isPicking = false;

        public AutoClickun()
        {
            InitializeComponent();

            // Gán giá trị mặc định cho combo (tránh lỗi nếu user không chọn)
            cmbMouseBtn.SelectedIndex = 0;   // Left
            cmbClickType.SelectedIndex = 0;  // Single

            // Hotkey F6 Start/Stop
            this.KeyPreview = true;
            this.KeyDown += AutoClickun_KeyDown;
        }

        // ─── F6 Hotkey ───────────────────────────────────────────
        private void AutoClickun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
                btnStartStop_Click(sender, e);
        }

        // ─── Pick Location ───────────────────────────────────────
        private void btnPickLocation_Click(object sender, EventArgs e)
        {
            // Chọn radio Pick loc
            rdbPickLoc.Checked = true;

            // Thu nhỏ form để không che khuất màn hình
            this.WindowState = FormWindowState.Minimized;

            _isPicking = true;
            btnPickLocation.Text = "Đang chờ click...";

            // Dùng timer poll vị trí chuột khi user click chuột trái
            var pickTimer = new System.Windows.Forms.Timer();
            pickTimer.Interval = 50;
            pickTimer.Tick += (s, ev) =>
            {
                // Phát hiện click trái
                if ((Win32Api.GetAsyncKeyState(0x01) & 0x8000) != 0 && _isPicking)
                {
                    _isPicking = false;
                    pickTimer.Stop();
                    pickTimer.Dispose();

                    var pos = Cursor.Position;
                    txtX.Text = pos.X.ToString();
                    txtY.Text = pos.Y.ToString();

                    // Khôi phục form
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                    btnPickLocation.Text = "Pick location";
                }
            };
            pickTimer.Start();
        }

        // ─── Save action vào script list ─────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX.Text, out int x) || !int.TryParse(txtY.Text, out int y))
            {
                MessageBox.Show("Tọa độ X/Y không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out int delayMs) || delayMs < 0)
            {
                MessageBox.Show("Await phải là số nguyên dương (ms)!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var action = new ClickAction
            {
                Position = new Point(x, y),
                DelayMs = delayMs
            };

            _scriptList.Add(action);
            listBoxScript.Items.Add(action.ToString());

            // Reset textBox1 về default sau khi save
            textBox1.Text = "2000";
        }

        // ─── Clear script list ────────────────────────────────────
        private void btnClearScript_Click(object sender, EventArgs e)
        {
            _scriptList.Clear();
            listBoxScript.Items.Clear();
        }

        // ─── Start / Stop ─────────────────────────────────────────
        private async void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                // Dừng
                _cts?.Cancel();
                return;
            }

            // Validate script
            if (_scriptList.Count == 0)
            {
                MessageBox.Show("Script list đang trống! Hãy thêm ít nhất 1 vị trí.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đọc các tham số từ UI
            bool repeatUntilStopped = rdbRepeatUntilStopped.Checked;
            int numRepeat = (int)numRepeatTimes.Value;

            bool enableOffsetXY = chkRandomOffsetXY.Checked;
            int offsetXY = (int)numOffsetXY.Value;

            bool enableOffsetSleep = chkRandomOffsetSleep.Checked;
            int offsetSleep = (int)numOffsetSleep.Value;

            // Nếu dùng "Current location" (không pick), override tất cả action bằng vị trí hiện tại
            List<ClickAction> scriptToRun = new List<ClickAction>(_scriptList);
            if (rdbCurrentLoc.Checked)
            {
                // Tính tổng delay từ numHours/Mins/Secs/Milli làm delay chung
                int globalDelay = (int)(numHours.Value * 3600000
                                      + numMins.Value * 60000
                                      + numSecs.Value * 1000
                                      + numMilli.Value);

                scriptToRun = new List<ClickAction>
                {
                    new ClickAction
                    {
                        Position = Cursor.Position,  // sẽ lấy lại lúc chạy
                        DelayMs = globalDelay
                    }
                };
            }

            // Chuyển sang trạng thái RUNNING
            SetRunningState(true);

            _cts = new CancellationTokenSource();
            var executor = new ClickExcutor();

            try
            {
                await executor.StartExecutionAsync(
                    scriptToRun,
                    repeatUntilStopped,
                    numRepeat,
                    enableOffsetXY,
                    offsetXY,
                    enableOffsetSleep,
                    offsetSleep,
                    _cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Bình thường — user bấm STOP
            }
            finally
            {
                SetRunningState(false);
            }
        }

        // ─── Helper: đổi UI khi chạy / dừng ─────────────────────
        private void SetRunningState(bool running)
        {
            _isRunning = running;

            if (running)
            {
                btnStartStop.Text = "STOP (F6)";
                btnStartStop.BackColor = Color.Red;
            }
            else
            {
                btnStartStop.Text = "START (F6)";
                btnStartStop.BackColor = Color.Green;
            }

            // Khóa UI khi đang chạy
            grpInterval.Enabled = !running;
            grpClickOptions.Enabled = !running;
            grpRepeat.Enabled = !running;
            grpCursor.Enabled = !running;
            btnClearScript.Enabled = !running;
        }
        private void AutoClickun_Load(object sender, EventArgs e) { }

        private void listBoxScript_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}