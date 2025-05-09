namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Component_PhieuMuon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            label_title = new Label();
            dataGridView_DSPMuon = new DataGridView();
            button_Chon = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridView_DSPMuon).BeginInit();
            SuspendLayout();

            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.Location = new Point(318, 10);
            label_title.Name = "label_title";
            label_title.Size = new Size(363, 32);
            label_title.TabIndex = 0;
            label_title.Text = "DANH SÁCH CÁC PHIẾU MƯỢN";

            // 
            // dataGridView_DSPMuon
            // 
            dataGridView_DSPMuon.AllowUserToAddRows = false;
            dataGridView_DSPMuon.AllowUserToDeleteRows = false;
            dataGridView_DSPMuon.ColumnHeadersDefaultCellStyle = CreateHeaderStyle();
            dataGridView_DSPMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DSPMuon.DefaultCellStyle = CreateDefaultCellStyle();
            dataGridView_DSPMuon.RowHeadersDefaultCellStyle = CreateHeaderStyle();
            dataGridView_DSPMuon.Location = new Point(28, 45);
            dataGridView_DSPMuon.MultiSelect = false;
            dataGridView_DSPMuon.Name = "dataGridView_DSPMuon";
            dataGridView_DSPMuon.ReadOnly = true;
            dataGridView_DSPMuon.Size = new Size(946, 342);
            dataGridView_DSPMuon.TabIndex = 1;

            // 
            // button_Chon
            // 
            button_Chon.BackColor = Color.MediumAquamarine;
            button_Chon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Chon.ForeColor = SystemColors.ButtonFace;
            button_Chon.Location = new Point(385, 403);
            button_Chon.Name = "button_Chon";
            button_Chon.Size = new Size(235, 42);
            button_Chon.TabIndex = 2;
            button_Chon.Text = "CHỌN";
            button_Chon.UseVisualStyleBackColor = false;

            // 
            // Component_PhieuMuon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Chon);
            Controls.Add(dataGridView_DSPMuon);
            Controls.Add(label_title);
            Name = "Component_PhieuMuon";
            Size = new Size(1000, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView_DSPMuon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewCellStyle CreateHeaderStyle()
        {
            return new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.MediumAquamarine,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.GradientActiveCaption,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.True
            };
        }

        private DataGridViewCellStyle CreateDefaultCellStyle()
        {
            return new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = SystemColors.ControlText,
                SelectionBackColor = SystemColors.GradientActiveCaption,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.False
            };
        }

        #endregion

        private Label label_title;
        private DataGridView dataGridView_DSPMuon;
        private Button button_Chon;
    }
}
