namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Component_PhieuTra
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
            button_Chon = new Button();
            dataGridView_DSPTra = new DataGridView();
            label_title = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSPTra).BeginInit();
            SuspendLayout();
            // 
            // button_Chon
            // 
            button_Chon.BackColor = Color.MediumAquamarine;
            button_Chon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Chon.ForeColor = SystemColors.ButtonFace;
            button_Chon.Location = new Point(383, 403);
            button_Chon.Name = "button_Chon";
            button_Chon.Size = new Size(235, 42);
            button_Chon.TabIndex = 5;
            button_Chon.Text = "CHỌN";
            button_Chon.UseVisualStyleBackColor = false;
            button_Chon.Click += button_Chon_Click;
            // 
            // dataGridView_DSPTra
            // 
            dataGridView_DSPTra.AllowUserToAddRows = false;
            dataGridView_DSPTra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_DSPTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_DSPTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_DSPTra.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_DSPTra.Location = new Point(26, 45);
            dataGridView_DSPTra.MultiSelect = false;
            dataGridView_DSPTra.Name = "dataGridView_DSPTra";
            dataGridView_DSPTra.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_DSPTra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_DSPTra.Size = new Size(946, 342);
            dataGridView_DSPTra.TabIndex = 4;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(314, 0);
            label_title.Name = "label_title";
            label_title.Size = new Size(331, 32);
            label_title.TabIndex = 3;
            label_title.Text = "DANH SÁCH CÁC PHIẾU TRẢ";
            // 
            // Component_PhieuTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Chon);
            Controls.Add(dataGridView_DSPTra);
            Controls.Add(label_title);
            Name = "Component_PhieuTra";
            Size = new Size(1000, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSPTra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Chon;
        private DataGridView dataGridView_DSPTra;
        private Label label_title;
    }
}
