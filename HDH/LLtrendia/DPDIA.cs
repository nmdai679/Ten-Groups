using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HDH
{
    public partial class DPDIA : Form
    {
        #region khai bao
        ChuoiCylinder ChuoiCylinder_temp = new ChuoiCylinder();
        static string tenthuattoan = "";
        int dpdia_gioihan = 0;
        #endregion

        #region cac ham load
        public DPDIA()
        {
            InitializeComponent();
        }

        private void DPDIA_Load(object sender, EventArgs e)
        {
            dtgv_cylinder.ReadOnly = false;
            dtgv_cylinder.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            LoadComboBoxChieu();
            loadstart();
        }

        private void Loaddulieu()
        {
            var temp = ChuoiCylinder_temp.GetDanhSachYeuCau().ToList();

            DataTable dt = new DataTable();

            for (int i = 0; i < temp.Count; i++)
            {
                dt.Columns.Add("", typeof(int));
            }
            dt.Rows.Add(temp.Cast<object>().ToArray());

            dtgv_cylinder.DataSource = dt;
            dtgv_cylinder.ColumnHeadersVisible = false;
            dtgv_cylinder.RowHeadersVisible = false;
            dtgv_cylinder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_cylinder.AllowUserToAddRows = false;
        }

        private void LoadComboBoxChieu()
        {
            cbb_dpdia_chieu.Items.Clear();
            cbb_dpdia_chieu.Items.Add("Lên");
            cbb_dpdia_chieu.Items.Add("Xuống");

            cbb_dpdia_chieu.SelectedIndex = 1;
        }

        private void loadstart()
        {
            lb_start.Text = ChuoiCylinder_temp.GetCylinderHienTai().ToString();
        }
        #endregion

        #region cac nut chuc nang nhap lieu, reset
        private void btn_dpdia_rf_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(openFileDialog.FileName);

                    if (lines.Length < 2)
                    {
                        MessageBox.Show("File không đúng định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ChuoiCylinder_temp.SetCylinderHienTai(int.Parse(lines[0]));
                    ChuoiCylinder_temp.SetDanhSachYeuCau(lines[1]
                        .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList());
                    MessageBox.Show("Đọc file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chart_dpdia.Series.Clear();
                    chart_dpdia.Titles.Clear();
                    chart_dpdia.Annotations.Clear();
                    Loaddulieu();
                    loadstart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void btn_dpdia_add_Click(object sender, EventArgs e)
        {
            List<int> temp = ChuoiCylinder_temp.GetDanhSachYeuCau();
            string input = txt_dpdia_add.Text.Trim();
            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    temp.Add(number);
                }
                else
                {
                    MessageBox.Show($"Giá trị '{part}' không hợp lệ. Vui lòng nhập chỉ số nguyên cách nhau bằng dấu cách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_dpdia_add.Clear();
                    return;
                }
            }
            ChuoiCylinder_temp.SetDanhSachYeuCau(temp);
            Loaddulieu();
            txt_dpdia_add.Clear();
        }

        private void btn_dpdia_reset_Click(object sender, EventArgs e)
        {
            chart_dpdia.Series.Clear();
            chart_dpdia.Titles.Clear();
            chart_dpdia.Annotations.Clear();
            ChuoiCylinder_temp = new ChuoiCylinder();
            Loaddulieu();
            loadstart();
        }

        private void btn_dpdia_set_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_dpdia_start.Text))
            {
                if (int.TryParse(txt_dpdia_start.Text, out int kq))
                {
                    ChuoiCylinder_temp.SetCylinderHienTai(kq);
                    loadstart();
                    txt_dpdia_start.Clear();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        #endregion

        #region cac nut chuc nang thuat toan
        private void btn_dpdia_fifo_Click(object sender, EventArgs e)
        {
            tenthuattoan = "FIFO";
            if (ChuoiCylinder_temp == null || ChuoiCylinder_temp.GetDanhSachYeuCau().Count == 0)
            {
                MessageBox.Show("Danh sách đọc đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> thuTuDoc = ChuoiCylinder_temp.RunFCFS();
            VeBieuDoDocDiaKieuZ(thuTuDoc, ChuoiCylinder_temp.GetTongTungBuoc(), tenthuattoan);
        }

        private void btn_dpdia_sstf_Click(object sender, EventArgs e)
        {
            tenthuattoan = "SSTF";
            if (ChuoiCylinder_temp == null || ChuoiCylinder_temp.GetDanhSachYeuCau().Count == 0)
            {
                MessageBox.Show("Danh sách đọc đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> thuTuDoc = ChuoiCylinder_temp.RunSSTF();
            VeBieuDoDocDiaKieuZ(thuTuDoc, ChuoiCylinder_temp.GetTongTungBuoc(), tenthuattoan);
        }

        private void btn_dpdia_scan_Click(object sender, EventArgs e)
        {
            tenthuattoan = "SCAN";
            if (ChuoiCylinder_temp == null || ChuoiCylinder_temp.GetDanhSachYeuCau().Count == 0)
            {
                MessageBox.Show("Danh sách đọc đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool btemp = (cbb_dpdia_chieu.SelectedIndex == 1);
            int max = ChuoiCylinder_temp.GetDanhSachYeuCau().Max();
            int gioiHan = max;

            if (!btemp)
            {
                if (!string.IsNullOrWhiteSpace(txt_dpdia_gioihan.Text) && int.TryParse(txt_dpdia_gioihan.Text, out int ghFromText) && ghFromText > max)
                {
                    gioiHan = ghFromText;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giới hạn hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dpdia_gioihan = gioiHan;

            List<int> thuTuDoc = ChuoiCylinder_temp.RunSCAN(btemp, gioiHan);
            VeBieuDoDocDiaKieuZ(thuTuDoc, ChuoiCylinder_temp.GetTongTungBuoc(), tenthuattoan);
        }

        private void btn_dpdia_cscan_Click(object sender, EventArgs e)
        {
            tenthuattoan = "C_SCAN";
            if (ChuoiCylinder_temp == null || ChuoiCylinder_temp.GetDanhSachYeuCau().Count == 0)
            {
                MessageBox.Show("Danh sách đọc đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool btemp = (cbb_dpdia_chieu.SelectedIndex == 1);
            int max = ChuoiCylinder_temp.GetDanhSachYeuCau().Max();
            int gioiHan = max;
            if (!string.IsNullOrWhiteSpace(txt_dpdia_gioihan.Text) && int.TryParse(txt_dpdia_gioihan.Text, out int ghFromText) && ghFromText > max)
            {
                gioiHan = ghFromText;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giới hạn hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dpdia_gioihan = gioiHan;
            List<int> thuTuDoc = ChuoiCylinder_temp.RunC_SCAN(btemp, gioiHan);
            VeBieuDoDocDiaKieuZ(thuTuDoc, ChuoiCylinder_temp.GetTongTungBuoc(), tenthuattoan);
        }

        private void btn_dpdia_look_Click(object sender, EventArgs e)
        {
            tenthuattoan = "LOOK";
            if (ChuoiCylinder_temp == null || ChuoiCylinder_temp.GetDanhSachYeuCau().Count == 0)
            {
                MessageBox.Show("Danh sách đọc đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool btemp = (cbb_dpdia_chieu.SelectedIndex == 1);
            List<int> thuTuDoc = ChuoiCylinder_temp.RunLOOK(btemp);
            VeBieuDoDocDiaKieuZ(thuTuDoc, ChuoiCylinder_temp.GetTongTungBuoc(), tenthuattoan);
        }

        private void btn_dpdia_clook_Click(object sender, EventArgs e)
        {
            tenthuattoan = "C_LOOK";
            if (ChuoiCylinder_temp == null || ChuoiCylinder_temp.GetDanhSachYeuCau().Count == 0)
            {
                MessageBox.Show("Danh sách đọc đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool btemp = (cbb_dpdia_chieu.SelectedIndex == 1);
            List<int> thuTuDoc = ChuoiCylinder_temp.RunC_LOOK(btemp);
            VeBieuDoDocDiaKieuZ(thuTuDoc, ChuoiCylinder_temp.GetTongTungBuoc(), tenthuattoan);
        }
        #endregion

        #region ve
        private void VeBieuDoDocDiaKieuZ(List<int> thuTuDoc, List<int> tong, string tenThuatToan)
        {
            chart_dpdia.Series.Clear();
            chart_dpdia.Titles.Clear();
            chart_dpdia.Annotations.Clear();
            chart_dpdia.ChartAreas[0].AxisX.CustomLabels.Clear();

            chart_dpdia.Titles.Add($"Biểu đồ {tenThuatToan}");

            var series = new Series("Đường đi");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Black;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 6;
            series.MarkerColor = Color.Red;
            series.IsValueShownAsLabel = false;

            int yTruoc = thuTuDoc[0];
            int plotY = yTruoc;

            series.Points.AddXY(0, plotY);
            AddLabel(0, plotY, yTruoc.ToString());

            for (int i = 1; i < thuTuDoc.Count; i++)
            {
                int yThuc = thuTuDoc[i];
                int xThuc = i;

                if (i > 1 && tong[i - 1] == tong[i - 2])
                {
                    series.Points.AddXY(xThuc, yThuc);
                    AddLabel(xThuc, yThuc, yThuc.ToString());
                    continue;
                }

                series.Points.AddXY(xThuc, yThuc);
                AddLabel(xThuc, yThuc, yThuc.ToString());
                yTruoc = yThuc;
            }

            chart_dpdia.Series.Add(series);

            var chartArea = chart_dpdia.ChartAreas[0];
            chartArea.AxisX.Title = "Tổng bước di chuyển = " + tong.Last().ToString();
            chartArea.AxisY.Title = "Cylinder được đọc";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = thuTuDoc.Count;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = thuTuDoc.Max();
            if(tenThuatToan == "SCAN" || tenThuatToan == "C_SCAN")
            {
                chartArea.AxisY.Maximum = Math.Max(chartArea.AxisY.Maximum, dpdia_gioihan);
            }

            CustomLabel label0 = new CustomLabel(-0.5, 0.5, "0 (0)", 0, LabelMarkStyle.None);
            chartArea.AxisX.CustomLabels.Add(label0);

            for (int i = 1; i < thuTuDoc.Count; i++)
            {
                string text = $"{i} ({tong[i - 1]})";
                CustomLabel cl = new CustomLabel(i - 0.5, i + 0.5, text, 0, LabelMarkStyle.None);
                chartArea.AxisX.CustomLabels.Add(cl);
            }

            void AddLabel(int x, int y, string text)
            {
                TextAnnotation label = new TextAnnotation();
                label.Text = text;
                label.X = x;
                label.Y = y + 5;
                label.Font = new Font("Arial", 8, FontStyle.Bold);
                label.ForeColor = Color.Red;
                label.AxisX = chart_dpdia.ChartAreas[0].AxisX;
                label.AxisY = chart_dpdia.ChartAreas[0].AxisY;
                chart_dpdia.Annotations.Add(label);
            }
        }
        #endregion

        #region cac ham ho tro
        private void OnlyAllowNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void dtgv_cylinder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtgv_cylinder.CurrentCell != null)
                {
                    int colIndex = dtgv_cylinder.CurrentCell.ColumnIndex;

                    if (colIndex >= 0 && colIndex < dtgv_cylinder.ColumnCount)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phần tử này không?",
                                                              "Xác nhận xóa",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            dtgv_cylinder.Columns.RemoveAt(colIndex);
                        }
                    }
                }
                List<int> temp = new List<int>();
                if (dtgv_cylinder.Rows.Count > 0)
                {
                    var row = dtgv_cylinder.Rows[0];

                    for (int i = 0; i < dtgv_cylinder.ColumnCount; i++)
                    {
                        if (row.Cells[i].Value != null && int.TryParse(row.Cells[i].Value.ToString(), out int value))
                        {
                            temp.Add(value);
                        }
                    }
                }
                ChuoiCylinder_temp.SetDanhSachYeuCau(temp);
                Loaddulieu();
                dtgv_cylinder.ClearSelection();
                dtgv_cylinder.CurrentCell = null;

            }
        }

        private void dtgv_cylinder_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
            if (tb != null)
            {
                tb.KeyPress -= OnlyAllowNumbers;
                tb.KeyPress += OnlyAllowNumbers;
            }
        }

        private void dtgv_cylinder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            List<int> temp = new List<int>();

            var row = dtgv_cylinder.Rows[0];
            for (int i = 0; i < dtgv_cylinder.ColumnCount; i++)
            {
                if (int.TryParse(row.Cells[i].Value?.ToString(), out int value))
                {
                    temp.Add(value);
                }
                else
                {
                    MessageBox.Show($"Ô cột {i} không hợp lệ. Vui lòng chỉ nhập số nguyên.",
                                    "Lỗi nhập liệu",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    row.Cells[i].Value = 0;
                    temp.Add(0);
                }
            }

            ChuoiCylinder_temp.SetDanhSachYeuCau(temp);
        }        

        private void txt_dpdia_gioihan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dpdia_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion        
    }

}
