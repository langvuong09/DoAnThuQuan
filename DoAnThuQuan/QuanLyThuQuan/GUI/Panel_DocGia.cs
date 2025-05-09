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
    public partial class Panel_DocGia : UserControl
    {
        private UserBUS userBUS = new UserBUS();
        public Panel_DocGia()
        {
            InitializeComponent();
            AddEvents();
        }

        private void AddEvents()
        {
            LoadDataLenTableDocGia();
            dgvDocGia.CellClick += new DataGridViewCellEventHandler(dgvDocGia_CellClick);
            button_Reload.Click += XuLyReset;
            button_Sua.Click += XuLySuaDocGia;
            button_Xoa.Click += XuLyXoaDocGia;
            button_TimKiem.Click += XuLyTimDocGia;
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                XuLyClickTblDocGia();
            }
        }

        private void LoadDataLenTableDocGia()
        {
            userBUS.DocListNguoiDung();
            dgvDocGia.Rows.Clear();

            ArrayList dsu = userBUS.GetListNguoiDung();
            foreach (User u in dsu)
            {
                dgvDocGia.Rows.Add(
                    u.userId,
                    u.fullName,
                    u.email,
                    u.soDienThoai,
                    u.diaChi
                    );
            }
        }

        private void XuLyClickTblDocGia()
        {
            int row = dgvDocGia.CurrentCell.RowIndex;
            if (row >= 0)
            {
                string maNV = dgvDocGia.Rows[row].Cells[0].Value?.ToString();
                string ten = dgvDocGia.Rows[row].Cells[1].Value?.ToString();
                string email = dgvDocGia.Rows[row].Cells[2].Value?.ToString();
                string sdt = dgvDocGia.Rows[row].Cells[3].Value?.ToString();
                string diacChi = dgvDocGia.Rows[row].Cells[4].Value?.ToString();

                txtMaDocGia.Text = maNV;
                txtTenDocGia.Text = ten;
                textBox_Email.Text = email;
                textBox_SDT.Text = sdt;
                txtDiaChi.Text = diacChi;
            }
        }

        private void XuLyReset(object sender, EventArgs e)
        {
            txtMaDocGia.Text = "";
            txtTenDocGia.Text = "";
            textBox_Email.Text = "";
            textBox_SDT.Text = "";
            txtDiaChi.Text = "";
            LoadDataLenTableDocGia();
        }

        private void XuLySuaDocGia(object sender, EventArgs e)
        {
            userBUS.SuaUser(txtMaDocGia.Text, txtTenDocGia.Text, textBox_Email.Text, textBox_SDT.Text, txtDiaChi.Text, "0");
            LoadDataLenTableDocGia();
            XuLyReset(sender, e);
        }

        private void XuLyXoaDocGia(object sender, EventArgs e)
        {
            userBUS.XoaUser(txtMaDocGia.Text);
            LoadDataLenTableDocGia();
            XuLyReset(sender, e);
        }

        private void XuLyTimDocGia(object sender, EventArgs e)
        {
            dgvDocGia.Rows.Clear();

            foreach (User u in userBUS.GetNguoiDung(textBox_TimKiem.Text))
            {
                dgvDocGia.Rows.Add(
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
