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
        private List<ClickAction> _scriptList = new List<ClickAction>();
        private CancellationTokenSource _cts;
        private bool _isRunning = false;
        private bool _isPicking = false;
        private int _dragSourceIndex = -1;

        public AutoClickun()
        {
            InitializeComponent();
            cmbMouseBtn.SelectedIndex = 0;

            this.KeyPreview = true;
            this.KeyDown += AutoClickun_KeyDown;

            listBoxScript.AllowDrop = true;
            listBoxScript.MouseDown += listBoxScript_MouseDown;
            listBoxScript.MouseMove += listBoxScript_MouseMove;
            listBoxScript.DragOver += listBoxScript_DragOver;
            listBoxScript.DragDrop += listBoxScript_DragDrop;
        }

        private void AutoClickun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                btnStartStop_Click(sender, e);
            if (e.KeyCode == Keys.Delete && listBoxScript.Focused)
                DeleteSelectedLine();
        }

        private void btnPickLocation_Click(object sender, EventArgs e)
        {
            rdbPickLoc.Checked = true;
            this.WindowState = FormWindowState.Minimized;
            _isPicking = true;
            btnPickLocation.Text = "Đang chờ click...";

            var pickTimer = new System.Windows.Forms.Timer();
            pickTimer.Interval = 50;
            pickTimer.Tick += (s, ev) =>
            {
                if ((Win32Api.GetAsyncKeyState(0x01) & 0x8000) != 0 && _isPicking)
                {
                    _isPicking = false;
                    pickTimer.Stop();
                    pickTimer.Dispose();

                    var pos = Cursor.Position;
                    txtX.Text = pos.X.ToString();
                    txtY.Text = pos.Y.ToString();

                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                    btnPickLocation.Text = "Pick location";
                }
            };
            pickTimer.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX.Text, out int x) || !int.TryParse(txtY.Text, out int y))
            {
                MessageBox.Show("Tọa độ X/Y không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbNumAwait.Text, out int delayMs) || delayMs < 0)
            {
                MessageBox.Show("Await phải là số nguyên dương (ms)!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clickCount = (int)numClickCount.Value;
            if (clickCount < 1) clickCount = 1;

            var action = new ClickAction
            {
                Position = new Point(x, y),
                DelayMs = delayMs,
                ClickCount = clickCount
            };

            _scriptList.Add(action);
            listBoxScript.Items.Add(action.ToString());

            tbNumAwait.Text = "1000";
            numClickCount.Value = 1;
        }

        // ─── Xóa dòng — cả Designer (Click_1) lẫn hotkey đều gọi về đây ───
        private void btnDeleteALine_Click(object sender, EventArgs e) => DeleteSelectedLine();
        private void btnDeleteALine_Click_1(object sender, EventArgs e) => DeleteSelectedLine();

        private void DeleteSelectedLine()
        {
            int idx = listBoxScript.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Hãy chọn một dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _scriptList.RemoveAt(idx);
            listBoxScript.Items.RemoveAt(idx);

            if (listBoxScript.Items.Count > 0)
                listBoxScript.SelectedIndex = Math.Min(idx, listBoxScript.Items.Count - 1);
        }

        // ─── Drag & Drop ─────────────────────────────────────────
        private void listBoxScript_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _dragSourceIndex = listBoxScript.IndexFromPoint(e.Location);
        }

        private void listBoxScript_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _dragSourceIndex >= 0)
            {
                listBoxScript.DoDragDrop(_dragSourceIndex, DragDropEffects.Move);
                _dragSourceIndex = -1;
            }
        }

        private void listBoxScript_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBoxScript_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = listBoxScript.PointToClient(new Point(e.X, e.Y));
            int targetIndex = listBoxScript.IndexFromPoint(clientPoint);

            if (targetIndex < 0)
                targetIndex = listBoxScript.Items.Count - 1;

            int sourceIndex = (int)e.Data.GetData(typeof(int));
            if (sourceIndex == targetIndex) return;

            var action = _scriptList[sourceIndex];
            _scriptList.RemoveAt(sourceIndex);
            _scriptList.Insert(targetIndex, action);

            var itemText = listBoxScript.Items[sourceIndex];
            listBoxScript.Items.RemoveAt(sourceIndex);
            listBoxScript.Items.Insert(targetIndex, itemText);

            listBoxScript.SelectedIndex = targetIndex;
        }

        private void btnClearScript_Click(object sender, EventArgs e)
        {
            _scriptList.Clear();
            listBoxScript.Items.Clear();
        }

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
                    sb.Append($"\"DelayMs\": {a.DelayMs}, ");
                    sb.Append($"\"ClickCount\": {a.ClickCount}");
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

                    if (_scriptList.Count > 0)
                    {
                        var confirm = MessageBox.Show(
                            "Script list hiện tại đang có dữ liệu.\n\n" +
                            "Yes  = Ghi đè\nNo   = Thêm vào cuối\nCancel = Hủy",
                            "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

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
                int clickCount = ParseJsonInt(obj, "ClickCount");
                if (clickCount < 1) clickCount = 1;

                if (x >= 0 && y >= 0 && delay >= 0)
                {
                    list.Add(new ClickAction
                    {
                        Position = new Point(x, y),
                        DelayMs = delay,
                        ClickCount = clickCount
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
            while (numStart < obj.Length && (obj[numStart] == ' ' || obj[numStart] == '\t'))
                numStart++;

            int numEnd = numStart;
            while (numEnd < obj.Length && (char.IsDigit(obj[numEnd]) || obj[numEnd] == '-'))
                numEnd++;

            if (int.TryParse(obj.Substring(numStart, numEnd - numStart), out int val))
                return val;

            return -1;
        }

        private async void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                _cts?.Cancel();
                return;
            }

            if (_scriptList.Count == 0)
            {
                MessageBox.Show("Script list đang trống! Hãy thêm ít nhất 1 vị trí.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool repeatUntilStopped = rdbRepeatUntilStopped.Checked;
            int numRepeat = (int)numRepeatTimes.Value;
            bool enableOffsetXY = chkRandomOffsetXY.Checked;
            int offsetXY = (int)numOffsetXY.Value;
            bool enableOffsetSleep = chkRandomOffsetSleep.Checked;
            int offsetSleep = (int)numOffsetSleep.Value;

            var scriptToRun = new List<ClickAction>(_scriptList);

            SetRunningState(true);
            _cts = new CancellationTokenSource();

            try
            {
                await new ClickExcutor().StartExecutionAsync(
                    scriptToRun, repeatUntilStopped, numRepeat,
                    enableOffsetXY, offsetXY,
                    enableOffsetSleep, offsetSleep,
                    _cts.Token);
            }
            catch (OperationCanceledException) { }
            finally { SetRunningState(false); }
        }

        private void SetRunningState(bool running)
        {
            _isRunning = running;
            btnStartStop.Text = running ? "STOP (Enter)" : "START (Enter)";
            btnStartStop.BackColor = running ? Color.Red : Color.Green;

            grpInterval.Enabled = !running;
            grpClickOptions.Enabled = !running;
            grpRepeat.Enabled = !running;
            grpCursor.Enabled = !running;
            btnClearScript.Enabled = !running;
            btnDeleteALine.Enabled = !running;
        }

        private void AutoClickun_Load(object sender, EventArgs e) { }
    }
}