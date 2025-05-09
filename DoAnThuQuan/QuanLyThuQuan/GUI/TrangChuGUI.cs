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
    public partial class TrangChuGUI : Form
    {
        public TrangChuGUI()
        {
            InitializeComponent();
            InitializeCardLayout();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TrangChuGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("TrangChu");
        }

        private void button_KhongGian_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("KhongGian");
        }

        private void button_ThietBi_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("ThietBi");
        }

        private void button_MuonTra_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("MuonTra");
        }

        private void button_ThanhVien_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("ThanhVien");
        }

        private void button_Sach_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("Sach");
        }

        private void button_NhapSach_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("NhapSach");
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            if (cardLayout == null)
            {
                MessageBox.Show("CardLayoutManager is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cardLayout.Show("ThongKe");
        }

        private void InitializeCardLayout()
        {
            try
            {

                cardLayout = new CardLayoutManager(panel_Main);


                // Khởi tạo các panel
                var panel_TrangChu = new Panel_TrangChu();
                var panel_KhongGian = new KhongGianGUI();
                var panel_ThietBi = new Panel_ThietBi();
                var panel_MuonTra = new Panel_MainMuonTra();
                var panel_TVien = new Panel_TVien();
                var panel_Sach = new Panel_Sach();
                var panel_NhapSach = new PhieuNhapGUI();
                var panel_ThongKe = new Panel_ThongKe();


                cardLayout.AddCard("TrangChu", panel_TrangChu);
                cardLayout.AddCard("KhongGian", panel_KhongGian);
                cardLayout.AddCard("ThietBi", panel_ThietBi);
                cardLayout.AddCard("MuonTra", panel_MuonTra);
                cardLayout.AddCard("ThanhVien", panel_TVien);
                cardLayout.AddCard("Sach", panel_Sach);
                cardLayout.AddCard("NhapSach", panel_NhapSach);
                cardLayout.AddCard("ThongKe", panel_ThongKe);

                cardLayout.Show("TrangChu"); // Mặc định hiển thị Panel_DocGia
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Panel_TVien_Load_1: {ex.Message}\nStackTrace: {ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
