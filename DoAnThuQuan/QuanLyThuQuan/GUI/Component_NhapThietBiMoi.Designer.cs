namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Component_NhapThietBiMoi
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
            panel_header = new Panel();
            button_MChieu = new Button();
            button_MayTinh = new Button();
            panel_Main = new Panel();
            panel_header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.MediumAquamarine;
            panel_header.Controls.Add(button_MChieu);
            panel_header.Controls.Add(button_MayTinh);
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1000, 49);
            panel_header.TabIndex = 0;
            panel_header.Paint += panel_header_Paint;
            // 
            // button_MChieu
            // 
            button_MChieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_MChieu.Location = new Point(186, 9);
            button_MChieu.Name = "button_MChieu";
            button_MChieu.Size = new Size(153, 40);
            button_MChieu.TabIndex = 1;
            button_MChieu.Text = "MÁY CHIẾU";
            button_MChieu.UseVisualStyleBackColor = true;
            button_MChieu.Click += button_MChieu_Click;
            // 
            // button_MayTinh
            // 
            button_MayTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_MayTinh.Location = new Point(15, 9);
            button_MayTinh.Name = "button_MayTinh";
            button_MayTinh.Size = new Size(153, 40);
            button_MayTinh.TabIndex = 0;
            button_MayTinh.Text = "MÁY TÍNH";
            button_MayTinh.UseVisualStyleBackColor = true;
            button_MayTinh.Click += button_MayTinh_Click;
            // 
            // panel_Main
            // 
            panel_Main.BackColor = SystemColors.ActiveCaption;
            panel_Main.Location = new Point(0, 55);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1000, 434);
            panel_Main.TabIndex = 1;
            panel_Main.Paint += panel_Main_Paint;
            // 
            // Component_NhapThietBiMoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Main);
            Controls.Add(panel_header);
            Name = "Component_NhapThietBiMoi";
            Size = new Size(1000, 490);
            Load += Component_NhapThietBiMoi_Load;
            panel_header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_header;
        private Button button_MChieu;
        private Button button_MayTinh;
        private Panel panel_Main;
        private CardLayoutManager cardLayout;

        internal class CardLayoutManager
        {
            private Panel container;
            private Dictionary<string, Control> cards = new Dictionary<string, Control>();
            private List<string> cardNames = new List<string>();
            private int currentIndex = -1;

            public CardLayoutManager(Panel container)
            {
                this.container = container ?? throw new ArgumentNullException(nameof(container));
            }

            public void AddCard(string name, Control card)
            {
                if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
                if (card == null) throw new ArgumentNullException(nameof(card));

                card.Dock = DockStyle.Fill;
                card.Visible = false; // Ẩn mặc định
                container.Controls.Add(card);
                cards.Add(name, card);
                cardNames.Add(name);
            }

            public void Show(string name)
            {
                if (!cards.ContainsKey(name))
                {
                    MessageBox.Show($"Card '{name}' not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (Control card in cards.Values)
                {
                    card.Visible = false; // Ẩn tất cả
                }
                cards[name].Visible = true; // Hiển thị thẻ được chọn
                currentIndex = cardNames.IndexOf(name);
            }

            public void Next()
            {
                if (cardNames.Count == 0) return;
                currentIndex = (currentIndex + 1) % cardNames.Count;
                Show(cardNames[currentIndex]);
            }
        }
    }
}
