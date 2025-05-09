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
    public partial class Component_NhapThietBiMoi : UserControl
    {
        public Component_NhapThietBiMoi()
        {
            InitializeComponent();
            InitializeCardLayout();
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

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

        private void button_MChieu_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("MayChieu");
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Component_NhapThietBiMoi_Load(object sender, EventArgs e)
        {

        }

        private void InitializeCardLayout()
        {
            cardLayout = new CardLayoutManager(panel_Main);

            var panel_NhapMayTinh = new Component_NhapMTinhMoi();
            var panel_NhapMayChieu = new Component_NhapMChieuMoi();

            cardLayout.AddCard("MayTinh", panel_NhapMayTinh);
            cardLayout.AddCard("MayChieu", panel_NhapMayChieu);

            cardLayout.Show("MayTinh"); // Hiển thị mặc định
        }

    }
}
