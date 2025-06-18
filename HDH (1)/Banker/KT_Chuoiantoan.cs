using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HDH
{
    public partial class KT_Chuoiantoan : Form
    {
        public KT_Chuoiantoan(List<int[]> temp)
        {
            InitializeComponent();
            ShowWorkTrace(temp);
        }

        public void ShowWorkTrace(List<int[]> workList)
        {
            pn_bk_work.Controls.Clear();
            int x = 10, y = 10;
            int colSpacing = 40;
            int rowSpacing = 35;

            for (int j = 0; j < workList[0].Length; j++)
            {
                Label header = new Label();
                header.Text = $"T{j + 1}";
                header.AutoSize = true;
                header.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                header.Location = new Point(x + j * colSpacing, y);
                pn_bk_work.Controls.Add(header);
            }

            y += rowSpacing;

            for (int i = 0; i < workList.Count; i++)
            {
                int[] work = workList[i];
                for (int j = 0; j < work.Length; j++)
                {
                    Label lbl = new Label();
                    lbl.Text = work[j].ToString();
                    lbl.AutoSize = true;
                    lbl.Location = new Point(x + j * colSpacing, y);
                    lbl.Font = new Font("Segoe UI", 10);
                    pn_bk_work.Controls.Add(lbl);
                }
                if (i < workList.Count - 1)
                {
                    Label arrow = new Label();
                    arrow.Text = "↓";
                    arrow.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    arrow.AutoSize = true;

                    // Canh giữa theo chiều ngang
                    int totalWidth = (work.Length - 1) * colSpacing;
                    arrow.Location = new Point(x + totalWidth / 2, y + 20);

                    pn_bk_work.Controls.Add(arrow);
                }

                y += rowSpacing;
            }
        }
    }
}
