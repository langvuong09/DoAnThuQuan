using ClosedXML.Excel;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.MyCustom
{
    internal class ExcelHandler
    {
        public void XuatExcel(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook|*.xlsx";
            sfd.Title = "Lưu file Excel";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable dt = new DataTable();

                        foreach (DataGridViewColumn col in dgv.Columns)
                            dt.Columns.Add(col.HeaderText);

                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                DataRow dr = dt.NewRow();
                                for (int i = 0; i < dgv.Columns.Count; i++)
                                {
                                    dr[i] = row.Cells[i].Value?.ToString() ?? "";
                                }
                                dt.Rows.Add(dr);
                            }
                        }

                        workbook.Worksheets.Add(dt, "Sheet1");
                        workbook.SaveAs(sfd.FileName);
                        new MyDialog("Xuất file thành công!", MyDialog.SUCCESS_DIALOG);
                    }
                }
                catch (Exception ex)
                {
                    new MyDialog("Xuất file thất bại!",MyDialog.ERROR_DIALOG);
                }
            }
        }

        public void NhapExcel(DataGridView dgv)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Workbook|*.xlsx";
            ofd.Title = "Chọn file Excel";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook(ofd.FileName))
                    {
                        var ws = workbook.Worksheet(1);
                        DataTable dt = new DataTable();

                        bool firstRow = true;
                        foreach (var row in ws.RowsUsed())
                        {
                            if (firstRow)
                            {
                                foreach (var cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (var cell in row.Cells())
                                {
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                                }
                            }
                        }

                        dgv.DataSource = dt;
                        new MyDialog("Nhập file thành công!",MyDialog.SUCCESS_DIALOG);
                    }
                }
                catch (Exception ex)
                {
                    new MyDialog("Nhập file thất bại!",MyDialog.ERROR_DIALOG);
                }
            }
        }
    }
}
