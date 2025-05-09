using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_TVien : UserControl
    {

       

        private void Panel_TVien_Load_1(object sender, EventArgs e)
        {
            InitializeCardLayout();
        }

        private void InitializeCardLayout()
        {
            try
            {
                cardLayout = new CardLayoutManager(panel_Main);


                // Khởi tạo các panel với màu nền để dễ debug
                var panelDocGia = new Panel_DocGia();

                var panelNhanVien = new Panel_NhanVien();

                var panelCheckInOut = new Panel_CheckInOut();


                cardLayout.AddCard("DocGia", panelDocGia);
                cardLayout.AddCard("NhanVien", panelNhanVien);
                cardLayout.AddCard("CheckInOut", panelCheckInOut);


                cardLayout.Show("DocGia"); // Mặc định hiển thị Panel_DocGia
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Panel_TVien_Load_1: {ex.Message}\nStackTrace: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_DocGia_Click(object sender, EventArgs e)
        {

            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("DocGia");
        }

        private void button_NVien_Click(object sender, EventArgs e)
        {

            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("NhanVien");
        }

        private void button_CheckInOut_Click(object sender, EventArgs e)
        {

            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("CheckInOut");
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {
            // Có thể thêm code vẽ tùy chỉnh nếu cần
        }
    }




}

