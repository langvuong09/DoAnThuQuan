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
    public partial class Panel_ThietBi : UserControl
    {
        public Panel_ThietBi()
        {
            InitializeComponent();
        }

        private void Panel_ThietBi_Load(object sender, EventArgs e)
        {

        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {
            try
            {

                cardLayout = new CardLayoutManager(panel_Main);


                // Khởi tạo các panel
                var panel_MayTinh = new Panel_MayTinh();
                var panel_MayChieu = new Panel_MayChieu();
               
                cardLayout.AddCard("MayTinh", panel_MayTinh);
                cardLayout.AddCard("MayChieu", panel_MayChieu);

                cardLayout.Show("MayTinh"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Panel_TVien_Load_1: {ex.Message}\nStackTrace: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_MayTinh_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("MayTinh");
        }

        private void button_MayChieu_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("MayChieu");
        }
    }
}
