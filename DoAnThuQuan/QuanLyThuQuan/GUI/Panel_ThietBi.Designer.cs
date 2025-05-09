namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_ThietBi
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
            button_MayChieu = new Button();
            button_MayTinh = new Button();
            panel_Main = new Panel();
            panel_header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.MediumAquamarine;
            panel_header.Controls.Add(button_MayChieu);
            panel_header.Controls.Add(button_MayTinh);
            panel_header.Location = new Point(1, 2);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1290, 60);
            panel_header.TabIndex = 0;
            // 
            // button_MayChieu
            // 
            button_MayChieu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_MayChieu.Location = new Point(197, 10);
            button_MayChieu.Name = "button_MayChieu";
            button_MayChieu.Size = new Size(162, 40);
            button_MayChieu.TabIndex = 1;
            button_MayChieu.Text = "Máy Chiếu";
            button_MayChieu.UseVisualStyleBackColor = true;
            button_MayChieu.Click += button_MayChieu_Click;
            // 
            // button_MayTinh
            // 
            button_MayTinh.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_MayTinh.Location = new Point(13, 10);
            button_MayTinh.Name = "button_MayTinh";
            button_MayTinh.Size = new Size(162, 40);
            button_MayTinh.TabIndex = 0;
            button_MayTinh.Text = "Máy Tính";
            button_MayTinh.UseVisualStyleBackColor = true;
            button_MayTinh.Click += button_MayTinh_Click;
            // 
            // panel_Main
            // 
            panel_Main.BackColor = SystemColors.ButtonFace;
            panel_Main.Location = new Point(0, 58);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1290, 700);
            panel_Main.TabIndex = 1;
            panel_Main.Paint += panel_Main_Paint;
            // 
            // Panel_ThietBi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Main);
            Controls.Add(panel_header);
            Name = "Panel_ThietBi";
            Size = new Size(1290, 760);
            Load += Panel_ThietBi_Load;
            panel_header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_header;
        private Button button_MayChieu;
        private Button button_MayTinh;
        private Panel panel_Main;
        private CardLayoutManager cardLayout;

        partial class CardLayoutManager
        {
            private Panel container;
            private Dictionary<string, Control> cards = new Dictionary<string, Control>();
            private List<string> cardNames = new List<string>();
            private int currentIndex = -1;

            public CardLayoutManager(Panel container) => this.container = container ?? throw new ArgumentNullException(nameof(container));

            public void AddCard(string name, Control card)
            {
                if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
                if (card == null) throw new ArgumentNullException(nameof(card));

                card.Dock = DockStyle.Fill;
                card.Visible = false;
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
                    card.Visible = false;
                }
                cards[name].Visible = true;
                cards[name].BringToFront(); // Đảm bảo panel hiển thị lên trên
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
