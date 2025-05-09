using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_TVien : UserControl
    {
        private Panel panel_header;
        private Button button_CheckInOut;
        private Button button_NVien;
        private Button button_DocGia;
        private Panel panel_Main;
        private CardLayoutManager cardLayout;

        public Panel_TVien()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel_header = new Panel();
            button_DocGia = new Button();
            button_NVien = new Button();
            button_CheckInOut = new Button();
            panel_Main = new Panel();
            panel_header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.MediumAquamarine;
            panel_header.Controls.Add(button_CheckInOut);
            panel_header.Controls.Add(button_NVien);
            panel_header.Controls.Add(button_DocGia);
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1290, 60);
            panel_header.TabIndex = 0;
            // 
            // button_DocGia
            // 
            button_DocGia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_DocGia.Location = new Point(14, 10);
            button_DocGia.Name = "button_DocGia";
            button_DocGia.Size = new Size(206, 38);
            button_DocGia.TabIndex = 0;
            button_DocGia.Text = "Độc Giả";
            button_DocGia.UseVisualStyleBackColor = true;
            button_DocGia.Click += new EventHandler(button_DocGia_Click);
            // 
            // button_NVien
            // 
            button_NVien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_NVien.Location = new Point(235, 10);
            button_NVien.Name = "button_NVien";
            button_NVien.Size = new Size(206, 38);
            button_NVien.TabIndex = 1;
            button_NVien.Text = "Nhân Viên";
            button_NVien.UseVisualStyleBackColor = true;
            button_NVien.Click += new EventHandler(button_NVien_Click);
            // 
            // button_CheckInOut
            // 
            button_CheckInOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CheckInOut.Location = new Point(458, 10);
            button_CheckInOut.Name = "button_CheckInOut";
            button_CheckInOut.Size = new Size(206, 38);
            button_CheckInOut.TabIndex = 2;
            button_CheckInOut.Text = "Check In/Out";
            button_CheckInOut.UseVisualStyleBackColor = true;
            button_CheckInOut.Click += new EventHandler(button_CheckInOut_Click);
            // 
            // panel_Main
            // 
            panel_Main.BackColor = SystemColors.ActiveCaption;
            panel_Main.Location = new Point(0, 60);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1290, 700);
            panel_Main.TabIndex = 1;
            panel_Main.Paint += new PaintEventHandler(panel_Main_Paint);
            // 
            // Panel_TVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Main);
            Controls.Add(panel_header);
            Name = "Panel_TVien";
            Size = new Size(1290, 760);
            Load += new EventHandler(Panel_TVien_Load_1);
            panel_header.ResumeLayout(false);
            ResumeLayout(false);
        }



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