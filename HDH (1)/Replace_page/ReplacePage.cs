using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace HDH
{
    public partial class ReplacePage : Form
    {
        #region khai bao bien
        static string repa_Thuattoan = "";
        PageResult page = new PageResult();
        public int N_f = 0;
        List<int> clockPointerHistory = new List<int>();
        public static List<List<bool>> usebitHistory = new List<List<bool>>();
        #endregion

        #region cac ham load
        public ReplacePage()
        {
            InitializeComponent();
        }

        private void loaddulieupage()
        {
            if (page.GetPages().Count == 0)
            {
                dtgv_repa.Rows.Clear();
                return;
            }

            dtgv_repa.Columns.Clear();
            dtgv_repa.Rows.Clear();
            dtgv_repa.ColumnHeadersVisible = false;

            for (int i = 0; i < page.GetPages().Count; ++i)
            {
                dtgv_repa.Columns.Add("col" + i, "");
                dtgv_repa.Columns[i].Width = 40;
            }

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dtgv_repa);
            for (int i = 0; i < page.GetPages().Count; ++i)
            {
                row.Cells[i].Value = page.GetPages()[i];
            }

            dtgv_repa.Rows.Add(row);
            dtgv_repa.RowHeadersVisible = false;
            dtgv_repa.AllowUserToAddRows = false;
            dtgv_repa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Chaythuattoan();
        }

        private void loadframe()
        {
            lb_fr.Text = page.GetframeCount().ToString();
        }

        private void ReplacePage_Load(object sender, EventArgs e)
        {
            dtgv_repa.ReadOnly = false;
            dtgv_repa.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            loadframe();
        }
        #endregion

        #region nut chuc nang
        private void btn_repa_opt_Click(object sender, EventArgs e)
        {
            repa_Thuattoan = "OPT";
            if (page.GetframeCount() == 0 || page.GetPages().Count == 0)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            page.RunOPT();
            refrepannel();
            vequatrinh();
        }

        private void btn_repa_lru_Click(object sender, EventArgs e)
        {
            repa_Thuattoan = "LRU";
            if (page.GetframeCount() == 0 || page.GetPages().Count == 0)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            page.RunLRU();
            refrepannel();
            vequatrinh();
        }
                
        private void btn_repa_fifo_Click(object sender, EventArgs e)
        {
            repa_Thuattoan = "FIFO";
            if (page.GetframeCount() == 0 || page.GetPages().Count == 0 )
            {
                MessageBox.Show("Vui lòng nhập dữ liệu đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            page.RunFIFO();
            refrepannel();
            vequatrinh();
        }

        private void btn_repa_clock_Click(object sender, EventArgs e)
        {
            repa_Thuattoan = "CLOCK";
            if (page.GetframeCount() == 0 || page.GetPages().Count == 0)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clockPointerHistory.Clear(); 
            usebitHistory.Clear();
            page.RunCLOCK(ref clockPointerHistory,ref usebitHistory);
            refrepannel();
            vequatrinh();
        }

        private void btn_repa_readfile_Click(object sender, EventArgs e)
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
                    if (int.Parse(lines[0]) <= 0)
                    {
                        MessageBox.Show("Số frame phải > 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    page.SetframeCount(int.Parse(lines[0]));
                    page.SetPages(lines[1]
                        .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList());
                    MessageBox.Show("Đọc file thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadframe();
                    refrepannel();
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

            loaddulieupage();
        }

        private void btn_repa_ss_Click(object sender, EventArgs e)
        {
            repa_Thuattoan = "SoSanh";
            if (page.GetframeCount() == 0 || page.GetframeCount() == 0)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<int> temp = new List<int>();
            page.RunOPT();
            temp.Add(page.GetFaults());
            page.RunLRU();
            temp.Add(page.GetFaults());
            page.RunFIFO();
            temp.Add(page.GetFaults());
            clockPointerHistory.Clear();
            usebitHistory.Clear();
            page.RunCLOCK(ref clockPointerHistory, ref usebitHistory);
            temp.Add(page.GetFaults());
            Form frm = new SS_ReplacePage(temp);
            frm.ShowDialog();
        }

        private void btn_repa_add_Click(object sender, EventArgs e)
        {
            List<int> temp = page.GetPages();
            string input = txt_repa_add.Text.Trim();
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
                    txt_repa_add.Clear();
                    return;
                }
            }
            page.SetPages(temp);
            loaddulieupage();
            txt_repa_add.Clear();
        }

        private void btn_repa_set_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_repa_set.Text))
            {
                if (int.TryParse(txt_repa_set.Text, out int kq))
                {
                    if (kq > 0)
                    {
                        page.SetframeCount(kq);
                        loadframe();
                        txt_repa_set.Clear();
                        Chaythuattoan();
                    }
                    else
                    {
                        MessageBox.Show("Frame phải > 0 ");
                    }
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

        private void btn_repa_reset_Click(object sender, EventArgs e)
        {
            page = new PageResult();
            loaddulieupage();
            loadframe();
            pn_repa_vungthuchien.Controls.Clear();
        }
        #endregion

        #region ve
        private void vequatrinh()
        {
            pn_repa_vungthuchien.Controls.Clear();

            Label lblChuoi = new Label();
            lblChuoi.Text = "Chuỗi tham chiếu trang";
            lblChuoi.AutoSize = true;
            lblChuoi.Font = new Font("Arial", 10, FontStyle.Bold);
            lblChuoi.Location = new Point(0, 15);
            pn_repa_vungthuchien.Controls.Add(lblChuoi);

            Label lblTen = new Label();
            lblTen.Text = repa_Thuattoan;
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTen.Location = new Point(30, 30 + (page.GetframeCount() * 30 + (page.GetframeCount() - 1) * 10) / 2);
            pn_repa_vungthuchien.Controls.Add(lblTen);

            int oSize = 30;
            int margin = 5;
            int startX = 180;
            int startY = 10;

            List<int> pages = page.GetPages();
            List<int> replaced = page.GetReplacedPages();
            int[,] snapshot = page.GetSnapshot();

            for (int i = 0; i < pages.Count; i++)
            {
                Label lblPage = new Label();
                lblPage.Text = pages[i].ToString();
                lblPage.TextAlign = ContentAlignment.MiddleCenter;
                lblPage.BorderStyle = BorderStyle.FixedSingle;
                lblPage.Size = new Size(oSize, oSize);
                lblPage.Location = new Point(startX + i * (oSize + margin), startY);
                lblPage.BackColor = Color.LightYellow;
                pn_repa_vungthuchien.Controls.Add(lblPage);
            }

            for (int f = 0; f < snapshot.GetLength(0); f++)
            {
                for (int i = 0; i < pages.Count; i++)
                {
                    int value = snapshot[f, i];

                    Label lbl = new Label();
                    if (repa_Thuattoan == "CLOCK" && value != -1 && usebitHistory.Count > i && usebitHistory[i][f])
                    {
                        lbl.Text = "*" + value.ToString();
                    }
                    else
                    {
                        lbl.Text = value == -1 ? "" : value.ToString();
                    }

                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Size = new Size(oSize, oSize);
                    lbl.Location = new Point(startX + i * (oSize + margin), startY + (f + 1) * (oSize + margin));

                    if (repa_Thuattoan == "CLOCK" && f == clockPointerHistory[i])
                    {
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.Paint += (s, pe) =>
                        {
                            ControlPaint.DrawBorder(pe.Graphics, lbl.ClientRectangle,
                                Color.Red, 2, ButtonBorderStyle.Solid,
                                Color.Red, 2, ButtonBorderStyle.Solid,
                                Color.Red, 2, ButtonBorderStyle.Solid,
                                Color.Red, 2, ButtonBorderStyle.Solid);
                        };
                    }
                    else
                    {
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                    }
                    pn_repa_vungthuchien.Controls.Add(lbl);
                }
            }
            for (int i = 0; i < replaced.Count; i++)
            {
                if (replaced[i] != -1)
                {
                    Label lblF = new Label();
                    lblF.Text = "F";
                    lblF.ForeColor = Color.Red;
                    lblF.Font = new Font("Arial", 10, FontStyle.Bold);
                    lblF.Size = new Size(oSize, oSize);
                    lblF.TextAlign = ContentAlignment.MiddleCenter;
                    lblF.Location = new Point(startX + i * (oSize + margin), startY + (snapshot.GetLength(0) + 1) * (oSize + margin));
                    pn_repa_vungthuchien.Controls.Add(lblF);
                }
            }

            int totalWidth = startX + pages.Count * (oSize + margin) + 20;
            int totalHeight = startY + (page.GetframeCount() + 2) * (oSize + margin) + 20;
            pn_repa_vungthuchien.AutoScrollMinSize = new Size(totalWidth, totalHeight);
        }
        #endregion

        #region ham ho tro
        private void Chaythuattoan()
        {
            object sender = null;
            EventArgs e = EventArgs.Empty;
            switch (repa_Thuattoan)
            {
                case "OPT":
                    btn_repa_opt_Click(sender, e);
                    break;

                case "LRU":
                    btn_repa_lru_Click(sender, e);
                    break;

                case "FIFO":
                    btn_repa_fifo_Click(sender, e);
                    break;

                case "CLOCK":
                    btn_repa_clock_Click(sender, e);
                    break;

                default:
                    break;
            }
        }

        private void refrepannel()
        {
            pn_repa_vungthuchien.Controls.Clear();
        }

        private void OnlyAllowDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
                
        private void dtgv_repa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dtgv_repa.CurrentCell != null)
                {
                    int colIndex = dtgv_repa.CurrentCell.ColumnIndex;
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phần tử này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        dtgv_repa.Columns.RemoveAt(colIndex);
                        List<int> temp = new List<int>();
                        if (dtgv_repa.Rows.Count > 0)
                        {
                            var row = dtgv_repa.Rows[0];

                            for (int i = 0; i < dtgv_repa.ColumnCount; i++)
                            {
                                if (row.Cells[i].Value != null && int.TryParse(row.Cells[i].Value.ToString(), out int value))
                                {
                                    temp.Add(value);
                                }
                            }
                        }
                        page.SetPages(temp);
                        loaddulieupage();
                        dtgv_repa.ClearSelection();
                        Chaythuattoan();
                        dtgv_repa.ClearSelection();
                        dtgv_repa.CurrentCell = null;
                    }
                }
                else
                {
                    return;
                }
            }
            else { return; }
        }

        private void txt_repa_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txt_repa_set_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
            }
        }
        
        private void dtgv_repa_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
            if (tb != null)
            {
                tb.KeyPress -= OnlyAllowDigits_KeyPress;
                tb.KeyPress += OnlyAllowDigits_KeyPress;
            }
        }

        private void dtgv_repa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            List<int> temp = new List<int>();

            var row = dtgv_repa.Rows[0];
            for (int i = 0; i < dtgv_repa.ColumnCount; i++)
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
                    return;
                }
            }
            page.SetPages(temp);
            loaddulieupage();
        }
        #endregion
    }
}


