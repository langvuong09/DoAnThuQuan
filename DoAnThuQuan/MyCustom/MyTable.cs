using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnThuQuan.MyCustom
{
    internal class MyTable : DataGridView
    {
        public MyTable()
        {
            //======CUSTOM TABLE=======
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 67, 67);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersHeight = 30;
            this.RowTemplate.Height = 25;
            this.DefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Regular);
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(26, 116, 142);
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.MultiSelect = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
        }

        public MyTable(DataTable dt)
            : this()
        {
            this.DataSource = dt;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Center align the first column
            if (this.Columns.Count > 0)
            {
                this.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
