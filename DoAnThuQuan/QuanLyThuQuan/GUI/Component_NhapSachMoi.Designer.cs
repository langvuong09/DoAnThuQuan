namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Component_NhapSachMoi
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label_title = new Label();
            dataGridView_DSSach = new DataGridView();
            dataGridView_PSachCuaSach = new DataGridView();
            label_titleDSSach = new Label();
            label_titleDSPSach = new Label();
            label_titleMaSach = new Label();
            button_Giam = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label_titleTenSach = new Label();
            label_titleSoLg = new Label();
            textBox_SoLg = new TextBox();
            button_Tang = new Button();
            button_NhapHang = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PSachCuaSach).BeginInit();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(355, 8);
            label_title.Name = "label_title";
            label_title.Size = new Size(136, 30);
            label_title.TabIndex = 0;
            label_title.Text = "NHẬP SÁCH";
            // 
            // dataGridView_DSSach
            // 
            dataGridView_DSSach.AllowUserToAddRows = false;
            dataGridView_DSSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_DSSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DSSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DSSach.Location = new Point(21, 73);
            dataGridView_DSSach.MultiSelect = false;
            dataGridView_DSSach.Name = "dataGridView_DSSach";
            dataGridView_DSSach.ReadOnly = true;
            dataGridView_DSSach.Size = new Size(385, 167);
            dataGridView_DSSach.TabIndex = 8;
            // 
            // dataGridView_PSachCuaSach
            // 
            dataGridView_PSachCuaSach.AllowUserToAddRows = false;
            dataGridView_PSachCuaSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView_PSachCuaSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_PSachCuaSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_PSachCuaSach.Location = new Point(21, 276);
            dataGridView_PSachCuaSach.MultiSelect = false;
            dataGridView_PSachCuaSach.Name = "dataGridView_PSachCuaSach";
            dataGridView_PSachCuaSach.ReadOnly = true;
            dataGridView_PSachCuaSach.Size = new Size(710, 130);
            dataGridView_PSachCuaSach.TabIndex = 9;
            // 
            // label_titleDSSach
            // 
            label_titleDSSach.AutoSize = true;
            label_titleDSSach.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleDSSach.Location = new Point(21, 36);
            label_titleDSSach.Name = "label_titleDSSach";
            label_titleDSSach.Size = new Size(176, 25);
            label_titleDSSach.TabIndex = 10;
            label_titleDSSach.Text = "DANH SÁCH SÁCH";
            // 
            // label_titleDSPSach
            // 
            label_titleDSPSach.AutoSize = true;
            label_titleDSPSach.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleDSPSach.Location = new Point(21, 243);
            label_titleDSPSach.Name = "label_titleDSPSach";
            label_titleDSPSach.Size = new Size(523, 25);
            label_titleDSPSach.TabIndex = 11;
            label_titleDSPSach.Text = "DANH SÁCH PHÂN SÁCH SẼ ĐƯỢC NHẬP VÀO THƯ QUÁN";
            // 
            // label_titleMaSach
            // 
            label_titleMaSach.AutoSize = true;
            label_titleMaSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleMaSach.Location = new Point(411, 67);
            label_titleMaSach.Name = "label_titleMaSach";
            label_titleMaSach.Size = new Size(90, 21);
            label_titleMaSach.TabIndex = 12;
            label_titleMaSach.Text = "MÃ SÁCH :";
            // 
            // button_Giam
            // 
            button_Giam.BackColor = SystemColors.ActiveCaption;
            button_Giam.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Giam.Location = new Point(590, 138);
            button_Giam.Name = "button_Giam";
            button_Giam.Size = new Size(52, 42);
            button_Giam.TabIndex = 13;
            button_Giam.Text = "-";
            button_Giam.UseVisualStyleBackColor = false;
            // 
            // txtDiaChi
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(507, 55);
            textBox1.Multiline = true;
            textBox1.Name = "txtDiaChi";
            textBox1.Size = new Size(335, 33);
            textBox1.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(507, 99);
            textBox3.Multiline = true;
            textBox3.Name = "txtSoLuong";
            textBox3.Size = new Size(335, 33);
            textBox3.TabIndex = 19;
            // 
            // label_titleTenSach
            // 
            label_titleTenSach.AutoSize = true;
            label_titleTenSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleTenSach.Location = new Point(411, 111);
            label_titleTenSach.Name = "label_titleTenSach";
            label_titleTenSach.Size = new Size(95, 21);
            label_titleTenSach.TabIndex = 20;
            label_titleTenSach.Text = "TÊN SÁCH :";
            // 
            // label_titleSoLg
            // 
            label_titleSoLg.AutoSize = true;
            label_titleSoLg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleSoLg.Location = new Point(410, 152);
            label_titleSoLg.Name = "label_titleSoLg";
            label_titleSoLg.Size = new Size(96, 21);
            label_titleSoLg.TabIndex = 21;
            label_titleSoLg.Text = "SỐ LƯỢNG:";
            // 
            // textBox_SoLg
            // 
            textBox_SoLg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_SoLg.Location = new Point(661, 138);
            textBox_SoLg.Multiline = true;
            textBox_SoLg.Name = "textBox_SoLg";
            textBox_SoLg.Size = new Size(53, 44);
            textBox_SoLg.TabIndex = 22;
            // 
            // button_Tang
            // 
            button_Tang.BackColor = SystemColors.ActiveCaption;
            button_Tang.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Tang.Location = new Point(737, 140);
            button_Tang.Name = "button_Tang";
            button_Tang.Size = new Size(52, 42);
            button_Tang.TabIndex = 23;
            button_Tang.Text = "+";
            button_Tang.UseVisualStyleBackColor = false;
            // 
            // button_NhapHang
            // 
            button_NhapHang.BackColor = Color.Coral;
            button_NhapHang.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_NhapHang.Location = new Point(507, 196);
            button_NhapHang.Name = "button_NhapHang";
            button_NhapHang.Size = new Size(334, 44);
            button_NhapHang.TabIndex = 15;
            button_NhapHang.Text = "NHẬP SÁCH";
            button_NhapHang.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(737, 362);
            button1.Name = "btnTimKiem";
            button1.Size = new Size(105, 44);
            button1.TabIndex = 24;
            button1.Text = "NHẬP ";
            button1.UseVisualStyleBackColor = false;
            // 
            // Component_NhapSachMoi
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(button_Tang);
            Controls.Add(textBox_SoLg);
            Controls.Add(label_titleSoLg);
            Controls.Add(label_titleTenSach);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button_NhapHang);
            Controls.Add(button_Giam);
            Controls.Add(label_titleMaSach);
            Controls.Add(label_titleDSPSach);
            Controls.Add(label_titleDSSach);
            Controls.Add(dataGridView_PSachCuaSach);
            Controls.Add(dataGridView_DSSach);
            Controls.Add(label_title);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Component_NhapSachMoi";
            Size = new Size(857, 425);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PSachCuaSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private DataGridView dataGridView_DSSach;
        private DataGridView dataGridView_PSachCuaSach;
        private Label label_titleDSSach;
        private Label label_titleDSPSach;
        private Label label_titleMaSach;
        private Button button_Giam;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label_titleTenSach;
        private Label label_titleSoLg;
        private TextBox textBox_SoLg;
        private Button button_Tang;
        private Button button_NhapHang;
        private Button button1;
    }
}
