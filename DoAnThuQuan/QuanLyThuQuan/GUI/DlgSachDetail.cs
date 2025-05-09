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
    public partial class DlgSachDetail : Form
    {
        private SachBUS sachBUS = new SachBUS();
        private SachDetailBUS sdBUS = new SachDetailBUS();
        public DlgSachDetail()
        {
            InitializeComponent();
            AddEvents();
        }

        private void AddEvents()
        {

            LoadDataLenTableSachDetail();
            btnTimKiem.Click += XuLyTimKiem;
        }

        private void LoadDataLenTableSachDetail()
        {
            sdBUS.DocListSachDetail();
            dgvSachDetail.Rows.Clear();

            ArrayList dssd = sdBUS.GetListSachDetail();
            foreach(SachDetail sd in dssd)
            {
                string trangThai = (sd.trangThai == 1) ? "Tốt" : "Hỏng";
                dgvSachDetail.Rows.Add(
                    sd.maSach,
                    sd.maDauSach,
                    sachBUS.GetTenSach(sd.maSach),
                    trangThai
                    );
            }
        }

        private void XuLyTimKiem(object sender, EventArgs e)
        {
            sdBUS.DocListSachDetail();
            dgvSachDetail.Rows.Clear();

            ArrayList dssd = sdBUS.TimKiemTheoTenSach(txtTimKiem.Text);
            foreach (SachDetail sd in dssd)
            {
                string trangThai = (sd.trangThai == 1) ? "Tốt" : "Hỏng";
                dgvSachDetail.Rows.Add(
                    sd.maDauSach,
                    sd.maSach,
                    sachBUS.GetSach(sd.maSach).tenSach,
                    trangThai
                    );
            }
        }
    }
}
