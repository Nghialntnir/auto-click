using AutoClickun.Models;
using AutoClickun.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
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

            this.KeyPreview = true;
            this.KeyDown += AutoClickun_KeyDown;
        }

        // ─── Hotkey ───────────────────────────────────────────
        private void AutoClickun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
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

        // ─── Save script ra file .acs (JSON) ─────────────────────
        private void btnSaveScript_Click(object sender, EventArgs e)
        {
            if (_scriptList.Count == 0)
            {
                MessageBox.Show("Script list đang trống, không có gì để lưu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Lưu kịch bản";
                dlg.Filter = "AutoClick Script (*.acs)|*.acs|JSON (*.json)|*.json";
                dlg.DefaultExt = "acs";
                dlg.FileName = "script";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                var sb = new StringBuilder();
                sb.AppendLine("[");
                for (int i = 0; i < _scriptList.Count; i++)
                {
                    var a = _scriptList[i];
                    sb.Append("  { ");
                    sb.Append($"\"X\": {a.Position.X}, ");
                    sb.Append($"\"Y\": {a.Position.Y}, ");
                    sb.Append($"\"DelayMs\": {a.DelayMs}");
                    sb.Append(" }");
                    if (i < _scriptList.Count - 1) sb.Append(",");
                    sb.AppendLine();
                }
                sb.AppendLine("]");

                File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show($"Đã lưu {_scriptList.Count} action vào:\n{dlg.FileName}",
                    "Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ─── Load script từ file .acs (JSON) ─────────────────────
        private void btnSelectScript_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Mở kịch bản";
                dlg.Filter = "AutoClick Script (*.acs)|*.acs|JSON (*.json)|*.json|Tất cả|*.*";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    string content = File.ReadAllText(dlg.FileName, Encoding.UTF8);
                    var loaded = ParseScriptJson(content);

                    if (loaded.Count == 0)
                    {
                        MessageBox.Show("File không có action nào hợp lệ!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Hỏi ghi đè hay append nếu list đang có dữ liệu
                    if (_scriptList.Count > 0)
                    {
                        var confirm = MessageBox.Show(
                            "Script list hiện tại đang có dữ liệu.\n\n" +
                            "Yes  = Ghi đè\n" +
                            "No   = Thêm vào cuối\n" +
                            "Cancel = Hủy",
                            "Xác nhận",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                        if (confirm == DialogResult.Cancel) return;

                        if (confirm == DialogResult.Yes)
                        {
                            _scriptList.Clear();
                            listBoxScript.Items.Clear();
                        }
                    }

                    foreach (var action in loaded)
                    {
                        _scriptList.Add(action);
                        listBoxScript.Items.Add(action.ToString());
                    }

                    MessageBox.Show($"Đã load {loaded.Count} action từ file.", "Load thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đọc file:\n{ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─── Parser JSON thủ công (không cần Newtonsoft) ─────────
        private List<ClickAction> ParseScriptJson(string json)
        {
            var list = new List<ClickAction>();
            int i = 0;

            while (i < json.Length)
            {
                int start = json.IndexOf('{', i);
                if (start < 0) break;
                int end = json.IndexOf('}', start);
                if (end < 0) break;

                string obj = json.Substring(start + 1, end - start - 1);

                int x = ParseJsonInt(obj, "X");
                int y = ParseJsonInt(obj, "Y");
                int delay = ParseJsonInt(obj, "DelayMs");

                if (x >= 0 && y >= 0 && delay >= 0)
                {
                    list.Add(new ClickAction
                    {
                        Position = new Point(x, y),
                        DelayMs = delay
                    });
                }

                i = end + 1;
            }

            return list;
        }

        private int ParseJsonInt(string obj, string key)
        {
            string search = $"\"{key}\"";
            int keyIdx = obj.IndexOf(search);
            if (keyIdx < 0) return -1;

            int colonIdx = obj.IndexOf(':', keyIdx + search.Length);
            if (colonIdx < 0) return -1;

            int numStart = colonIdx + 1;
            while (numStart < obj.Length &&
                   (obj[numStart] == ' ' || obj[numStart] == '\t'))
                numStart++;

            int numEnd = numStart;
            while (numEnd < obj.Length &&
                   (char.IsDigit(obj[numEnd]) || obj[numEnd] == '-'))
                numEnd++;

            if (int.TryParse(obj.Substring(numStart, numEnd - numStart), out int val))
                return val;

            return -1;
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
                btnStartStop.Text = "STOP (Enter)";
                btnStartStop.BackColor = Color.Red;
            }
            else
            {
                btnStartStop.Text = "START (Enter)";
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
    }
}