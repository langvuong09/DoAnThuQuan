using DoAnThuQuan.QuanLyThuQuan.BUS;

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
    public partial class Panel_ThongKe : UserControl
    {
        private ThongKeBUS thongKeBUS = new ThongKeBUS();
        public Panel_ThongKe()
        {
            InitializeComponent();
            AddEvents();
        }

        private void AddEvents()
        {
            string tongSach = Convert.ToString(thongKeBUS.TongSach());
            string tongMayTinh = Convert.ToString(thongKeBUS.TongMayTinh());
            string tongMayChieu = Convert.ToString(thongKeBUS.TongMayChieu());
            string tongThanhVien = Convert.ToString(thongKeBUS.TongThanhVien());
            string tongPM = Convert.ToString(thongKeBUS.TongPhieuMuon());
            string tongPT = Convert.ToString(thongKeBUS.TongPhieuTra());
            string tongPP = Convert.ToString(thongKeBUS.TongPhieuPhat());
            string tongPDC = Convert.ToString(thongKeBUS.TongPhieuDatCho());
            lblTongSach.Text = tongSach;
            lblTongMT.Text = tongMayTinh;
            lblTongMC.Text = tongMayChieu;
            lblTongThanhVien.Text = tongThanhVien;
            lblTongPM.Text = tongPM;
            lblTongPT.Text = tongPT;
            lblTongPP.Text = tongPP;
            lblTongDatCho.Text = tongPDC;

        }
    }
}
