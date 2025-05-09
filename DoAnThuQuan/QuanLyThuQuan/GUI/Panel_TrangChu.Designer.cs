namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_TrangChu));
            pictureBox_img = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_img).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_img
            // 
            pictureBox_img.Image = (Image)resources.GetObject("pictureBox_img.Image");
            pictureBox_img.Location = new Point(2, 2);
            pictureBox_img.Name = "pictureBox_img";
            pictureBox_img.Size = new Size(1285, 755);
            pictureBox_img.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_img.TabIndex = 0;
            pictureBox_img.TabStop = false;
            // 
            // Panel_TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox_img);
            Name = "Panel_TrangChu";
            Size = new Size(1290, 760);
            ((System.ComponentModel.ISupportInitialize)pictureBox_img).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_img;
    }
}
