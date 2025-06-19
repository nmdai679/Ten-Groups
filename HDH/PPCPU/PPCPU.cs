using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HDH
{
    public partial class PPCPU : Form
    {
        #region khai bao bien
        ProcessManager ProcessManager_temp = new ProcessManager();
        ExecutionTimelineManager ExecutionTimelineManager_temp = new ExecutionTimelineManager();
        private Dictionary<string, Color> processColorMap = new Dictionary<string, Color>();
        int Quantumtime = 0;
        double avg_tat_temp = 0;
        double avg_wt_temp = 0;
        static string Thuattoan = "";
        #endregion

        #region cac ham load
        public PPCPU()
        {
            InitializeComponent();
        }

        private void Xinchao_Load(object sender, EventArgs e)
        {
            Loaddulieuprocess();
            ppcpu_dtgv.ReadOnly = false;
            ppcpu_dtgv.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

        }

        private void Loaddulieuprocess()
        {
            ppcpu_dtgv.Rows.Clear();
            ppcpu_dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (var process in ProcessManager_temp.GetAllProcesses())
            {
                ppcpu_dtgv.Rows.Add(
                    process.GetProcessName(),
                    process.GetArrivingTime(),
                    process.GetBurstTime(),
                    process.GetWaitingTime(),
                    process.GetTurnaroundTime()
                );
            }
        }

        private void Hienthidulieudong_txt(int idrow)
        {
            string a = ppcpu_dtgv.Rows[idrow].Cells[0].Value.ToString();
            string b = ppcpu_dtgv.Rows[idrow].Cells[1].Value.ToString();
            string c = ppcpu_dtgv.Rows[idrow].Cells[2].Value.ToString();

            txt_ppcpu_nameprocess.Text = a;
            txt_ppcpu_bursttime.Text = c;
            txt_ppcpu_arrivingtime.Text = b;
        }

        private void Loaddulieu_bottom(string a, double b, double c, double d)
        {
            if(Thuattoan == "RR")
            {
                a += (" (Qt = " + Quantumtime.ToString() + ")");
            }    
            lb_ppcpu_loai.Text = "Loại: " + a;
            lb_ppcpu_AVGWT.Text = "AVGWT: " + Math.Round(b, 6).ToString();
            lb_ppcpu_AVGTAT.Text = "AVGTAT: " + Math.Round(c, 6).ToString();
            lb_ppcpu_Thongnang.Text = "Thông năng: " + Math.Round(d, 6).ToString();
        }
        #endregion

        #region nut chuc nang
        private void btn_ppcup_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_ppcpu_nameprocess.Text) &&
                !string.IsNullOrWhiteSpace(txt_ppcpu_arrivingtime.Text) &&
                !string.IsNullOrWhiteSpace(txt_ppcpu_bursttime.Text))
            {
                string name = txt_ppcpu_nameprocess.Text.Trim();
                int at = int.Parse(txt_ppcpu_arrivingtime.Text.Trim());
                int bt = int.Parse(txt_ppcpu_bursttime.Text.Trim());

                var existingProcess = ProcessManager_temp
                              .GetAllProcesses()
                              .FirstOrDefault(p => p.GetProcessName() == name);

                if (existingProcess != null)
                {
                    existingProcess.SetArrivingTime(at);
                    existingProcess.SetBurstTime(bt);
                }
                else
                {
                    var process = new ProcessInfo(name, bt, at);
                    if (!processColorMap.ContainsKey(name))
                    {
                        Color uniqueColor = GenerateUniqueColor();
                        processColorMap.Add(name, uniqueColor);
                    }
                    ProcessManager_temp.AddProcess(process);

                    MessageBox.Show("Đã thêm tiến trình thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                ProcessManager_temp.SortByArrivingTime();
                reset_txt();
                Loaddulieuprocess();
                Chaythuattoan();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ kiện!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btn_ppcup_delete_Click(object sender, EventArgs e)
        {
            string name = txt_ppcpu_nameprocess.Text.ToString();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên tiến trình cần xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            bool deleted = ProcessManager_temp.DeleteProcessByName(name);

            if (deleted)
            {
                MessageBox.Show($"Đã xóa tiến trình \"{name}\" thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Không tìm thấy tiến trình \"{name}\"!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            Loaddulieuprocess();
            reset_txt();
        }
             
        private void btn_PPCPU_FCFS_Click(object sender, EventArgs e)
        {
            Thuattoan = "FCFS";

            var processList = ProcessManager_temp.GetAllProcesses();
            if (processList.Count == 0)
            {
                MessageBox.Show("Danh sách tiến trình trống. Vui lòng thêm tiến trình trước khi chạy.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var timelines = ProcessManager_temp.RunFCFS();

            ExecutionTimelineManager_temp = new ExecutionTimelineManager();
            foreach (var tl in timelines)
            {
                ExecutionTimelineManager_temp.AddTimeline(tl);
            }

            avg_wt_temp = ProcessManager_temp.GetAvgWaitingTime();
            avg_tat_temp = ProcessManager_temp.GetAvgTurnaroundTime();

            Loaddulieu_bottom("FCFS",
                ProcessManager_temp.GetAvgWaitingTime(),
                ProcessManager_temp.GetAvgTurnaroundTime(),
                ProcessManager_temp.GetThroughput());

            Loaddulieuprocess();
            vebieudogantt();
        }

        private void btn_PPCPU_SJF_Click(object sender, EventArgs e)
        {
            Thuattoan = "SJF";

            var processList = ProcessManager_temp.GetAllProcesses();
            if (processList.Count == 0)
            {
                MessageBox.Show("Danh sách tiến trình trống. Vui lòng thêm tiến trình trước khi chạy.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var timelines = ProcessManager_temp.RunSJF();

            ExecutionTimelineManager_temp = new ExecutionTimelineManager();
            foreach (var tl in timelines)
            {
                ExecutionTimelineManager_temp.AddTimeline(tl);
            }

            avg_wt_temp = ProcessManager_temp.GetAvgWaitingTime();
            avg_tat_temp = ProcessManager_temp.GetAvgTurnaroundTime();

            Loaddulieu_bottom("SJF",
                              ProcessManager_temp.GetAvgWaitingTime(),
                              ProcessManager_temp.GetAvgTurnaroundTime(),
                              ProcessManager_temp.GetThroughput());

            Loaddulieuprocess();
            vebieudogantt();
        }

        private void btn_PPCPU_SRTF_Click(object sender, EventArgs e)
        {
            Thuattoan = "SRTF";

            var processList = ProcessManager_temp.GetAllProcesses();
            if (processList.Count == 0)
            {
                MessageBox.Show("Danh sách tiến trình trống. Vui lòng thêm tiến trình trước khi chạy.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var timelines = ProcessManager_temp.RunSRTF();

            ExecutionTimelineManager_temp = new ExecutionTimelineManager();
            foreach (var tl in timelines)
            {
                ExecutionTimelineManager_temp.AddTimeline(tl);
            }

            avg_wt_temp = ProcessManager_temp.GetAvgWaitingTime();
            avg_tat_temp = ProcessManager_temp.GetAvgTurnaroundTime();

            Loaddulieu_bottom("SRTF",
                              avg_wt_temp,
                              avg_tat_temp,
                              ProcessManager_temp.GetThroughput());

            Loaddulieuprocess();
            vebieudogantt();
        }

        private void btn_PPCPU_RR_Click(object sender, EventArgs e)
        {
            Thuattoan = "RR";

            var processList = ProcessManager_temp.GetAllProcesses();
            if (processList.Count == 0)
            {
                MessageBox.Show("Danh sách tiến trình trống. Vui lòng thêm tiến trình trước khi chạy.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var inputForm = new NhapQt_RR();
            if (inputForm.ShowDialog() != DialogResult.OK)
                return;

            Quantumtime = inputForm.Quantum;

            var timelines = ProcessManager_temp.RunRR(Quantumtime);

            ExecutionTimelineManager_temp = new ExecutionTimelineManager();
            foreach (var tl in timelines)
                ExecutionTimelineManager_temp.AddTimeline(tl);

            avg_wt_temp = ProcessManager_temp.GetAvgWaitingTime();
            avg_tat_temp = ProcessManager_temp.GetAvgTurnaroundTime();

            Loaddulieu_bottom("RR", avg_wt_temp, avg_tat_temp, ProcessManager_temp.GetThroughput());
            Loaddulieuprocess();
            vebieudogantt();
        }

        private void btn_ppcpu_ss_Click(object sender, EventArgs e)
        {
            var processmanager = ProcessManager_temp.GetAllProcesses().ToList();
            ExecutionTimelineManager_temp = new ExecutionTimelineManager();
            if (processmanager.Count == 0)
            {
                MessageBox.Show("Danh sách tiến trình trống. Vui lòng thêm tiến trình trước khi chạy.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            List<double> temp1 = new List<double>();
            List<double> temp2 = new List<double>();
            ProcessManager_temp.RunFCFS();
            temp1.Add(ProcessManager_temp.GetAvgWaitingTime());
            temp2.Add(ProcessManager_temp.GetAvgTurnaroundTime());
            ProcessManager_temp.RunSJF();
            temp1.Add(ProcessManager_temp.GetAvgWaitingTime());
            temp2.Add(ProcessManager_temp.GetAvgTurnaroundTime());
            ProcessManager_temp.RunSRTF();
            temp1.Add(ProcessManager_temp.GetAvgWaitingTime());
            temp2.Add(ProcessManager_temp.GetAvgTurnaroundTime());
            if (Quantumtime > 0)
            {
                ProcessManager_temp.RunRR(Quantumtime);
            }
            else
            {
                btn_PPCPU_RR_Click(sender, e);
            }
            temp1.Add(ProcessManager_temp.GetAvgWaitingTime());
            temp2.Add(ProcessManager_temp.GetAvgTurnaroundTime());

            Form frm = new SS_ppcpu(temp1, temp2, Quantumtime.ToString());
            frm.ShowDialog();

            Chaythuattoan();
        }
        #endregion

        #region ve
        private void vebieudogantt()
        {
            pn_ppcpu_GianDoGantt.Controls.Clear();

            Label lb = new Label();
            lb.Text = "Giản đồ Gantt";
            lb.ForeColor = Color.Lime;
            lb.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lb.AutoSize = false;
            lb.Size = new Size(300, 40);
            lb.TextAlign = ContentAlignment.MiddleLeft;
            lb.Top = 10;
            lb.Left = 10;
            pn_ppcpu_GianDoGantt.Controls.Add(lb);

            var timelines = ExecutionTimelineManager_temp.GetAllTimelines();
            if (timelines.Count == 0) return;

            int timeUnitWidth = 20;
            int rectHeight = 40;
            int spacing = 10;
            int yPosition = 70;

            int totalTime = timelines[timelines.Count - 1].GetEndTime();
            int firstStartTime = timelines[0].GetStartTime();
            int panelWidth = totalTime * timeUnitWidth + spacing * 2;
            pn_ppcpu_GianDoGantt.AutoScrollMinSize = new Size(panelWidth, rectHeight + 60);

            foreach (var tl in timelines)
            {
                string pname = tl.GetProcessName();
                int start = tl.GetStartTime();
                int end = tl.GetEndTime();
                int duration = end - start;

                int xPosition = spacing + (start - firstStartTime) * timeUnitWidth;
                int rectWidth = duration * timeUnitWidth;

                Panel processPanel = new Panel();
                processPanel.Location = new Point(xPosition, yPosition);
                processPanel.Size = new Size(rectWidth, rectHeight);
                processPanel.BackColor = processColorMap.ContainsKey(pname)
                                         ? processColorMap[pname]
                                         : Color.Gray;
                processPanel.BorderStyle = BorderStyle.FixedSingle;
                pn_ppcpu_GianDoGantt.Controls.Add(processPanel);

                Label nameLabel = new Label();
                nameLabel.Text = pname;
                nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                nameLabel.Dock = DockStyle.Fill;
                nameLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                nameLabel.ForeColor = Color.Black;
                processPanel.Controls.Add(nameLabel);

                Label startLabel = new Label();
                startLabel.Text = start.ToString();
                startLabel.Location = new Point(xPosition - 5, yPosition + rectHeight);
                startLabel.AutoSize = true;
                pn_ppcpu_GianDoGantt.Controls.Add(startLabel);

                Label endLabel = new Label();
                endLabel.Text = end.ToString();
                endLabel.Location = new Point(xPosition + rectWidth - 5, yPosition + rectHeight);
                endLabel.AutoSize = true;
                pn_ppcpu_GianDoGantt.Controls.Add(endLabel);
            }
        }
        #endregion

        #region cac ham ho tro
        private void reset_txt()
        {
            txt_ppcpu_nameprocess.Clear();
            txt_ppcpu_arrivingtime.Clear();
            txt_ppcpu_bursttime.Clear();
        }

        private Color GenerateUniqueColor()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            Color color;

            do
            {
                color = Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256));
            } while (processColorMap.Values.Contains(color));

            return color;
        }

        private void Chaythuattoan()
        {
            object sender = null;
            EventArgs e = EventArgs.Empty;
            switch (Thuattoan)
            {
                case "FCFS":
                    btn_PPCPU_FCFS_Click(sender, e);
                    break;

                case "SJF":
                    btn_PPCPU_SJF_Click(sender, e);
                    break;

                case "SRTF":
                    btn_PPCPU_SRTF_Click(sender, e);
                    break;

                case "RR":
                    ProcessManager_temp.RunRR(Quantumtime);
                    break;

                default:
                    break;
            }
        }

        private void ppcpu_dtgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (ppcpu_dtgv.CurrentCell.ColumnIndex > 0)
            {
                System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress -= OnlyAllowDigits_KeyPress;
                    tb.KeyPress += OnlyAllowDigits_KeyPress;
                }
            }
        }

        private void ppcpu_dtgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex > 2)
            {
                e.Cancel = true;
            }
        }
        
        private void ppcpu_dtgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ProcessManager_temp = new ProcessManager();

            foreach (DataGridViewRow row in ppcpu_dtgv.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells[0].Value?.ToString()?.Trim();
                bool ok1 = int.TryParse(row.Cells[1].Value?.ToString(), out int arrive);
                bool ok2 = int.TryParse(row.Cells[2].Value?.ToString(), out int burst);
                bool ok3 = int.TryParse(row.Cells[3].Value?.ToString(), out int wt);
                bool ok4 = int.TryParse(row.Cells[4].Value?.ToString(), out int tat);

                if (!string.IsNullOrEmpty(name) && ok1 && ok2)
                {
                    var p = new ProcessInfo(name, burst, arrive);

                    if (ok3) p.SetTurnaroundTime(wt);
                    if (ok4) p.SetWaitingTime(tat);

                    ProcessManager_temp.AddProcess(p);
                }

            }
            ProcessManager_temp.SortByArrivingTime();
            Loaddulieuprocess();
            Hienthidulieudong_txt(e.RowIndex);
            Chaythuattoan();
        }

        private void OnlyAllowDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_ppcpu_arrivingtime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_ppcpu_bursttime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ppcpu_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow == -1) return;
            Hienthidulieudong_txt(idrow);
        }

        private void ppcpu_dtgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
