namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Component_NhapMChieuMoi
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            button_Sua = new Button();
            button_Xoa = new Button();
            button_Them = new Button();
            button_Nhap = new Button();
            textBox_TenMC = new TextBox();
            textBox_MaMC = new TextBox();
            label_titleMChieu = new Label();
            label_tileMaMChieu = new Label();
            label_titleTable = new Label();
            dataGridView_DSMT = new DataGridView();
            label_title = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSMT).BeginInit();
            SuspendLayout();
            // 
            // button_Sua
            // 
            button_Sua.BackColor = Color.Tomato;
            button_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Sua.ForeColor = SystemColors.ButtonFace;
            button_Sua.Location = new Point(841, 158);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(132, 48);
            button_Sua.TabIndex = 61;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = false;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = Color.Tomato;
            button_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Xoa.ForeColor = SystemColors.ButtonFace;
            button_Xoa.Location = new Point(703, 158);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(132, 48);
            button_Xoa.TabIndex = 60;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Them
            // 
            button_Them.BackColor = Color.Tomato;
            button_Them.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Them.ForeColor = SystemColors.ButtonFace;
            button_Them.Location = new Point(565, 158);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(132, 48);
            button_Them.TabIndex = 59;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = false;
            // 
            // button_Nhap
            // 
            button_Nhap.BackColor = Color.Tomato;
            button_Nhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Nhap.ForeColor = SystemColors.ButtonFace;
            button_Nhap.Location = new Point(169, 367);
            button_Nhap.Name = "button_Nhap";
            button_Nhap.Size = new Size(221, 48);
            button_Nhap.TabIndex = 58;
            button_Nhap.Text = "NHẬP LÔ MÁY CHIẾU";
            button_Nhap.UseVisualStyleBackColor = false;
            // 
            // textBox_TenMC
            // 
            textBox_TenMC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TenMC.Location = new Point(673, 102);
            textBox_TenMC.Multiline = true;
            textBox_TenMC.Name = "textBox_TenMC";
            textBox_TenMC.Size = new Size(301, 36);
            textBox_TenMC.TabIndex = 57;
            // 
            // textBox_MaMC
            // 
            textBox_MaMC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_MaMC.Location = new Point(673, 47);
            textBox_MaMC.Multiline = true;
            textBox_MaMC.Name = "textBox_MaMC";
            textBox_MaMC.Size = new Size(301, 36);
            textBox_MaMC.TabIndex = 56;
            // 
            // label_titleMChieu
            // 
            label_titleMChieu.AutoSize = true;
            label_titleMChieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleMChieu.Location = new Point(526, 113);
            label_titleMChieu.Name = "label_titleMChieu";
            label_titleMChieu.Size = new Size(146, 25);
            label_titleMChieu.TabIndex = 55;
            label_titleMChieu.Text = "Tên Máy Chiếu:";
            // 
            // label_tileMaMChieu
            // 
            label_tileMaMChieu.AutoSize = true;
            label_tileMaMChieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tileMaMChieu.Location = new Point(526, 58);
            label_tileMaMChieu.Name = "label_tileMaMChieu";
            label_tileMaMChieu.Size = new Size(143, 25);
            label_tileMaMChieu.TabIndex = 54;
            label_tileMaMChieu.Text = "Mã Máy Chiếu:";
            // 
            // label_titleTable
            // 
            label_titleTable.AutoSize = true;
            label_titleTable.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleTable.Location = new Point(27, 15);
            label_titleTable.Name = "label_titleTable";
            label_titleTable.Size = new Size(472, 25);
            label_titleTable.TabIndex = 53;
            label_titleTable.Text = "DANH SÁCH CÁC MÁY CHIẾU SẼ ĐƯỢC NHẬP VÀO ";
            // 
            // dataGridView_DSMT
            // 
            dataGridView_DSMT.AllowUserToAddRows = false;
            dataGridView_DSMT.AllowUserToDeleteRows = false;
            dataGridView_DSMT.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView_DSMT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_DSMT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView_DSMT.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_DSMT.Location = new Point(27, 58);
            dataGridView_DSMT.MultiSelect = false;
            dataGridView_DSMT.Name = "dataGridView_DSMT";
            dataGridView_DSMT.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView_DSMT.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView_DSMT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_DSMT.Size = new Size(493, 303);
            dataGridView_DSMT.TabIndex = 52;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(681, 15);
            label_title.Name = "label_title";
            label_title.Size = new Size(220, 25);
            label_title.TabIndex = 51;
            label_title.Text = "NHẬP MÁY CHIẾU MỚI";
            // 
            // Component_NhapMChieuMoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Sua);
            Controls.Add(button_Xoa);
            Controls.Add(button_Them);
            Controls.Add(button_Nhap);
            Controls.Add(textBox_TenMC);
            Controls.Add(textBox_MaMC);
            Controls.Add(label_titleMChieu);
            Controls.Add(label_tileMaMChieu);
            Controls.Add(label_titleTable);
            Controls.Add(dataGridView_DSMT);
            Controls.Add(label_title);
            Name = "Component_NhapMChieuMoi";
            Size = new Size(1000, 430);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSMT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Sua;
        private Button button_Xoa;
        private Button button_Them;
        private Button button_Nhap;
        private TextBox textBox_TenMC;
        private TextBox textBox_MaMC;
        private Label label_titleMChieu;
        private Label label_tileMaMChieu;
        private Label label_titleTable;
        private DataGridView dataGridView_DSMT;
        private Label label_title;
    }
}
