namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Component_NhapMTinhMoi
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
            label_title = new Label();
            dataGridView_DSMT = new DataGridView();
            label_titleTable = new Label();
            label_tileMaMTinh = new Label();
            label_titleTenMT = new Label();
            textBox_MaMT = new TextBox();
            textBox_TenMT = new TextBox();
            button_Nhap = new Button();
            button_Them = new Button();
            button_Xoa = new Button();
            button_Sua = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSMT).BeginInit();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(673, 14);
            label_title.Name = "label_title";
            label_title.Size = new Size(210, 25);
            label_title.TabIndex = 0;
            label_title.Text = "NHẬP MÁY TÍNH MỚI";
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
            dataGridView_DSMT.Location = new Point(19, 57);
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
            dataGridView_DSMT.TabIndex = 41;
            // 
            // label_titleTable
            // 
            label_titleTable.AutoSize = true;
            label_titleTable.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleTable.Location = new Point(19, 14);
            label_titleTable.Name = "label_titleTable";
            label_titleTable.Size = new Size(462, 25);
            label_titleTable.TabIndex = 42;
            label_titleTable.Text = "DANH SÁCH CÁC MÁY TÍNH SẼ ĐƯỢC NHẬP VÀO ";
            // 
            // label_tileMaMTinh
            // 
            label_tileMaMTinh.AutoSize = true;
            label_tileMaMTinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tileMaMTinh.Location = new Point(518, 57);
            label_tileMaMTinh.Name = "label_tileMaMTinh";
            label_tileMaMTinh.Size = new Size(132, 25);
            label_tileMaMTinh.TabIndex = 43;
            label_tileMaMTinh.Text = "Mã Máy Tính:";
            // 
            // label_titleTenMT
            // 
            label_titleTenMT.AutoSize = true;
            label_titleTenMT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleTenMT.Location = new Point(518, 112);
            label_titleTenMT.Name = "label_titleTenMT";
            label_titleTenMT.Size = new Size(135, 25);
            label_titleTenMT.TabIndex = 44;
            label_titleTenMT.Text = "Tên Máy Tính:";
            // 
            // textBox_MaMT
            // 
            textBox_MaMT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_MaMT.Location = new Point(653, 53);
            textBox_MaMT.Multiline = true;
            textBox_MaMT.Name = "textBox_MaMT";
            textBox_MaMT.Size = new Size(313, 36);
            textBox_MaMT.TabIndex = 45;
            // 
            // textBox_TenMT
            // 
            textBox_TenMT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TenMT.Location = new Point(653, 101);
            textBox_TenMT.Multiline = true;
            textBox_TenMT.Name = "textBox_TenMT";
            textBox_TenMT.Size = new Size(313, 36);
            textBox_TenMT.TabIndex = 46;
            // 
            // button_Nhap
            // 
            button_Nhap.BackColor = Color.Tomato;
            button_Nhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Nhap.ForeColor = SystemColors.ButtonFace;
            button_Nhap.Location = new Point(161, 366);
            button_Nhap.Name = "button_Nhap";
            button_Nhap.Size = new Size(221, 48);
            button_Nhap.TabIndex = 47;
            button_Nhap.Text = "NHẬP LÔ MÁY TÍNH ";
            button_Nhap.UseVisualStyleBackColor = false;
            // 
            // button_Them
            // 
            button_Them.BackColor = Color.Tomato;
            button_Them.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Them.ForeColor = SystemColors.ButtonFace;
            button_Them.Location = new Point(557, 157);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(132, 48);
            button_Them.TabIndex = 48;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = false;
            // 
            // button_Xoa
            // 
            button_Xoa.BackColor = Color.Tomato;
            button_Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Xoa.ForeColor = SystemColors.ButtonFace;
            button_Xoa.Location = new Point(695, 157);
            button_Xoa.Name = "button_Xoa";
            button_Xoa.Size = new Size(132, 48);
            button_Xoa.TabIndex = 49;
            button_Xoa.Text = "Xóa";
            button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Sua
            // 
            button_Sua.BackColor = Color.Tomato;
            button_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Sua.ForeColor = SystemColors.ButtonFace;
            button_Sua.Location = new Point(833, 157);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(132, 48);
            button_Sua.TabIndex = 50;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = false;
            // 
            // Component_NhapMTinhMoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Sua);
            Controls.Add(button_Xoa);
            Controls.Add(button_Them);
            Controls.Add(button_Nhap);
            Controls.Add(textBox_TenMT);
            Controls.Add(textBox_MaMT);
            Controls.Add(label_titleTenMT);
            Controls.Add(label_tileMaMTinh);
            Controls.Add(label_titleTable);
            Controls.Add(dataGridView_DSMT);
            Controls.Add(label_title);
            Name = "Component_NhapMTinhMoi";
            Size = new Size(1000, 430);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSMT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private DataGridView dataGridView_DSMT;
        private Label label_titleTable;
        private Label label_tileMaMTinh;
        private Label label_titleTenMT;
        private TextBox textBox_MaMT;
        private TextBox textBox_TenMT;
        private Button button_Nhap;
        private Button button_Them;
        private Button button_Xoa;
        private Button button_Sua;
    }
}
