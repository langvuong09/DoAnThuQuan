namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_CheckInOut
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
            dataGridView_Checkinout = new DataGridView();
            label_titleMaDocGia = new Label();
            textBox_IDDOGIA = new TextBox();
            button_checkIn = new Button();
            panel1 = new Panel();
            textBox_TimeCheckIn = new TextBox();
            textBox_MaDG = new TextBox();
            label_titleCheckIn = new Label();
            label_titleDocGia = new Label();
            label_titleCTCheckInOut = new Label();
            button_Loc = new Button();
            dateTimePicker_Loc = new DateTimePicker();
            button_Reload = new Button();
            textBox_TenDG = new TextBox();
            label_titleTenDG = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Checkinout).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_Checkinout
            // 
            dataGridView_Checkinout.AllowUserToAddRows = false;
            dataGridView_Checkinout.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_Checkinout.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Checkinout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_Checkinout.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Checkinout.Location = new Point(10, 7);
            dataGridView_Checkinout.MultiSelect = false;
            dataGridView_Checkinout.Name = "dataGridView_Checkinout";
            dataGridView_Checkinout.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MediumAquamarine;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_Checkinout.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_Checkinout.Size = new Size(642, 683);
            dataGridView_Checkinout.TabIndex = 0;
            dataGridView_Checkinout.CellContentClick += dataGridView_Checkinout_CellContentClick;
            // 
            // label_titleMaDocGia
            // 
            label_titleMaDocGia.AutoSize = true;
            label_titleMaDocGia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleMaDocGia.Location = new Point(673, 110);
            label_titleMaDocGia.Name = "label_titleMaDocGia";
            label_titleMaDocGia.Size = new Size(132, 30);
            label_titleMaDocGia.TabIndex = 1;
            label_titleMaDocGia.Text = "Mã Độc Giả:";
            // 
            // textBox_IDDOGIA
            // 
            textBox_IDDOGIA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_IDDOGIA.Location = new Point(811, 97);
            textBox_IDDOGIA.Multiline = true;
            textBox_IDDOGIA.Name = "textBox_IDDOGIA";
            textBox_IDDOGIA.Size = new Size(457, 43);
            textBox_IDDOGIA.TabIndex = 2;
            // 
            // button_checkIn
            // 
            button_checkIn.BackColor = Color.MediumAquamarine;
            button_checkIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_checkIn.ForeColor = SystemColors.ButtonHighlight;
            button_checkIn.Location = new Point(887, 146);
            button_checkIn.Name = "button_checkIn";
            button_checkIn.Size = new Size(175, 44);
            button_checkIn.TabIndex = 3;
            button_checkIn.Text = "Check In";
            button_checkIn.UseVisualStyleBackColor = false;
            button_checkIn.Click += button_checkIn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label_titleTenDG);
            panel1.Controls.Add(textBox_TenDG);
            panel1.Controls.Add(textBox_TimeCheckIn);
            panel1.Controls.Add(textBox_MaDG);
            panel1.Controls.Add(label_titleCheckIn);
            panel1.Controls.Add(label_titleDocGia);
            panel1.Controls.Add(label_titleCTCheckInOut);
            panel1.Location = new Point(673, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 237);
            panel1.TabIndex = 7;
            // 
            // textBox_TimeCheckIn
            // 
            textBox_TimeCheckIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TimeCheckIn.Location = new Point(166, 164);
            textBox_TimeCheckIn.Multiline = true;
            textBox_TimeCheckIn.Name = "textBox_TimeCheckIn";
            textBox_TimeCheckIn.Size = new Size(416, 43);
            textBox_TimeCheckIn.TabIndex = 8;
            // 
            // textBox_MaDG
            // 
            textBox_MaDG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_MaDG.Location = new Point(166, 43);
            textBox_MaDG.Multiline = true;
            textBox_MaDG.Name = "textBox_MaDG";
            textBox_MaDG.Size = new Size(416, 43);
            textBox_MaDG.TabIndex = 6;
            // 
            // label_titleCheckIn
            // 
            label_titleCheckIn.AutoSize = true;
            label_titleCheckIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleCheckIn.Location = new Point(11, 177);
            label_titleCheckIn.Name = "label_titleCheckIn";
            label_titleCheckIn.Size = new Size(104, 30);
            label_titleCheckIn.TabIndex = 4;
            label_titleCheckIn.Text = "Check In:";
            // 
            // label_titleDocGia
            // 
            label_titleDocGia.AutoSize = true;
            label_titleDocGia.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleDocGia.Location = new Point(11, 56);
            label_titleDocGia.Name = "label_titleDocGia";
            label_titleDocGia.Size = new Size(132, 30);
            label_titleDocGia.TabIndex = 2;
            label_titleDocGia.Text = "Mã Độc Giả:";
            // 
            // label_titleCTCheckInOut
            // 
            label_titleCTCheckInOut.AutoSize = true;
            label_titleCTCheckInOut.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleCTCheckInOut.Location = new Point(235, 0);
            label_titleCTCheckInOut.Name = "label_titleCTCheckInOut";
            label_titleCTCheckInOut.Size = new Size(132, 40);
            label_titleCTCheckInOut.TabIndex = 0;
            label_titleCTCheckInOut.Text = "CHI TIẾT";
            // 
            // button_Loc
            // 
            button_Loc.BackColor = Color.MediumAquamarine;
            button_Loc.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Loc.ForeColor = SystemColors.ButtonHighlight;
            button_Loc.Location = new Point(1093, 223);
            button_Loc.Name = "button_Loc";
            button_Loc.Size = new Size(175, 44);
            button_Loc.TabIndex = 6;
            button_Loc.Text = "Lọc";
            button_Loc.UseVisualStyleBackColor = false;
            button_Loc.Click += button_Loc_Click;
            // 
            // dateTimePicker_Loc
            // 
            dateTimePicker_Loc.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker_Loc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_Loc.Location = new Point(673, 228);
            dateTimePicker_Loc.Name = "dateTimePicker_Loc";
            dateTimePicker_Loc.Size = new Size(414, 33);
            dateTimePicker_Loc.TabIndex = 5;
            dateTimePicker_Loc.ValueChanged += dateTimePicker_Loc_ValueChanged;
            // 
            // button_Reload
            // 
            button_Reload.BackColor = Color.LightPink;
            button_Reload.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Reload.ForeColor = SystemColors.ButtonHighlight;
            button_Reload.Location = new Point(673, 7);
            button_Reload.Name = "button_Reload";
            button_Reload.Size = new Size(175, 44);
            button_Reload.TabIndex = 8;
            button_Reload.Text = "Reload";
            button_Reload.UseVisualStyleBackColor = false;
            button_Reload.Click += button_Reload_Click;
            // 
            // textBox_TenDG
            // 
            textBox_TenDG.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TenDG.Location = new Point(166, 104);
            textBox_TenDG.Multiline = true;
            textBox_TenDG.Name = "textBox_TenDG";
            textBox_TenDG.Size = new Size(416, 43);
            textBox_TenDG.TabIndex = 9;
            // 
            // label_titleTenDG
            // 
            label_titleTenDG.AutoSize = true;
            label_titleTenDG.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titleTenDG.Location = new Point(11, 117);
            label_titleTenDG.Name = "label_titleTenDG";
            label_titleTenDG.Size = new Size(104, 30);
            label_titleTenDG.TabIndex = 10;
            label_titleTenDG.Text = "Check In:";
            // 
            // Panel_CheckInOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(button_Reload);
            Controls.Add(panel1);
            Controls.Add(button_Loc);
            Controls.Add(dateTimePicker_Loc);
            Controls.Add(button_checkIn);
            Controls.Add(textBox_IDDOGIA);
            Controls.Add(label_titleMaDocGia);
            Controls.Add(dataGridView_Checkinout);
            Name = "Panel_CheckInOut";
            Size = new Size(1290, 700);
            Load += Panel_CheckInOut_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Checkinout).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Checkinout;
        private Label label_titleMaDocGia;
        private TextBox textBox_IDDOGIA;
        private Button button_checkIn;
        private Panel panel1;
        private Label label_titleCheckIn;
        private Label label_titleDocGia;
        private Label label_titleCTCheckInOut;
        private TextBox textBox_TimeCheckIn;
        private TextBox textBox_MaDG;
        private Button button_Loc;
        private DateTimePicker dateTimePicker_Loc;
        private Button button_Reload;
        private Label label_titleTenDG;
        private TextBox textBox_TenDG;
    }
}
