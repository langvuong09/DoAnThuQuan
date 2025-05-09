using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using DocumentFormat.OpenXml.Wordprocessing;
using Thuvien.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_CheckInOut : UserControl
    {
        private CheckInOut_BUS checkinoutBUS = new CheckInOut_BUS();
        private UserBUS userBUS = new UserBUS();
        public Panel_CheckInOut()
        {
            InitializeComponent();
            CustomizeDataGridView(dataGridView_Checkinout);
            LoadDaTa();
        }
        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("user_id", "ID Độc Giả");
                dgv.Columns.Add("user_name", "Tên Độc Giả ");
                dgv.Columns.Add("time_in", "Thời Gian Vào ");

                dgv.Columns["user_id"].Width = 200;
                dgv.Columns["user_name"].Width = 200;
                dgv.Columns["time_in"].Width = 200;

            }
        }

        private void LoadDaTa()
        {
            ArrayList list = checkinoutBUS.GetAllCheckInOut();
            // Xóa dữ liệu cũ
            dataGridView_Checkinout.Rows.Clear();

            foreach (Check_in_out dataItem in list)
            {
                dataGridView_Checkinout.Rows.Add(
                    dataItem.user_id.ToString(),
                    userBUS.getUserById(dataItem.user_id).fullName,
                    dataItem.time_in
                );

            }

        }
        private void dateTimePicker_Loc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel_CheckInOut_Load(object sender, EventArgs e)
        {

        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            LoadDaTa();
            textBox_TimeCheckIn.Text = "";
            textBox_MaDG.Text = "";
            textBox_IDDOGIA.Text = "";
        }

        private void button_checkIn_Click(object sender, EventArgs e)
        {
            String id = textBox_IDDOGIA.Text;
            if (id == null)
            {
                MessageBox.Show("Bạn phải nhập mã đọc giả thì mới checkin được");
                return;
            }
            User user = userBUS.getUserById(int.Parse(id));
            if (user == null)
            {
                MessageBox.Show("Bạn không phảo là thành viên trong thư quán");
                return;
            }
            DateTime now = DateTime.Now;
            if (checkinoutBUS.ThemCheckInOut(user.userId, now, now))
            {
                MessageBox.Show("Chào mừng bạn -" + user.fullName + "- đã đến với thư quán!");
            }
            dataGridView_Checkinout.Rows.Add(id, user.fullName, now.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        private void button_Loc_Click(object sender, EventArgs e)
        {
            DateTime tgian = dateTimePicker_Loc.Value;
            ArrayList list = checkinoutBUS.GetCheckInOutByDate(tgian);

            if (list == null) return;

            dataGridView_Checkinout.Rows.Clear(); // Xóa dữ liệu cũ

            foreach (Check_in_out dataItem in list)
            {
                var user = userBUS.getUserById(dataItem.user_id);
                string fullName = user != null ? user.fullName : "Không tìm thấy";

                dataGridView_Checkinout.Rows.Add(
                    dataItem.user_id.ToString(),
                    fullName,
                    dataItem.time_in.ToString("dd/MM/yyyy HH:mm:ss")
                );
            }
        }

        private void dataGridView_Checkinout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView_Checkinout.Rows[e.RowIndex];
                    textBox_MaDG.Text = row.Cells[0].Value.ToString();
                    textBox_TenDG.Text = row.Cells[1].Value.ToString(); ;
                    textBox_TimeCheckIn.Text = row.Cells[2].Value.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}\nChi tiết: {ex.StackTrace}");
                }
            }
        }
    }
}
