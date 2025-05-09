namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class DlgSachDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            fontDialog1 = new FontDialog();
            dgvSachDetail = new DataGridView();
            colMaPhanSach = new DataGridViewTextBoxColumn();
            colMaSach = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSachDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvSachDetail
            // 
            dgvSachDetail.AllowUserToAddRows = false;
            dgvSachDetail.AllowUserToDeleteRows = false;
            dgvSachDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachDetail.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvSachDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSachDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSachDetail.Columns.AddRange(new DataGridViewColumn[] { colMaPhanSach, colMaSach, colTenSach, colTrangThai });
            dgvSachDetail.EnableHeadersVisualStyles = false;
            dgvSachDetail.Location = new Point(12, 45);
            dgvSachDetail.MultiSelect = false;
            dgvSachDetail.Name = "dgvSachDetail";
            dgvSachDetail.ReadOnly = true;
            dgvSachDetail.RowHeadersWidth = 51;
            dgvSachDetail.Size = new Size(775, 319);
            dgvSachDetail.TabIndex = 0;
            // 
            // colMaPhanSach
            // 
            colMaPhanSach.HeaderText = "Mã sách";
            colMaPhanSach.MinimumWidth = 6;
            colMaPhanSach.Name = "colMaPhanSach";
            colMaPhanSach.ReadOnly = true;
            // 
            // colMaSach
            // 
            colMaSach.HeaderText = "Mã đầu sách";
            colMaSach.MinimumWidth = 6;
            colMaSach.Name = "colMaSach";
            colMaSach.ReadOnly = true;
            // 
            // colTenSach
            // 
            colTenSach.HeaderText = "Tên sách";
            colTenSach.MinimumWidth = 6;
            colTenSach.Name = "colTenSach";
            colTenSach.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(75, 385);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(73, 20);
            lblTimKiem.TabIndex = 1;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(164, 382);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(385, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(584, 380);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(114, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(293, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(226, 32);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "DANH SÁCH SÁCH";
            // 
            // DlgSachDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(lblTitle);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(dgvSachDetail);
            Name = "DlgSachDetail";
            Text = "DlgSachDetail";
            ((System.ComponentModel.ISupportInitialize)dgvSachDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private DataGridView dgvSachDetail;
        private DataGridViewTextBoxColumn colMaPhanSach;
        private DataGridViewTextBoxColumn colMaSach;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colTrangThai;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label lblTitle;
    }
}