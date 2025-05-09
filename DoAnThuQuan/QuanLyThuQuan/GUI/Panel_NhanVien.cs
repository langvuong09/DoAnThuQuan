using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;

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

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_NhanVien : UserControl
    {
        private UserBUS userBUS = new UserBUS();
        public Panel_NhanVien()
        {
            InitializeComponent();
            AddEvents();
        }

        private void AddEvents()
        {
            LoadDataLenTableNhanVien();
            dgvNhanVien.CellClick += new DataGridViewCellEventHandler(dgvNVien_CellClick);
            button_Reload.Click += XuLyReset;
            button_Sua.Click += XuLySuaNVien;
            button_Xoa.Click += XuLyXoaNVien;
            button_TimKiem.Click += XuLyTimNVien;
        }

        private void dgvNVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                XuLyClickTblNVien();
            }
        }

        private void LoadDataLenTableNhanVien()
        {
            userBUS.DocListNVien();
            dgvNhanVien.Rows.Clear();

            ArrayList dsu = userBUS.GetListNVien();
            foreach (User u in dsu)
            {
                dgvNhanVien.Rows.Add(
                    u.userId,
                    u.fullName,
                    u.email,
                    u.soDienThoai,
                    u.diaChi
                    );
            }
        }

        private void XuLyClickTblNVien()
        {
            int row = dgvNhanVien.CurrentCell.RowIndex;
            if( row >= 0 )
            {
                string maNV = dgvNhanVien.Rows[row].Cells[0].Value?.ToString();
                string ten = dgvNhanVien.Rows[row].Cells[1].Value?.ToString();
                string email = dgvNhanVien.Rows[row].Cells[2].Value?.ToString();
                string sdt= dgvNhanVien.Rows[row].Cells[3].Value?.ToString();
                string diacChi = dgvNhanVien.Rows[row].Cells[4].Value?.ToString();

                txtmaNVien.Text = maNV;
                txtTenNVien.Text = ten;
                textBox_Email.Text = email;
                textBox_SDT.Text = sdt;
                textBox_DChi.Text = diacChi;
            }
        }

        private void XuLyReset( object sender, EventArgs e)
        {
            txtmaNVien.Text = "";
            txtTenNVien.Text = "";
            textBox_Email.Text = "";
            textBox_SDT.Text = "";
            textBox_DChi.Text = "";
            LoadDataLenTableNhanVien();
        }

        private void XuLySuaNVien( object sender, EventArgs e )
        {
            userBUS.SuaUser(txtmaNVien.Text,txtTenNVien.Text,textBox_Email.Text,textBox_SDT.Text,textBox_DChi.Text,"0");
            LoadDataLenTableNhanVien();
            XuLyReset(sender, e);
        }

        private void XuLyXoaNVien(object sender, EventArgs e )
        {
            userBUS.XoaUser(txtmaNVien.Text);
            LoadDataLenTableNhanVien();
            XuLyReset(sender, e);
        }

        private void XuLyTimNVien(object sender, EventArgs e)
        {
            dgvNhanVien.Rows.Clear();

            foreach(User u in userBUS.GetNVien(textBox_TimKiem.Text))
            {
                dgvNhanVien.Rows.Add(
                    u.userId,
                    u.fullName,
                    u.email,
                    u.soDienThoai,
                    u.diaChi
                    );
            }
        }
    }
}
