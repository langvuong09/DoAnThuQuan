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

using Thuvien.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_Component_DSPPhat : UserControl
    {
        private PhieuPhatHuDoBUS phieuPhatHuDoBUS;
        private CTPhatHuDoBUS ctPhatHuDoBUS;


        public Panel_Component_DSPPhat()
        {
            InitializeComponent();
            phieuPhatHuDoBUS = new PhieuPhatHuDoBUS();
            ctPhatHuDoBUS = new CTPhatHuDoBUS();
            LoadData();
        }



        private void LoadData()
        {
            // Load danh sách phiếu phạt
            dataGridView_DSPP.DataSource = null;
            dataGridView_DSPP.Rows.Clear();
            dataGridView_DSPP.Columns.Clear();
            dataGridView_DSPP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            // Thêm các cột
            dataGridView_DSPP.Columns.Add("idPhieuPhatHuDo", "Mã Phiếu Phạt");
            dataGridView_DSPP.Columns.Add("idPhieuTra", "Mã Phiếu Trả");
            dataGridView_DSPP.Columns.Add("solg", "Số Lượng");
            dataGridView_DSPP.Columns.Add("tongTien", "Tổng Tiền");

            // Load dữ liệu
            ArrayList listPhieuPhat = phieuPhatHuDoBUS.GetListPhieuPhatHuDo();
            foreach (PhieuPhatHuDo phieuPhat in listPhieuPhat)
            {
                dataGridView_DSPP.Rows.Add(
                    phieuPhat.idPhieuPhatHuDo,
                    phieuPhat.idPhieuTra,
                    phieuPhat.solg,
                    phieuPhat.tongTien
                );
            }

            // Load chi tiết phiếu phạt
            dataGridView_CTPP.DataSource = null;
            dataGridView_CTPP.Rows.Clear();
            dataGridView_CTPP.Columns.Clear();

            // Thêm các cột
            dataGridView_CTPP.Columns.Add("idPhieuPhatHuDo", "Mã Phiếu Phạt");
            dataGridView_CTPP.Columns.Add("idMondo", "Mã Món Đồ");
            dataGridView_CTPP.Columns.Add("mota", "Mô Tả");
            dataGridView_CTPP.Columns.Add("tien", "Tiền Phạt");

            // Load dữ liệu
            ArrayList listCTPhat = ctPhatHuDoBUS.GetListCTPhat();
            foreach (Chitiet_phathudo ctPhat in listCTPhat)
            {
                dataGridView_CTPP.Rows.Add(
                    ctPhat.id_phieuphatHuDo,
                    ctPhat.id_mondo,
                    ctPhat.mota,
                    ctPhat.tien
                );
            }
        }

        private void dataGridView_DSPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_DSPP.Rows[e.RowIndex];
                textBox1.Text = row.Cells["idPhieuPhatHuDo"].Value.ToString();
                textBox2.Text = row.Cells["idPhieuTra"].Value.ToString();
                textBox3.Text = row.Cells["solg"].Value.ToString();
                textBox4.Text = row.Cells["tongTien"].Value.ToString();
                dataGridView_CTPP.Rows.Clear();
                ArrayList list = ctPhatHuDoBUS.GetCTPhatByMaPhieuPhatHuDo(int.Parse(row.Cells["idPhieuPhatHuDo"].Value.ToString()));
                foreach (Chitiet_phathudo ctPhat in list)
                {
                    dataGridView_CTPP.Rows.Add(
                       ctPhat.id_phieuphatHuDo,
                       ctPhat.id_mondo,
                       ctPhat.mota,
                       ctPhat.tien
               );
                }

            }
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string searchText = textBox_TimKiem.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Bạn phải nhập mã phiếu trả thì mới có thể tìm kiếm");
                return;
            }

            if (!int.TryParse(searchText, out int maPhieuTra))
            {
                MessageBox.Show("Mã phiếu trả phải là một số nguyên hợp lệ");
                return;
            }

            PhieuPhatHuDo phieuPhat = phieuPhatHuDoBUS.TimPhieuPhatTheoId(maPhieuTra);
            dataGridView_DSPP.Rows.Clear();
            // Bạn có thể xử lý pp ở đây, ví dụ hiển thị thông tin nếu tìm thấy
            dataGridView_DSPP.Rows.Add(
                phieuPhat.idPhieuPhatHuDo,
                phieuPhat.idPhieuTra,
                phieuPhat.solg,
                phieuPhat.tongTien
            );
        }


        private void button_Loc_Click(object sender, EventArgs e)
        {


        }


        private void button_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
