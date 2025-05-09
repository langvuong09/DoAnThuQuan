using System;
using System.Windows.Forms;
using DoAnThuQuan.QuanLyThuQuan.BUS;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Form_ThemPhieuMuon : Form
    {
        private PhieuMuonBUS phieuMuonBUS;

        public Form_ThemPhieuMuon()
        {
            InitializeComponent();
            phieuMuonBUS = new PhieuMuonBUS();
        }

        private void Form_ThemPhieuMuon_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho thời gian mượn là thời gian hiện tại
            dateTimePicker_TgianMuon.Value = DateTime.Now;
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(textBox_MaPhieu.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã phiếu mượn!");
                    return;
                }

                if (string.IsNullOrEmpty(textBox_SoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng!");
                    return;
                }

                if (string.IsNullOrEmpty(textBox_NgMuon.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã người mượn!");
                    return;
                }

                if (string.IsNullOrEmpty(textBox_MaNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên!");
                    return;
                }

                // Lấy dữ liệu từ form
                int maPhieuMuon = int.Parse(textBox_MaPhieu.Text);
                DateTime tgianMuon = dateTimePicker_TgianMuon.Value;
                int soLuong = int.Parse(textBox_SoLuong.Text);
                int ngMuon = int.Parse(textBox_NgMuon.Text);
                int maNhanVien = int.Parse(textBox_MaNV.Text);

                // Thêm phiếu mượn
                bool result = phieuMuonBUS.ThemPhieuMuon(maPhieuMuon, tgianMuon, soLuong, ngMuon, maNhanVien);
                
                if (result)
                {
                    MessageBox.Show("Thêm phiếu mượn thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu mượn thất bại!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 