namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Component_Ke
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
            button_Chon = new Button();
            dataGridView_DSKe = new DataGridView();
            label_title = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSKe).BeginInit();
            SuspendLayout();
            // 
            // button_Chon
            // 
            button_Chon.BackColor = Color.MediumAquamarine;
            button_Chon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Chon.ForeColor = SystemColors.ButtonFace;
            button_Chon.Location = new Point(384, 426);
            button_Chon.Name = "button_Chon";
            button_Chon.Size = new Size(235, 42);
            button_Chon.TabIndex = 8;
            button_Chon.Text = "CHỌN";
            button_Chon.UseVisualStyleBackColor = false;
            // 
            // dataGridView_DSKe
            // 
            dataGridView_DSKe.AllowUserToAddRows = false;
            dataGridView_DSKe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_DSKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DSKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_DSKe.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DSKe.Location = new Point(27, 68);
            dataGridView_DSKe.MultiSelect = false;
            dataGridView_DSKe.Name = "dataGridView_DSKe";
            dataGridView_DSKe.ReadOnly = true;
            dataGridView_DSKe.Size = new Size(946, 342);
            dataGridView_DSKe.TabIndex = 7;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(315, 23);
            label_title.Name = "label_title";
            label_title.Size = new Size(239, 32);
            label_title.TabIndex = 6;
            label_title.Text = "DANH SÁCH CÁC KỆ";
            // 
            // Component_Ke
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Chon);
            Controls.Add(dataGridView_DSKe);
            Controls.Add(label_title);
            Name = "Component_Ke";
            Size = new Size(1000, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Chon;
        private DataGridView dataGridView_DSKe;
        private Label label_title;
    }
}
