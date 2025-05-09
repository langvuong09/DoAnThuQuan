namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Form_ThemPhieuMuon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MaPhieu = new System.Windows.Forms.TextBox();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.textBox_NgMuon = new System.Windows.Forms.TextBox();
            this.textBox_MaNV = new System.Windows.Forms.TextBox();
            this.dateTimePicker_TgianMuon = new System.Windows.Forms.DateTimePicker();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTimKiem
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "lblTimKiem";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // lblTitle
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "lblTitle";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian mượn:";
            // 
            // lblMaSanPham
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "lblMaSanPham";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // lblSoLuong
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "lblSoLuong";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã người mượn:";
            // 
            // lblPhieuNhap
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "lblPhieuNhap";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhân viên:";
            // 
            // textBox_MaPhieu
            // 
            this.textBox_MaPhieu.Location = new System.Drawing.Point(150, 27);
            this.textBox_MaPhieu.Name = "textBox_MaPhieu";
            this.textBox_MaPhieu.Size = new System.Drawing.Size(200, 20);
            this.textBox_MaPhieu.TabIndex = 5;
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(150, 107);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(200, 20);
            this.textBox_SoLuong.TabIndex = 6;
            // 
            // textBox_NgMuon
            // 
            this.textBox_NgMuon.Location = new System.Drawing.Point(150, 147);
            this.textBox_NgMuon.Name = "textBox_NgMuon";
            this.textBox_NgMuon.Size = new System.Drawing.Size(200, 20);
            this.textBox_NgMuon.TabIndex = 7;
            // 
            // textBox_MaNV
            // 
            this.textBox_MaNV.Location = new System.Drawing.Point(150, 187);
            this.textBox_MaNV.Name = "textBox_MaNV";
            this.textBox_MaNV.Size = new System.Drawing.Size(200, 20);
            this.textBox_MaNV.TabIndex = 8;
            // 
            // dateTimePicker_TgianMuon
            // 
            this.dateTimePicker_TgianMuon.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_TgianMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_TgianMuon.Location = new System.Drawing.Point(150, 67);
            this.dateTimePicker_TgianMuon.Name = "dateTimePicker_TgianMuon";
            this.dateTimePicker_TgianMuon.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_TgianMuon.TabIndex = 9;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(150, 230);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 10;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(275, 230);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(75, 23);
            this.button_Huy.TabIndex = 11;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // Form_ThemPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.dateTimePicker_TgianMuon);
            this.Controls.Add(this.textBox_MaNV);
            this.Controls.Add(this.textBox_NgMuon);
            this.Controls.Add(this.textBox_SoLuong);
            this.Controls.Add(this.textBox_MaPhieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_ThemPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm phiếu mượn";
            this.Load += new System.EventHandler(this.Form_ThemPhieuMuon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MaPhieu;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.TextBox textBox_NgMuon;
        private System.Windows.Forms.TextBox textBox_MaNV;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TgianMuon;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Huy;
    }
} 