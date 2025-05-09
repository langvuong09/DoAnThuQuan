using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using System;
using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public class DlgLoai : Form
    {
        private TheLoaiSachBUS theLoaiSachBUS = new TheLoaiSachBUS();
        private Label lblMaLoai;
        private Label lblTenLoai;
        private TextBox txtMaLoai;
        private TextBox txtTenLoai;
        private Button btnThem;

        public DlgLoai()
        {
            AddControls();
            AddEvents();
        }

        private void AddControls()
        {
            this.lblMaLoai = new Label();
            this.lblTenLoai = new Label();
            this.txtMaLoai = new TextBox();
            this.txtTenLoai = new TextBox();
            this.btnThem = new Button();

            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Location = new System.Drawing.Point(20, 20);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(46, 13);
            this.lblMaLoai.Text = "Mã loại:";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Location = new System.Drawing.Point(100, 17);
            this.txtMaLoai.Size = new System.Drawing.Size(150, 20);
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Location = new System.Drawing.Point(20, 60);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(49, 13);
            this.lblTenLoai.Text = "Tên loại:";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(100, 57);
            this.txtTenLoai.Size = new System.Drawing.Size(150, 20);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(100, 100);
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.Text = "Thêm";
            // 
            // DlgLoai
            // 
            this.ClientSize = new System.Drawing.Size(280, 150);
            this.Controls.Add(this.lblMaLoai);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.lblTenLoai);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Name = "DlgLoai";
            this.Text = "Thêm loại sách";
        }

        private void AddEvents()
        {
            btnThem.Click += XuLySuKienThemLoai;
        }

        private void XuLySuKienThemLoai(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MyDialog dlg = new MyDialog("Vui lòng nhập tên loại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return;
            }
            theLoaiSachBUS.ThemTheLoaiSach(txtTenLoai.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
