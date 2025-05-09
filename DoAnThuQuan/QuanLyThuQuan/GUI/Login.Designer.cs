namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            picture_left = new PictureBox();
            label_title = new Label();
            pictureBox1 = new PictureBox();
            picture_iconUser = new PictureBox();
            txt_User = new TextBox();
            txt_Pass = new TextBox();
            picture_iconPass = new PictureBox();
            ckbCheck = new CheckBox();
            btn_Login = new Button();
            ((System.ComponentModel.ISupportInitialize)picture_left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_iconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_iconPass).BeginInit();
            SuspendLayout();
            // 
            // picture_left
            // 
            picture_left.Image = (Image)resources.GetObject("picture_left.Image");
            picture_left.Location = new Point(0, 0);
            picture_left.Name = "picture_left";
            picture_left.Size = new Size(538, 662);
            picture_left.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_left.TabIndex = 0;
            picture_left.TabStop = false;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.ForeColor = SystemColors.MenuBar;
            label_title.Location = new Point(553, 45);
            label_title.Name = "label_title";
            label_title.Size = new Size(558, 47);
            label_title.TabIndex = 1;
            label_title.Text = "HỆ THỐNG QUẢN LÍ THƯ QUÁN";
            // 
            // pictureBox_ThongKe
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox_ThongKe.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox_ThongKe.Image");
            pictureBox1.Location = new Point(759, 117);
            pictureBox1.Name = "pictureBox_ThongKe";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // picture_iconUser
            // 
            picture_iconUser.Image = (Image)resources.GetObject("picture_iconUser.Image");
            picture_iconUser.Location = new Point(583, 311);
            picture_iconUser.Name = "picture_iconUser";
            picture_iconUser.Size = new Size(46, 50);
            picture_iconUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_iconUser.TabIndex = 3;
            picture_iconUser.TabStop = false;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(644, 311);
            txt_User.Multiline = true;
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(467, 50);
            txt_User.TabIndex = 4;
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(644, 392);
            txt_Pass.Multiline = true;
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(467, 50);
            txt_Pass.TabIndex = 5;
            // 
            // picture_iconPass
            // 
            picture_iconPass.Image = (Image)resources.GetObject("picture_iconPass.Image");
            picture_iconPass.Location = new Point(583, 392);
            picture_iconPass.Name = "picture_iconPass";
            picture_iconPass.Size = new Size(46, 50);
            picture_iconPass.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_iconPass.TabIndex = 6;
            picture_iconPass.TabStop = false;
            // 
            // ckbCheck
            // 
            ckbCheck.AutoSize = true;
            ckbCheck.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbCheck.ForeColor = SystemColors.ButtonFace;
            ckbCheck.Location = new Point(940, 458);
            ckbCheck.Name = "ckbCheck";
            ckbCheck.Size = new Size(171, 34);
            ckbCheck.TabIndex = 7;
            ckbCheck.Text = "Hiện Mật Khẩu";
            ckbCheck.UseVisualStyleBackColor = true;
            ckbCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.IndianRed;
            btn_Login.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = SystemColors.ButtonFace;
            btn_Login.Location = new Point(583, 549);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(528, 56);
            btn_Login.TabIndex = 8;
            btn_Login.Text = "ĐĂNG NHẬP";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1132, 661);
            Controls.Add(btn_Login);
            Controls.Add(ckbCheck);
            Controls.Add(picture_iconPass);
            Controls.Add(txt_Pass);
            Controls.Add(txt_User);
            Controls.Add(picture_iconUser);
            Controls.Add(pictureBox1);
            Controls.Add(label_title);
            Controls.Add(picture_left);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(5);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picture_left).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_iconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_iconPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture_left;
        private Label label_title;
        private PictureBox pictureBox1;
        private PictureBox picture_iconUser;
        private TextBox txt_User;
        private TextBox txt_Pass;
        private PictureBox picture_iconPass;
        private CheckBox ckbCheck;
        private Button btn_Login;
    }
}