using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_PhieuPhat
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
            button_DSPPhat = new Button();
            button_PPhat = new Button();
            panel_Grid = new Panel();
            panel_header.SuspendLayout();
            SuspendLayout();
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.MediumAquamarine;
            panel_header.Controls.Add(button_DSPPhat);
            panel_header.Controls.Add(button_PPhat);
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(1290, 60);
            panel_header.TabIndex = 1;
            // 
            // button_DSPPhat
            // 
            button_DSPPhat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_DSPPhat.Location = new Point(245, 12);
            button_DSPPhat.Name = "button_DSPPhat";
            button_DSPPhat.Size = new Size(199, 39);
            button_DSPPhat.TabIndex = 2;
            button_DSPPhat.Text = "Danh Sách";
            button_DSPPhat.UseVisualStyleBackColor = true;
            button_DSPPhat.Click += button_DSPPhat_Click;
            // 
            // button_PPhat
            // 
            button_PPhat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_PPhat.Location = new Point(15, 12);
            button_PPhat.Name = "button_PPhat";
            button_PPhat.Size = new Size(199, 39);
            button_PPhat.TabIndex = 1;
            button_PPhat.Text = "Phiếu Phạt";
            button_PPhat.UseVisualStyleBackColor = true;
            button_PPhat.Click += button_PPhat_Click;
            // 
            // panel_Grid
            // 
            panel_Grid.BackColor = SystemColors.ButtonFace;
            panel_Grid.Location = new Point(0, 60);
            panel_Grid.Name = "panel_Grid";
            panel_Grid.Size = new Size(1290, 700);
            panel_Grid.TabIndex = 2;
            panel_Grid.Paint += panel_Grid_Paint_1;
            // 
            // Panel_PhieuPhat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_Grid);
            Controls.Add(panel_header);
            Name = "Panel_PhieuPhat";
            Size = new Size(1290, 760);
            Load += Panel_PhieuPhat_Load;
            panel_header.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Panel_PhieuPhat_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo CardLayoutManager
                cardLayout = new CardLayoutManager(panel_Grid);

                // Tạo và thêm các UserControl
                var panelComponentPPhat = new Panel_ComponentPPhat();
                var panelComponentDSPPhat = new Panel_Component_DSPPhat();
                cardLayout.AddCard("PPhat", panelComponentPPhat);
                cardLayout.AddCard("DSPPhat", panelComponentDSPPhat);

                // Hiển thị trang mặc định
                cardLayout.Show("PPhat");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Panel_PhieuPhat_Load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_PPhat_Click(object sender, EventArgs e)
        {
            cardLayout.Show("PPhat");
        }

        private void button_DSPPhat_Click(object sender, EventArgs e)
        {
            cardLayout.Show("DSPPhat");
        }

        #endregion

        private Panel panel_header;
        private Button button_PPhat;
        private Panel panel_Grid;
        private Button button_DSPPhat;
        private CardLayoutManager cardLayout;
    }

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