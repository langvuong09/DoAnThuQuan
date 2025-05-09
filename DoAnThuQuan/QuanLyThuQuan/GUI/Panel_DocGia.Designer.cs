using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_DocGia
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
            dgvDocGia = new DataGridView();
            colMaDocGia = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            lblMaDocGia = new Label();
            lblTenDocGia = new Label();
            txtMaDocGia = new TextBox();
            txtTenDocGia = new TextBox();
            label_titleEmail = new Label();
            label_titleSDT = new Label();
            textBox_Email = new TextBox();
            textBox_SDT = new TextBox();
            label_titleDiaChi = new Label();
            txtDiaChi = new TextBox();
            textBox_TimKiem = new TextBox();
            button_TimKiem = new Button();
            button_Xoa = new Button();
            button_Sua = new Button();
            button_Reload = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(600, 12);
            label_title.Name = "label_title";
            label_title.Size = new Size(174, 50);
            label_title.TabIndex = 0;
            label_title.Text = "ĐỌC GIẢ";
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocGia.ColumnHeadersHeight = 29;
            dgvDocGia.Columns.AddRange(new DataGridViewColumn[] { colMaDocGia, colFullName, colEmail, colSoDienThoai, colDiaChi });
            dgvDocGia.EnableHeadersVisualStyles = false;
            dgvDocGia.Location = new Point(21, 585);
            dgvDocGia.MultiSelect = false;
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.ReadOnly = true;
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.Size = new Size(1439, 345);
            dgvDocGia.TabIndex = 1;
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
            // lblMaDocGia
            // 
            lblMaDocGia.AutoSize = true;
            lblMaDocGia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaDocGia.Location = new Point(37, 111);
            lblMaDocGia.Name = "lblMaDocGia";
            lblMaDocGia.Size = new Size(171, 37);
            lblMaDocGia.TabIndex = 2;
            lblMaDocGia.Text = "Mã Đọc Giả:";
            // 
            // lblTenDocGia
            // 
            lblTenDocGia.AutoSize = true;
            lblTenDocGia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDocGia.Location = new Point(37, 176);
            lblTenDocGia.Name = "lblTenDocGia";
            lblTenDocGia.Size = new Size(175, 37);
            lblTenDocGia.TabIndex = 3;
            lblTenDocGia.Text = "Tên Đọc Giả:";
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaDocGia.ForeColor = Color.IndianRed;
            txtMaDocGia.Location = new Point(216, 111);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.ReadOnly = true;
            txtMaDocGia.Size = new Size(444, 42);
            txtMaDocGia.TabIndex = 4;
            // 
            // txtTenDocGia
            // 
            txtTenDocGia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenDocGia.Location = new Point(216, 176);
            txtTenDocGia.Name = "txtTenDocGia";
            txtTenDocGia.Size = new Size(444, 42);
            txtTenDocGia.TabIndex = 5;
            // 
            // label_titleEmail
            // 
            label_titleEmail.AutoSize = true;
            label_titleEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleEmail.Location = new Point(37, 264);
            label_titleEmail.Name = "label_titleEmail";
            label_titleEmail.Size = new Size(94, 37);
            label_titleEmail.TabIndex = 6;
            label_titleEmail.Text = "Email:";
            // 
            // label_titleSDT
            // 
            label_titleSDT.AutoSize = true;
            label_titleSDT.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleSDT.Location = new Point(37, 345);
            label_titleSDT.Name = "label_titleSDT";
            label_titleSDT.Size = new Size(75, 37);
            label_titleSDT.TabIndex = 7;
            label_titleSDT.Text = "SĐT:";
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Email.Location = new Point(216, 248);
            textBox_Email.Margin = new Padding(3, 4, 3, 4);
            textBox_Email.Multiline = true;
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(444, 55);
            textBox_Email.TabIndex = 8;
            // 
            // textBox_SDT
            // 
            textBox_SDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SDT.Location = new Point(216, 329);
            textBox_SDT.Margin = new Padding(3, 4, 3, 4);
            textBox_SDT.Multiline = true;
            textBox_SDT.Name = "textBox_SDT";
            textBox_SDT.Size = new Size(444, 55);
            textBox_SDT.TabIndex = 9;
            // 
            // label_titleDiaChi
            // 
            label_titleDiaChi.AutoSize = true;
            label_titleDiaChi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleDiaChi.Location = new Point(730, 111);
            label_titleDiaChi.Name = "label_titleDiaChi";
            label_titleDiaChi.Size = new Size(115, 37);
            label_titleDiaChi.TabIndex = 10;
            label_titleDiaChi.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(839, 111);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(580, 181);
            txtDiaChi.TabIndex = 11;
            // 
            // textBox_TimKiem
            // 
            textBox_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TimKiem.Location = new Point(216, 416);
            textBox_TimKiem.Margin = new Padding(3, 4, 3, 4);
            textBox_TimKiem.Multiline = true;
            textBox_TimKiem.Name = "textBox_TimKiem";
            textBox_TimKiem.Size = new Size(941, 55);
            textBox_TimKiem.TabIndex = 12;
            // 
            // button_TimKiem
            // 
            button_TimKiem.BackColor = Color.MediumAquamarine;
            button_TimKiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_TimKiem.ForeColor = SystemColors.ButtonHighlight;
            button_TimKiem.Location = new Point(1182, 416);
            button_TimKiem.Margin = new Padding(3, 4, 3, 4);
            button_TimKiem.Name = "button_TimKiem";
            button_TimKiem.Size = new Size(193, 56);
            button_TimKiem.TabIndex = 13;
            button_TimKiem.Text = "Tìm";
            button_TimKiem.UseVisualStyleBackColor = false;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = Color.MediumAquamarine;
            button_Xoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Xoa.ForeColor = SystemColors.ButtonHighlight;
            button_Xoa.Location = new Point(365, 504);
            button_Xoa.Margin = new Padding(3, 4, 3, 4);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(193, 56);
            button_Xoa.TabIndex = 15;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Sua
            // 
            button_Sua.BackColor = Color.MediumAquamarine;
            button_Sua.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Sua.ForeColor = SystemColors.ButtonHighlight;
            button_Sua.Location = new Point(611, 504);
            button_Sua.Margin = new Padding(3, 4, 3, 4);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(193, 56);
            button_Sua.TabIndex = 16;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = false;
            // 
            // button_Reload
            // 
            button_Reload.BackColor = Color.Tomato;
            button_Reload.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Reload.ForeColor = SystemColors.ButtonHighlight;
            button_Reload.Location = new Point(863, 504);
            button_Reload.Margin = new Padding(3, 4, 3, 4);
            button_Reload.Name = "button_Reload";
            button_Reload.Size = new Size(193, 56);
            button_Reload.TabIndex = 17;
            button_Reload.Text = "Reload";
            button_Reload.UseVisualStyleBackColor = false;
            // 
            // Panel_DocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(button_Reload);
            Controls.Add(button_Sua);
            Controls.Add(button_Xoa);
            Controls.Add(button_TimKiem);
            Controls.Add(textBox_TimKiem);
            Controls.Add(txtDiaChi);
            Controls.Add(label_titleDiaChi);
            Controls.Add(textBox_SDT);
            Controls.Add(textBox_Email);
            Controls.Add(label_titleSDT);
            Controls.Add(label_titleEmail);
            Controls.Add(txtTenDocGia);
            Controls.Add(txtMaDocGia);
            Controls.Add(lblTenDocGia);
            Controls.Add(lblMaDocGia);
            Controls.Add(dgvDocGia);
            Controls.Add(label_title);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Panel_DocGia";
            Size = new Size(1474, 933);
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private DataGridView dgvDocGia;
        private DataGridViewTextBoxColumn colMaDocGia;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colDiaChi;
        private Label lblMaDocGia;
        private Label lblTenDocGia;
        private TextBox txtMaDocGia;
        private TextBox txtTenDocGia;
        private Label label_titleEmail;
        private Label label_titleSDT;
        private TextBox textBox_Email;
        private TextBox textBox_SDT;
        private Label label_titleDiaChi;
        private TextBox txtDiaChi;
        private TextBox textBox_TimKiem;
        private Button button_TimKiem;
        private Button button_Xoa;
        private Button button_Sua;
        private Button button_Reload;
    }
}
