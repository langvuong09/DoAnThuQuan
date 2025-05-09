using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnThuQuan.MyCustom
{
    internal class ImagePanel : Panel
    {
        private Image img;

        public ImagePanel(string imgPath) : this(Image.FromFile(imgPath)) { }

        public ImagePanel(Image image)
        {
            this.img = image;
            this.Size = new Size(img.Width, img.Height);
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (img != null)
            {
                e.Graphics.DrawImage(img, 0, 0, this.Width, this.Height);
            }
        }
    }
}
