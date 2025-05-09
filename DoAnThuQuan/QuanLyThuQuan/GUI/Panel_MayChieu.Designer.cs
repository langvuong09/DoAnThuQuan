namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_MayChieu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label_title = new Label();
            label_TitleMaMayChieu = new Label();
            label_titleTinhTrang = new Label();
            textBox_MaMChieu = new TextBox();
            comboBox_TinhTrang = new ComboBox();
            dataGridView_DSMChieu = new DataGridView();
            textBox_TimKiem = new TextBox();
            button_TimKiem = new Button();
            button_LocTinhTrang = new Button();
            comboBox_LocTinhTrang = new ComboBox();
            button_Sua = new Button();
            button_Reload = new Button();
            button_XuatExcel = new Button();
            label_SoLuong = new Label();
            textBox_SoLuong = new TextBox();
            label_GiaTien = new Label();
            textBox_GiaTien = new TextBox();
            label_Link = new Label();
            textBox_Link = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSMChieu).BeginInit();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(125, 15);
            label_title.Name = "label_title";
            label_title.Size = new Size(164, 37);
            label_title.TabIndex = 0;
            label_title.Text = "MÁY CHIẾU";
            // 
            // label_TitleMaMayChieu
            // 
            label_TitleMaMayChieu.AutoSize = true;
            label_TitleMaMayChieu.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TitleMaMayChieu.Location = new Point(24, 74);
            label_TitleMaMayChieu.Name = "label_TitleMaMayChieu";
            label_TitleMaMayChieu.Size = new Size(160, 30);
            label_TitleMaMayChieu.TabIndex = 1;
            label_TitleMaMayChieu.Text = "Mã Máy Chiếu:";
            // 
            // label_titleTinhTrang
            // 
            label_titleTinhTrang.AutoSize = true;
            label_titleTinhTrang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleTinhTrang.Location = new Point(24, 186);
            label_titleTinhTrang.Name = "label_titleTinhTrang";
            label_titleTinhTrang.Size = new Size(124, 30);
            label_titleTinhTrang.TabIndex = 3;
            label_titleTinhTrang.Text = "Tình Trạng:";
            // 
            // textBox_MaMChieu
            // 
            textBox_MaMChieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_MaMChieu.Location = new Point(206, 61);
            textBox_MaMChieu.Multiline = true;
            textBox_MaMChieu.Name = "textBox_MaMChieu";
            textBox_MaMChieu.Size = new Size(391, 43);
            textBox_MaMChieu.TabIndex = 4;
            // 
            // comboBox_TinhTrang
            // 
            comboBox_TinhTrang.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_TinhTrang.FormattingEnabled = true;
            comboBox_TinhTrang.Location = new Point(206, 183);
            comboBox_TinhTrang.Name = "comboBox_TinhTrang";
            comboBox_TinhTrang.Size = new Size(391, 38);
            comboBox_TinhTrang.TabIndex = 6;
            // 
            // dataGridView_DSMChieu
            // 
            dataGridView_DSMChieu.AllowUserToAddRows = false;
            dataGridView_DSMChieu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_DSMChieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DSMChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_DSMChieu.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DSMChieu.Location = new Point(24, 284);
            dataGridView_DSMChieu.MultiSelect = false;
            dataGridView_DSMChieu.Name = "dataGridView_DSMChieu";
            dataGridView_DSMChieu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_DSMChieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DSMChieu.Size = new Size(1248, 405);
            dataGridView_DSMChieu.TabIndex = 7;
            // 
            // textBox_TimKiem
            // 
            textBox_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TimKiem.Location = new Point(619, 61);
            textBox_TimKiem.Multiline = true;
            textBox_TimKiem.Name = "textBox_TimKiem";
            textBox_TimKiem.Size = new Size(520, 43);
            textBox_TimKiem.TabIndex = 8;
            // 
            // button_TimKiem
            // 
            button_TimKiem.BackColor = Color.LightSeaGreen;
            button_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_TimKiem.ForeColor = SystemColors.ButtonFace;
            button_TimKiem.Location = new Point(1145, 61);
            button_TimKiem.Name = "button_TimKiem";
            button_TimKiem.Size = new Size(127, 43);
            button_TimKiem.TabIndex = 9;
            button_TimKiem.Text = "Tìm Kiếm";
            button_TimKiem.UseVisualStyleBackColor = false;
            // 
            // button_LocTinhTrang
            // 
            button_LocTinhTrang.BackColor = Color.LightSeaGreen;
            button_LocTinhTrang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_LocTinhTrang.ForeColor = SystemColors.ButtonFace;
            button_LocTinhTrang.Location = new Point(1016, 121);
            button_LocTinhTrang.Name = "button_LocTinhTrang";
            button_LocTinhTrang.Size = new Size(127, 38);
            button_LocTinhTrang.TabIndex = 10;
            button_LocTinhTrang.Text = "Lọc";
            button_LocTinhTrang.UseVisualStyleBackColor = false;
            // 
            // comboBox_LocTinhTrang
            // 
            comboBox_LocTinhTrang.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_LocTinhTrang.FormattingEnabled = true;
            comboBox_LocTinhTrang.Location = new Point(619, 121);
            comboBox_LocTinhTrang.Name = "comboBox_LocTinhTrang";
            comboBox_LocTinhTrang.Size = new Size(391, 38);
            comboBox_LocTinhTrang.TabIndex = 11;
            // 
            // button_Sua
            // 
            button_Sua.BackColor = Color.LightSeaGreen;
            button_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Sua.ForeColor = SystemColors.ButtonFace;
            button_Sua.Location = new Point(629, 183);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(127, 38);
            button_Sua.TabIndex = 14;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = false;
            // 
            // button_Reload
            // 
            button_Reload.BackColor = Color.Tomato;
            button_Reload.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Reload.ForeColor = SystemColors.ButtonFace;
            button_Reload.Location = new Point(762, 183);
            button_Reload.Name = "button_Reload";
            button_Reload.Size = new Size(127, 38);
            button_Reload.TabIndex = 15;
            button_Reload.Text = "Reload";
            button_Reload.UseVisualStyleBackColor = false;
            // 
            // button_XuatExcel
            // 
            button_XuatExcel.BackColor = Color.LightSeaGreen;
            button_XuatExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_XuatExcel.ForeColor = SystemColors.ButtonFace;
            button_XuatExcel.Location = new Point(895, 183);
            button_XuatExcel.Name = "button_XuatExcel";
            button_XuatExcel.Size = new Size(127, 38);
            button_XuatExcel.TabIndex = 16;
            button_XuatExcel.Text = "Xuất Excel";
            button_XuatExcel.UseVisualStyleBackColor = false;
            // 
            // label_SoLuong
            // 
            label_SoLuong.AutoSize = true;
            label_SoLuong.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_SoLuong.Location = new Point(24, 129);
            label_SoLuong.Name = "label_SoLuong";
            label_SoLuong.Size = new Size(112, 30);
            label_SoLuong.TabIndex = 2;
            label_SoLuong.Text = "Số lượng:";
            // 
            // textBox_SoLuong
            // 
            textBox_SoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SoLuong.Location = new Point(206, 116);
            textBox_SoLuong.Multiline = true;
            textBox_SoLuong.Name = "textBox_SoLuong";
            textBox_SoLuong.Size = new Size(391, 43);
            textBox_SoLuong.TabIndex = 5;
            // 
            // label_GiaTien
            // 
            label_GiaTien.AutoSize = true;
            label_GiaTien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_GiaTien.Location = new Point(24, 237);
            label_GiaTien.Name = "label_GiaTien";
            label_GiaTien.Size = new Size(98, 30);
            label_GiaTien.TabIndex = 26;
            label_GiaTien.Text = "Giá Tiền:";
            // 
            // textBox_GiaTien
            // 
            textBox_GiaTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_GiaTien.Location = new Point(206, 234);
            textBox_GiaTien.Multiline = true;
            textBox_GiaTien.Name = "textBox_GiaTien";
            textBox_GiaTien.Size = new Size(391, 43);
            textBox_GiaTien.TabIndex = 27;
            // 
            // label_Link
            // 
            label_Link.AutoSize = true;
            label_Link.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Link.Location = new Point(24, 290);
            label_Link.Name = "label_Link";
            label_Link.Size = new Size(62, 30);
            label_Link.TabIndex = 28;
            label_Link.Text = "Link:";
            // 
            // textBox_Link
            // 
            textBox_Link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Link.Location = new Point(206, 287);
            textBox_Link.Multiline = true;
            textBox_Link.Name = "textBox_Link";
            textBox_Link.Size = new Size(391, 43);
            textBox_Link.TabIndex = 29;
            // 
            // Panel_MayChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_XuatExcel);
            Controls.Add(button_Reload);
            Controls.Add(button_Sua);
            Controls.Add(comboBox_LocTinhTrang);
            Controls.Add(button_LocTinhTrang);
            Controls.Add(button_TimKiem);
            Controls.Add(textBox_TimKiem);
            Controls.Add(dataGridView_DSMChieu);
            Controls.Add(comboBox_TinhTrang);
            Controls.Add(textBox_SoLuong);
            Controls.Add(textBox_MaMChieu);
            Controls.Add(label_titleTinhTrang);
            Controls.Add(label_SoLuong);
            Controls.Add(label_TitleMaMayChieu);
            Controls.Add(label_title);
            Controls.Add(label_GiaTien);
            Controls.Add(textBox_GiaTien);
            Controls.Add(label_Link);
            Controls.Add(textBox_Link);
            Name = "Panel_MayChieu";
            Size = new Size(1290, 700);
            Load += Panel_MayChieu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSMChieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label_TitleMaMayChieu;
        private Label label_titleTinhTrang;
        private TextBox textBox_MaMChieu;
        private ComboBox comboBox_TinhTrang;
        private DataGridView dataGridView_DSMChieu;
        private TextBox textBox_TimKiem;
        private Button button_TimKiem;
        private Button button_LocTinhTrang;
        private ComboBox comboBox_LocTinhTrang;
        private Button button_Sua;
        private Button button_Reload;
        private Button button_XuatExcel;
        private Label label_SoLuong;
        private TextBox textBox_SoLuong;
        private Label label_GiaTien;
        private TextBox textBox_GiaTien;
        private Label label_Link;
        private TextBox textBox_Link;
    }
}
