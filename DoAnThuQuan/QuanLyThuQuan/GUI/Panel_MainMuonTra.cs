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
    public partial class Panel_MainMuonTra : UserControl
    {
        public Panel_MainMuonTra()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel_MainMuonTra_Load(object sender, EventArgs e)
        {

        }

        private void button_PMuon_Click(object sender, EventArgs e)
        {
            Form newFormDialog = new Form
            {
                Text = "Phiếu Mượn",
                Size = new Size(1299, 800),
                StartPosition = FormStartPosition.CenterParent
            };

            Panel_PhieuMuon panel = new Panel_PhieuMuon();
          

            newFormDialog.Controls.Add(panel);
            newFormDialog.ShowDialog();
        }

        private void button_PPhat_Click(object sender, EventArgs e)
        {
            Form newFormDialog = new Form
            {
                Text = "Phiếu Phạt",
                Size = new Size(1299, 800),
                StartPosition = FormStartPosition.CenterParent
            };

            Panel_PhieuPhat panel = new Panel_PhieuPhat();


            newFormDialog.Controls.Add(panel);
            newFormDialog.ShowDialog();
        }

        private void button_PTra_Click(object sender, EventArgs e)
        {
            Form newFormDialog = new Form
            {
                Text = "Phiếu Trả",
                Size = new Size(1299, 800),
                StartPosition = FormStartPosition.CenterParent
            };

            Panel_PhieuTra panel = new Panel_PhieuTra();


            newFormDialog.Controls.Add(panel);
            newFormDialog.ShowDialog();
        }

        private void button_PDatCho_Click(object sender, EventArgs e)
        {
            Form newFormDialog = new Form
            {
                Text = "Phiếu Đặt Chỗ",
                Size = new Size(1299, 800),
                StartPosition = FormStartPosition.CenterParent
            };

            Panel_PDatCho panel = new Panel_PDatCho();


            newFormDialog.Controls.Add(panel);
            newFormDialog.ShowDialog();
        }
    }
}
