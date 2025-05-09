namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Component_PhanSach
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
            dataGridView_DSPSach = new DataGridView();
            label_title = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSPSach).BeginInit();
            SuspendLayout();
            // 
            // button_Chon
            // 
            button_Chon.BackColor = Color.MediumAquamarine;
            button_Chon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Chon.ForeColor = SystemColors.ButtonFace;
            button_Chon.Location = new Point(384, 412);
            button_Chon.Name = "button_Chon";
            button_Chon.Size = new Size(235, 42);
            button_Chon.TabIndex = 8;
            button_Chon.Text = "CHỌN";
            button_Chon.UseVisualStyleBackColor = false;
            // 
            // dataGridView_DSPSach
            // 
            dataGridView_DSPSach.AllowUserToAddRows = false;
            dataGridView_DSPSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_DSPSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DSPSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_DSPSach.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DSPSach.Location = new Point(27, 54);
            dataGridView_DSPSach.MultiSelect = false;
            dataGridView_DSPSach.Name = "dataGridView_DSPSach";
            dataGridView_DSPSach.ReadOnly = true;
            dataGridView_DSPSach.Size = new Size(946, 342);
            dataGridView_DSPSach.TabIndex = 7;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(315, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(347, 32);
            label_title.TabIndex = 6;
            label_title.Text = "DANH SÁCH CÁC PHÂN SÁCH";
            // 
            // Component_PhanSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Chon);
            Controls.Add(dataGridView_DSPSach);
            Controls.Add(label_title);
            Name = "Component_PhanSach";
            Size = new Size(1000, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSPSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Chon;
        private DataGridView dataGridView_DSPSach;
        private Label label_title;
    }
}
