namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_NhanVien
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
            label_title = new Label();
            label_titleMaNVien = new Label();
            label_titleTenNVien = new Label();
            label_titleEmail = new Label();
            label_titleSDT = new Label();
            txtmaNVien = new TextBox();
            txtTenNVien = new TextBox();
            textBox_Email = new TextBox();
            textBox_SDT = new TextBox();
            textBox_DChi = new TextBox();
            label_titleDChi = new Label();
            dgvNhanVien = new DataGridView();
            colMaDocGia = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            textBox_TimKiem = new TextBox();
            button_TimKiem = new Button();
            button_Xoa = new Button();
            button_Sua = new Button();
            button_Reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(594, 12);
            label_title.Name = "label_title";
            label_title.Size = new Size(230, 50);
            label_title.TabIndex = 0;
            label_title.Text = "NHÂN VIÊN";
            // 
            // label_titleMaNVien
            // 
            label_titleMaNVien.AutoSize = true;
            label_titleMaNVien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleMaNVien.Location = new Point(39, 96);
            label_titleMaNVien.Name = "label_titleMaNVien";
            label_titleMaNVien.Size = new Size(204, 37);
            label_titleMaNVien.TabIndex = 1;
            label_titleMaNVien.Text = "Mã Nhân Viên:";
            // 
            // label_titleTenNVien
            // 
            label_titleTenNVien.AutoSize = true;
            label_titleTenNVien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleTenNVien.Location = new Point(39, 169);
            label_titleTenNVien.Name = "label_titleTenNVien";
            label_titleTenNVien.Size = new Size(208, 37);
            label_titleTenNVien.TabIndex = 2;
            label_titleTenNVien.Text = "Tên Nhân Viên:";
            // 
            // label_titleEmail
            // 
            label_titleEmail.AutoSize = true;
            label_titleEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleEmail.Location = new Point(39, 260);
            label_titleEmail.Name = "label_titleEmail";
            label_titleEmail.Size = new Size(94, 37);
            label_titleEmail.TabIndex = 3;
            label_titleEmail.Text = "Email:";
            // 
            // label_titleSDT
            // 
            label_titleSDT.AutoSize = true;
            label_titleSDT.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleSDT.Location = new Point(39, 344);
            label_titleSDT.Name = "label_titleSDT";
            label_titleSDT.Size = new Size(75, 37);
            label_titleSDT.TabIndex = 4;
            label_titleSDT.Text = "SĐT:";
            // 
            // txtmaNVien
            // 
            txtmaNVien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmaNVien.ForeColor = Color.IndianRed;
            txtmaNVien.Location = new Point(269, 96);
            txtmaNVien.Name = "txtmaNVien";
            txtmaNVien.ReadOnly = true;
            txtmaNVien.Size = new Size(455, 42);
            txtmaNVien.TabIndex = 5;
            // 
            // txtTenNVien
            // 
            txtTenNVien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenNVien.Location = new Point(269, 169);
            txtTenNVien.Name = "txtTenNVien";
            txtTenNVien.Size = new Size(455, 42);
            txtTenNVien.TabIndex = 6;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Email.Location = new Point(269, 241);
            textBox_Email.Margin = new Padding(3, 4, 3, 4);
            textBox_Email.Multiline = true;
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(455, 57);
            textBox_Email.TabIndex = 7;
            // 
            // textBox_SDT
            // 
            textBox_SDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SDT.Location = new Point(269, 325);
            textBox_SDT.Margin = new Padding(3, 4, 3, 4);
            textBox_SDT.Multiline = true;
            textBox_SDT.Name = "textBox_SDT";
            textBox_SDT.Size = new Size(455, 57);
            textBox_SDT.TabIndex = 8;
            // 
            // textBox_DChi
            // 
            textBox_DChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_DChi.Location = new Point(888, 108);
            textBox_DChi.Margin = new Padding(3, 4, 3, 4);
            textBox_DChi.Multiline = true;
            textBox_DChi.Name = "textBox_DChi";
            textBox_DChi.Size = new Size(567, 213);
            textBox_DChi.TabIndex = 9;
            // 
            // label_titleDChi
            // 
            label_titleDChi.AutoSize = true;
            label_titleDChi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleDChi.Location = new Point(779, 108);
            label_titleDChi.Name = "label_titleDChi";
            label_titleDChi.Size = new Size(115, 37);
            label_titleDChi.TabIndex = 10;
            label_titleDChi.Text = "Địa Chỉ:";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 29;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMaDocGia, colFullName, colEmail, colSoDienThoai, colDiaChi });
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.Location = new Point(16, 598);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1439, 412);
            dgvNhanVien.TabIndex = 11;
            // 
            // colMaDocGia
            // 
            colMaDocGia.HeaderText = "Mã đọc giả";
            colMaDocGia.MinimumWidth = 6;
            colMaDocGia.Name = "colMaDocGia";
            colMaDocGia.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Tên đọc giả";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.HeaderText = "Số điện thoại";
            colSoDienThoai.MinimumWidth = 6;
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // textBox_TimKiem
            // 
            textBox_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TimKiem.Location = new Point(101, 409);
            textBox_TimKiem.Margin = new Padding(3, 4, 3, 4);
            textBox_TimKiem.Multiline = true;
            textBox_TimKiem.Name = "textBox_TimKiem";
            textBox_TimKiem.Size = new Size(1124, 57);
            textBox_TimKiem.TabIndex = 12;
            // 
            // button_TimKiem
            // 
            button_TimKiem.BackColor = Color.MediumAquamarine;
            button_TimKiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_TimKiem.ForeColor = SystemColors.ButtonFace;
            button_TimKiem.Location = new Point(1246, 409);
            button_TimKiem.Margin = new Padding(3, 4, 3, 4);
            button_TimKiem.Name = "button_TimKiem";
            button_TimKiem.Size = new Size(208, 59);
            button_TimKiem.TabIndex = 13;
            button_TimKiem.Text = "Tìm";
            button_TimKiem.UseVisualStyleBackColor = false;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = Color.MediumAquamarine;
            button_Xoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Xoa.ForeColor = SystemColors.ButtonFace;
            button_Xoa.Location = new Point(347, 513);
            button_Xoa.Margin = new Padding(3, 4, 3, 4);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(208, 59);
            button_Xoa.TabIndex = 15;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Sua
            // 
            button_Sua.BackColor = Color.MediumAquamarine;
            button_Sua.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Sua.ForeColor = SystemColors.ButtonFace;
            button_Sua.Location = new Point(616, 513);
            button_Sua.Margin = new Padding(3, 4, 3, 4);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(208, 59);
            button_Sua.TabIndex = 16;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = false;
            // 
            // button_Reload
            // 
            button_Reload.BackColor = Color.Salmon;
            button_Reload.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Reload.ForeColor = SystemColors.ButtonFace;
            button_Reload.Location = new Point(888, 513);
            button_Reload.Margin = new Padding(3, 4, 3, 4);
            button_Reload.Name = "button_Reload";
            button_Reload.Size = new Size(208, 59);
            button_Reload.TabIndex = 17;
            button_Reload.Text = "Reload";
            button_Reload.UseVisualStyleBackColor = false;
            // 
            // Panel_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(button_Reload);
            Controls.Add(button_Sua);
            Controls.Add(button_Xoa);
            Controls.Add(button_TimKiem);
            Controls.Add(textBox_TimKiem);
            Controls.Add(dgvNhanVien);
            Controls.Add(label_titleDChi);
            Controls.Add(textBox_DChi);
            Controls.Add(textBox_SDT);
            Controls.Add(textBox_Email);
            Controls.Add(txtTenNVien);
            Controls.Add(txtmaNVien);
            Controls.Add(label_titleSDT);
            Controls.Add(label_titleEmail);
            Controls.Add(label_titleTenNVien);
            Controls.Add(label_titleMaNVien);
            Controls.Add(label_title);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Panel_NhanVien";
            Size = new Size(1474, 1013);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label_titleMaNVien;
        private Label label_titleTenNVien;
        private Label label_titleEmail;
        private Label label_titleSDT;
        private TextBox txtmaNVien;
        private TextBox txtTenNVien;
        private TextBox textBox_Email;
        private TextBox textBox_SDT;
        private TextBox textBox_DChi;
        private Label label_titleDChi;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn colMaDocGia;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private TextBox textBox_TimKiem;
        private Button button_TimKiem;
        private Button button_Xoa;
        private Button button_Sua;
        private Button button_Reload;
    }
}
