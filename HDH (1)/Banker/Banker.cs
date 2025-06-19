using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDH
{
    public partial class Banker : Form
    {
        Bankerinfor banker_temp = new Bankerinfor();

        #region cac ham load
        public Banker()
        {
            InitializeComponent();
        }

        private void loaddulieucbb()
        {
            cbb_bk_gtcptnpc.Items.Clear();

            if (banker_temp.GetProcessCount() <= 0)
            {
                return;
            }

            for (int i = 0; i < banker_temp.GetProcessCount(); i++)
            {
                cbb_bk_gtcptnpc.Items.Add($"P{i + 1}");
            }

            if (cbb_bk_gtcptnpc.Items.Count > 0)
                cbb_bk_gtcptnpc.SelectedIndex = 0;
        }

        private void Banker_Load(object sender, EventArgs e)
        {
            dtgv_bk_allocation.ReadOnly = false;
            dtgv_bk_max.ReadOnly = false;
            dtgv_bk_available.ReadOnly = false;
        }
        #endregion

        #region nut chuc nang
        private void btn_bk_load_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_bk_soltn.Text) || string.IsNullOrWhiteSpace(txt_bk_soprocess.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ kiện.");
                return;
            }
            int processCount = int.Parse(txt_bk_soprocess.Text.Trim());
            int resourceCount = int.Parse(txt_bk_soltn.Text.Trim());

            if(processCount == 0 || resourceCount == 0 )
            {
                MessageBox.Show("Vui lòng nhập số dương.");
                return;
            }

            banker_temp.Init(processCount, resourceCount);

            dtgv_bk_allocation.Columns.Clear();
            dtgv_bk_allocation.Rows.Clear();
            dtgv_bk_max.Columns.Clear();
            dtgv_bk_max.Rows.Clear();
            dtgv_bk_available.Columns.Clear();
            dtgv_bk_available.Rows.Clear();


            for (int j = 0; j < resourceCount; j++)
            {
                string header = $"T{j + 1}";
                dtgv_bk_allocation.Columns.Add(header, header);
                dtgv_bk_max.Columns.Add(header, header);
                dtgv_bk_available.Columns.Add(header, header);
                int k = 40;
                dtgv_bk_allocation.Columns[j].Width = k;
                dtgv_bk_max.Columns[j].Width = k;
                dtgv_bk_available.Columns[j].Width = k;
            }

            for (int i = 0; i < processCount; i++)
            {
                object[] allocRow = new object[resourceCount];
                object[] maxRow = new object[resourceCount];

                for (int j = 0; j < resourceCount; j++)
                {
                    allocRow[j] = 0;
                    maxRow[j] = 0;
                }

                dtgv_bk_allocation.Rows.Add(allocRow);
                dtgv_bk_max.Rows.Add(maxRow);
                dtgv_bk_allocation.Rows[i].HeaderCell.Value = $"P{i + 1}";
            }

            object[] avaRow = new object[resourceCount];
            for (int j = 0; j < resourceCount; j++)
            {
                avaRow[j] = 0;
            }
            dtgv_bk_available.Rows.Add(avaRow);
            dtgv_bk_available.RowHeadersVisible = false;

            dtgv_bk_max.RowHeadersVisible = false;

            dtgv_bk_allocation.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_bk_max.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_bk_available.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            loaddulieucbb();
        }

        private void btn_bk_ktcat_Click(object sender, EventArgs e)
        {
            if (banker_temp.GetAllocation() == null || banker_temp.GetMax() == null || banker_temp.GetAvailable() == null)
            {
                MessageBox.Show("Dữ liệu chưa được khởi tạo. Vui lòng nhập hoặc đọc file trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (banker_temp.IsSafeState(out List<int> safeSequence))
            {
                string result = "Hệ thống ở trạng thái **AN TOÀN**.\nChuỗi an toàn: ";
                for (int i = 0; i < safeSequence.Count; i++)
                {
                    result += $"P{safeSequence[i] + 1}";
                    if (i < safeSequence.Count - 1) result += " -> ";
                }
                MessageBox.Show(result, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = new KT_Chuoiantoan(banker_temp.GetWorkHistory(), result.Substring(35));
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hệ thống KHÔNG ở trạng thái an toàn (CÓ KHẢ NĂNG DEADLOCK).", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_bk_df_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] rawLines = System.IO.File.ReadAllLines(ofd.FileName);
                    List<string> lines = rawLines
                        .Select(line => line.Trim())
                        .Where(line => !string.IsNullOrWhiteSpace(line))
                        .ToList();

                    if (lines.Count < 3)
                        throw new Exception("File không đủ dòng dữ liệu!");

                    string[] header = lines[0].Split();
                    if (header.Length != 2)
                        throw new Exception("Dòng đầu phải có đúng 2 số: số tiến trình và số tài nguyên!");

                    int m = int.Parse(header[0]);
                    int n = int.Parse(header[1]);

                    if (lines.Count != 1 + 1 + m + m)
                        throw new Exception($"File phải có đúng {1 + 1 + m + m} dòng dữ liệu (header + available + allocation + max)!");

                    int[] available = new int[n];
                    string[] avaTokens = lines[1].Split();
                    if (avaTokens.Length != n)
                        throw new Exception("Dòng Available phải có đúng số tài nguyên!");
                    for (int j = 0; j < n; j++)
                        available[j] = int.Parse(avaTokens[j]);

                    int[,] allocation = new int[m, n];
                    for (int i = 0; i < m; i++)
                    {
                        string[] row = lines[2 + i].Split();
                        if (row.Length != n)
                            throw new Exception($"Dòng Allocation của P{i + 1} không đủ {n} tài nguyên!");
                        for (int j = 0; j < n; j++)
                            allocation[i, j] = int.Parse(row[j]);
                    }

                    int[,] max = new int[m, n];
                    for (int i = 0; i < m; i++)
                    {
                        string[] row = lines[2 + m + i].Split();
                        if (row.Length != n)
                            throw new Exception($"Dòng Max của P{i + 1} không đủ {n} tài nguyên!");
                        for (int j = 0; j < n; j++)
                            max[i, j] = int.Parse(row[j]);
                    }

                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (allocation[i, j] > max[i, j])
                            {
                                throw new Exception($"Allocation tại P{i + 1}, T{j + 1} lớn hơn Max.");
                            }
                        }
                    }

                    banker_temp.SetProcessCount(m);
                    banker_temp.SetResourceCount(n);
                    banker_temp.SetAllocation(allocation);
                    banker_temp.SetMax(max);
                    banker_temp.SetAvailable(available);
                    banker_temp.SetWorkHistory(new List<int[]>());

                    UpdateDataGrids();
                    loaddulieucbb();

                    MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc file:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_bk_run_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_bk_gtcptnpc.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn tiến trình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int processIndex = cbb_bk_gtcptnpc.SelectedIndex;
                string[] requestStrings = txt_bk_gtcptnyc.Text.Trim().Split(' ');
                int resourceCount = banker_temp.GetResourceCount();

                if (requestStrings.Length != resourceCount)
                {
                    MessageBox.Show($"Vui lòng nhập đúng số lượng tài nguyên ({resourceCount}) cách nhau bằng dấu cách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int[] request = new int[resourceCount];
                for (int i = 0; i < resourceCount; i++)
                {
                    if (!int.TryParse(requestStrings[i], out request[i]) || request[i] < 0)
                    {
                        MessageBox.Show("Giá trị tài nguyên phải là số nguyên không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (banker_temp.HandleRequest(processIndex, request, out List<int> safeSequence, out string msg))
                {
                    string result = msg + "\nChuỗi an toàn: ";
                    for (int i = 0; i < safeSequence.Count; i++)
                    {
                        result += $"P{safeSequence[i] + 1}";
                        if (i < safeSequence.Count - 1) result += " -> ";
                    }

                    DialogResult dialog = MessageBox.Show(result + "\n\nBạn có muốn cập nhật trạng thái hệ thống không?", "Cập nhật?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.No)
                    {
                        for (int i = 0; i < resourceCount; i++)
                        {
                            banker_temp.GetAvailable()[i] += request[i];
                            banker_temp.GetAllocation()[processIndex, i] -= request[i];
                        }
                    }
                }
                else
                {
                    MessageBox.Show(msg, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UpdateDataGrids();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_bk_ktdl_Click(object sender, EventArgs e)
        {
            if (banker_temp.GetAllocation() == null || banker_temp.GetMax() == null || banker_temp.GetAvailable() == null)
            {
                MessageBox.Show("Dữ liệu chưa được khởi tạo. Vui lòng nhập hoặc đọc file trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<int> deadlocked = banker_temp.DetectDeadlock();

                if (deadlocked.Count == 0)
                {
                    MessageBox.Show("Hệ thống KHÔNG bị deadlock.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string result = "Hệ thống đang bị DEADLOCK. Các tiến trình bị kẹt: ";
                    result += string.Join(", ", deadlocked.Select(p => $"P{p + 1}"));
                    MessageBox.Show(result, "Deadlock Phát hiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region cac ham ho tro
        private void UpdateDataGrids()
        {
            dtgv_bk_allocation.Columns.Clear();
            dtgv_bk_max.Columns.Clear();
            dtgv_bk_available.Columns.Clear();
            dtgv_bk_allocation.Rows.Clear();
            dtgv_bk_max.Rows.Clear();
            dtgv_bk_available.Rows.Clear();

            int processCount = banker_temp.GetProcessCount();
            int resourceCount = banker_temp.GetResourceCount();

            int[,] allocation = banker_temp.GetAllocation();
            int[,] max = banker_temp.GetMax();
            int[] available = banker_temp.GetAvailable();

            for (int j = 0; j < resourceCount; j++)
            {
                string header = $"T{j + 1}";
                dtgv_bk_allocation.Columns.Add(header, header);
                dtgv_bk_max.Columns.Add(header, header);
                dtgv_bk_available.Columns.Add(header, header);
                dtgv_bk_allocation.Columns[j].Width = 40;
                dtgv_bk_max.Columns[j].Width = 40;
                dtgv_bk_available.Columns[j].Width = 40;
            }
            for (int i = 0; i < processCount; i++)
            {
                object[] allocRow = new object[resourceCount];
                object[] maxRow = new object[resourceCount];
                for (int j = 0; j < resourceCount; j++)
                {
                    allocRow[j] = allocation[i, j];
                    maxRow[j] = max[i, j];
                }
                dtgv_bk_allocation.Rows.Add(allocRow);
                dtgv_bk_max.Rows.Add(maxRow);
                dtgv_bk_allocation.Rows[i].HeaderCell.Value = $"P{i + 1}";
                dtgv_bk_max.Rows[i].HeaderCell.Value = $"P{i + 1}";
            }
            object[] avaRow = new object[resourceCount];
            for (int j = 0; j < resourceCount; j++)
            {
                avaRow[j] = available[j];
            }
            dtgv_bk_available.Rows.Add(avaRow);

            dtgv_bk_available.RowHeadersVisible = false;
            dtgv_bk_max.RowHeadersVisible = false;
            dtgv_bk_allocation.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_bk_max.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_bk_available.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txt_bk_soprocess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_bk_soltn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Dtgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                tb.KeyPress -= OnlyAllowDigits_KeyPress;
                tb.KeyPress += OnlyAllowDigits_KeyPress;
            }
        }

        private void OnlyAllowDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
                    
        private void dtgv_bk_allocation_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (int.TryParse(dtgv_bk_allocation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int value))
            {
                if (value > banker_temp.Max[e.RowIndex, e.ColumnIndex])
                {
                    MessageBox.Show("Allocation không được lớn hơn max.");
                    dtgv_bk_allocation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = banker_temp.Max[e.RowIndex, e.ColumnIndex];
                    return;
                }
                banker_temp.SetAllocationAt(e.RowIndex, e.ColumnIndex, value);
            }
            else
            {
                dtgv_bk_allocation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                banker_temp.SetAllocationAt(e.RowIndex, e.ColumnIndex, 0);
            }
        }

        private void dtgv_bk_max_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (int.TryParse(dtgv_bk_max.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int value))
            {
                if (value < banker_temp.Allocation[e.RowIndex, e.ColumnIndex])
                {
                    MessageBox.Show("Max không được nhỏ hơn allocation.");
                    dtgv_bk_max.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = banker_temp.Allocation[e.RowIndex, e.ColumnIndex];
                    return;
                }
                banker_temp.Max[e.RowIndex, e.ColumnIndex] = value;
            }
            else
            {
                dtgv_bk_max.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                banker_temp.Max[e.RowIndex, e.ColumnIndex] = 0;
            }
        }

        private void dtgv_bk_available_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (int.TryParse(dtgv_bk_available.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int value))
            {
                banker_temp.Available[e.ColumnIndex] = value;
            }
            else
            {
                dtgv_bk_available.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                banker_temp.Available[e.ColumnIndex] = 0;
            }
        }
        #endregion
    }
}
