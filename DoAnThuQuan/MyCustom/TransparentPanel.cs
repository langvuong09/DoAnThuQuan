using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace DoAnThuQuan.MyCustom
{
    internal class TransparentPanel: Panel
    {
        public TransparentPanel()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        public TransparentPanel(LayoutEngine layoutEngine)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.PerformLayout(); // Yêu cầu cập nhật layout
        }
    }
}
