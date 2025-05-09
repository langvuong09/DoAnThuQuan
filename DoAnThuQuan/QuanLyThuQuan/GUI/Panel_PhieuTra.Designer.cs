namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_PhieuTra
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
            label_titleMaPTra = new Label();
            label_titleMaPhieuMuon = new Label();
            label_MaPhieuTra = new Label();
            textBox_PhieuMuon = new TextBox();
            textBox_NgTra = new TextBox();
            label_titleNgTra = new Label();
            button_PMuon = new Button();
            dataGridView_CTPT = new DataGridView();
            button_TraTBi = new Button();
            dataGridView_DSPT = new DataGridView();
            textBox_TimKiem = new TextBox();
            button_TimKiem = new Button();
            button_ThemPhieu = new Button();
            button_Reload = new Button();
            button_LocTheoNgay = new Button();
            dateTimePicker_NgBatDau = new DateTimePicker();
            dateTimePicker_NgKetThuc = new DateTimePicker();
            label_titleNhanVien = new Label();
            textBox_TenNhanVien = new TextBox();
            textBox_note = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CTPT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSPT).BeginInit();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(528, 11);
            label_title.Name = "label_title";
            label_title.Size = new Size(166, 40);
            label_title.TabIndex = 0;
            label_title.Text = "PHIẾU TRẢ";
            // 
            // label_titleMaPTra
            // 
            label_titleMaPTra.AutoSize = true;
            label_titleMaPTra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleMaPTra.Location = new Point(34, 65);
            label_titleMaPTra.Name = "label_titleMaPTra";
            label_titleMaPTra.Size = new Size(147, 30);
            label_titleMaPTra.TabIndex = 1;
            label_titleMaPTra.Text = "Mã Phiếu Trả:";
            // 
            // label_titleMaPhieuMuon
            // 
            label_titleMaPhieuMuon.AutoSize = true;
            label_titleMaPhieuMuon.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleMaPhieuMuon.Location = new Point(34, 119);
            label_titleMaPhieuMuon.Name = "label_titleMaPhieuMuon";
            label_titleMaPhieuMuon.Size = new Size(178, 30);
            label_titleMaPhieuMuon.TabIndex = 2;
            label_titleMaPhieuMuon.Text = "Mã Phiếu Mượn:";
            // 
            // label_MaPhieuTra
            // 
            label_MaPhieuTra.AutoSize = true;
            label_MaPhieuTra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_MaPhieuTra.ForeColor = Color.IndianRed;
            label_MaPhieuTra.Location = new Point(228, 65);
            label_MaPhieuTra.Name = "label_MaPhieuTra";
            label_MaPhieuTra.Size = new Size(0, 30);
            label_MaPhieuTra.TabIndex = 3;
            label_MaPhieuTra.Click += label_MaPhieuTra_Click;
            // 
            // textBox_PhieuMuon
            // 
            textBox_PhieuMuon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_PhieuMuon.Location = new Point(228, 109);
            textBox_PhieuMuon.Multiline = true;
            textBox_PhieuMuon.Name = "textBox_PhieuMuon";
            textBox_PhieuMuon.Size = new Size(284, 40);
            textBox_PhieuMuon.TabIndex = 4;
            // 
            // textBox_NgTra
            // 
            textBox_NgTra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_NgTra.Location = new Point(228, 175);
            textBox_NgTra.Multiline = true;
            textBox_NgTra.Name = "textBox_NgTra";
            textBox_NgTra.Size = new Size(284, 40);
            textBox_NgTra.TabIndex = 8;
            // 
            // label_titleNgTra
            // 
            label_titleNgTra.AutoSize = true;
            label_titleNgTra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleNgTra.Location = new Point(34, 175);
            label_titleNgTra.Name = "label_titleNgTra";
            label_titleNgTra.Size = new Size(106, 30);
            label_titleNgTra.TabIndex = 10;
            label_titleNgTra.Text = "Ngày Trả:";
            // 
            // button_PMuon
            // 
            button_PMuon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_PMuon.Location = new Point(518, 109);
            button_PMuon.Name = "button_PMuon";
            button_PMuon.Size = new Size(53, 40);
            button_PMuon.TabIndex = 11;
            button_PMuon.Text = "...";
            button_PMuon.UseVisualStyleBackColor = true;
            button_PMuon.Click += button_PMuon_Click;
            // 
            // dataGridView_CTPT
            // 
            dataGridView_CTPT.AllowUserToAddRows = false;
            dataGridView_CTPT.AllowUserToDeleteRows = false;
            dataGridView_CTPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CTPT.Location = new Point(596, 58);
            dataGridView_CTPT.MultiSelect = false;
            dataGridView_CTPT.Name = "dataGridView_CTPT";
            dataGridView_CTPT.ReadOnly = true;
            dataGridView_CTPT.Size = new Size(669, 200);
            dataGridView_CTPT.TabIndex = 12;
            dataGridView_CTPT.CellContentClick += dataGridView_CTPT_CellContentClick;
            // 
            // button_TraTBi
            // 
            button_TraTBi.BackColor = Color.Tomato;
            button_TraTBi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_TraTBi.ForeColor = SystemColors.ButtonHighlight;
            button_TraTBi.Location = new Point(792, 271);
            button_TraTBi.Name = "button_TraTBi";
            button_TraTBi.Size = new Size(144, 35);
            button_TraTBi.TabIndex = 13;
            button_TraTBi.Text = "Trả";
            button_TraTBi.UseVisualStyleBackColor = false;
            // 
            // dataGridView_DSPT
            // 
            dataGridView_DSPT.AllowUserToAddRows = false;
            dataGridView_DSPT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_DSPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DSPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_DSPT.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DSPT.Location = new Point(34, 465);
            dataGridView_DSPT.MultiSelect = false;
            dataGridView_DSPT.Name = "dataGridView_DSPT";
            dataGridView_DSPT.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_DSPT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DSPT.Size = new Size(1231, 279);
            dataGridView_DSPT.TabIndex = 16;
            dataGridView_DSPT.CellClick += dataGridView_DSPT_CellContentClick;
            // 
            // textBox_TimKiem
            // 
            textBox_TimKiem.BorderStyle = BorderStyle.FixedSingle;
            textBox_TimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TimKiem.Location = new Point(528, 312);
            textBox_TimKiem.Multiline = true;
            textBox_TimKiem.Name = "textBox_TimKiem";
            textBox_TimKiem.Size = new Size(577, 40);
            textBox_TimKiem.TabIndex = 17;
            // 
            // button_TimKiem
            // 
            button_TimKiem.BackColor = Color.MediumAquamarine;
            button_TimKiem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_TimKiem.ForeColor = SystemColors.ButtonHighlight;
            button_TimKiem.Location = new Point(1121, 312);
            button_TimKiem.Name = "button_TimKiem";
            button_TimKiem.Size = new Size(144, 40);
            button_TimKiem.TabIndex = 18;
            button_TimKiem.Text = "Tìm";
            button_TimKiem.UseVisualStyleBackColor = false;
            // 
            // button_ThemPhieu
            // 
            button_ThemPhieu.BackColor = Color.MediumAquamarine;
            button_ThemPhieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ThemPhieu.ForeColor = SystemColors.ButtonHighlight;
            button_ThemPhieu.Location = new Point(37, 419);
            button_ThemPhieu.Name = "button_ThemPhieu";
            button_ThemPhieu.Size = new Size(144, 40);
            button_ThemPhieu.TabIndex = 19;
            button_ThemPhieu.Text = "Thêm";
            button_ThemPhieu.UseVisualStyleBackColor = false;
            button_ThemPhieu.Click += button_ThemPhieu_Click;
            // 
            // button_Reload
            // 
            button_Reload.BackColor = Color.Tomato;
            button_Reload.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Reload.ForeColor = SystemColors.ButtonHighlight;
            button_Reload.Location = new Point(204, 421);
            button_Reload.Name = "button_Reload";
            button_Reload.Size = new Size(144, 38);
            button_Reload.TabIndex = 24;
            button_Reload.Text = "Reload";
            button_Reload.UseVisualStyleBackColor = false;
            // 
            // button_LocTheoNgay
            // 
            button_LocTheoNgay.BackColor = Color.MediumAquamarine;
            button_LocTheoNgay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_LocTheoNgay.ForeColor = SystemColors.ButtonHighlight;
            button_LocTheoNgay.Location = new Point(1121, 364);
            button_LocTheoNgay.Name = "button_LocTheoNgay";
            button_LocTheoNgay.Size = new Size(144, 40);
            button_LocTheoNgay.TabIndex = 25;
            button_LocTheoNgay.Text = "Lọc";
            button_LocTheoNgay.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker_NgBatDau
            // 
            dateTimePicker_NgBatDau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_NgBatDau.Location = new Point(528, 369);
            dateTimePicker_NgBatDau.Name = "dateTimePicker_NgBatDau";
            dateTimePicker_NgBatDau.Size = new Size(259, 29);
            dateTimePicker_NgBatDau.TabIndex = 26;
            // 
            // dateTimePicker_NgKetThuc
            // 
            dateTimePicker_NgKetThuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_NgKetThuc.Location = new Point(846, 369);
            dateTimePicker_NgKetThuc.Name = "dateTimePicker_NgKetThuc";
            dateTimePicker_NgKetThuc.Size = new Size(259, 29);
            dateTimePicker_NgKetThuc.TabIndex = 27;
            // 
            // label_titleNhanVien
            // 
            label_titleNhanVien.AutoSize = true;
            label_titleNhanVien.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleNhanVien.Location = new Point(34, 242);
            label_titleNhanVien.Name = "label_titleNhanVien";
            label_titleNhanVien.Size = new Size(117, 30);
            label_titleNhanVien.TabIndex = 28;
            label_titleNhanVien.Text = "Nhân Viên";
            label_titleNhanVien.Click += label_titleNhanVien_Click;
            // 
            // textBox_TenNhanVien
            // 
            textBox_TenNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TenNhanVien.Location = new Point(228, 232);
            textBox_TenNhanVien.Multiline = true;
            textBox_TenNhanVien.Name = "textBox_TenNhanVien";
            textBox_TenNhanVien.Size = new Size(284, 40);
            textBox_TenNhanVien.TabIndex = 29;
            // 
            // textBox_note
            // 
            textBox_note.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_note.Location = new Point(37, 278);
            textBox_note.Multiline = true;
            textBox_note.Name = "textBox_note";
            textBox_note.Size = new Size(475, 137);
            textBox_note.TabIndex = 30;
            // 
            // Panel_PhieuTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(textBox_note);
            Controls.Add(textBox_TenNhanVien);
            Controls.Add(label_titleNhanVien);
            Controls.Add(dateTimePicker_NgKetThuc);
            Controls.Add(dateTimePicker_NgBatDau);
            Controls.Add(button_LocTheoNgay);
            Controls.Add(button_Reload);
            Controls.Add(button_ThemPhieu);
            Controls.Add(button_TimKiem);
            Controls.Add(textBox_TimKiem);
            Controls.Add(dataGridView_DSPT);
            Controls.Add(button_TraTBi);
            Controls.Add(dataGridView_CTPT);
            Controls.Add(button_PMuon);
            Controls.Add(label_titleNgTra);
            Controls.Add(textBox_NgTra);
            Controls.Add(textBox_PhieuMuon);
            Controls.Add(label_MaPhieuTra);
            Controls.Add(label_titleMaPhieuMuon);
            Controls.Add(label_titleMaPTra);
            Controls.Add(label_title);
            Name = "Panel_PhieuTra";
            Size = new Size(1290, 760);
            Load += Panel_PhieuTra_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_CTPT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSPT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label_titleMaPTra;
        private Label label_titleMaPhieuMuon;
        private Label label_MaPhieuTra;
        private TextBox textBox_PhieuMuon;
        private TextBox textBox_NgTra;
        private Label label_titleNgTra;
        private Button button_PMuon;
        private DataGridView dataGridView_CTPT;
        private Button button_TraTBi;
        private DataGridView dataGridView_DSPT;
        private TextBox textBox_TimKiem;
        private Button button_TimKiem;
        private Button button_ThemPhieu;
        private Button button_Reload;
        private Button button_LocTheoNgay;
        private DateTimePicker dateTimePicker_NgBatDau;
        private DateTimePicker dateTimePicker_NgKetThuc;
        private Label label_titleNhanVien;
        private TextBox textBox_TenNhanVien;
        private TextBox textBox_note;
    }
}
