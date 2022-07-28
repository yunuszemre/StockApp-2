namespace StockApp_2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriHizmetleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterileriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriHizmetleriToolStripMenuItem,
            this.stokİşlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriHizmetleriToolStripMenuItem
            // 
            this.müşteriHizmetleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriToolStripMenuItem,
            this.müşterileriGörüntüleToolStripMenuItem});
            this.müşteriHizmetleriToolStripMenuItem.Name = "müşteriHizmetleriToolStripMenuItem";
            this.müşteriHizmetleriToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.müşteriHizmetleriToolStripMenuItem.Text = "Müşteri Hizmetleri";
            // 
            // yeniMüşteriToolStripMenuItem
            // 
            this.yeniMüşteriToolStripMenuItem.Name = "yeniMüşteriToolStripMenuItem";
            this.yeniMüşteriToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.yeniMüşteriToolStripMenuItem.Text = "Yeni Müşteri";
            this.yeniMüşteriToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşteriToolStripMenuItem_Click);
            // 
            // müşterileriGörüntüleToolStripMenuItem
            // 
            this.müşterileriGörüntüleToolStripMenuItem.Name = "müşterileriGörüntüleToolStripMenuItem";
            this.müşterileriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.müşterileriGörüntüleToolStripMenuItem.Text = "Müşterileri Görüntüle";
            this.müşterileriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.müşterileriGörüntüleToolStripMenuItem_Click);
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünleriGörüntüleToolStripMenuItem,
            this.ürünEkleToolStripMenuItem,
            this.ürünSilToolStripMenuItem});
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.stokİşlemleriToolStripMenuItem.Text = "Stok İşlemleri";
            // 
            // ürünleriGörüntüleToolStripMenuItem
            // 
            this.ürünleriGörüntüleToolStripMenuItem.Name = "ürünleriGörüntüleToolStripMenuItem";
            this.ürünleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünleriGörüntüleToolStripMenuItem.Text = "Ürünleri Görüntüle";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            // 
            // ürünSilToolStripMenuItem
            // 
            this.ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            this.ürünSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünSilToolStripMenuItem.Text = "Ürün Sil";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemAyarlarıToolStripMenuItem,
            this.kullanıcıAyarlarıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // sistemAyarlarıToolStripMenuItem
            // 
            this.sistemAyarlarıToolStripMenuItem.Name = "sistemAyarlarıToolStripMenuItem";
            this.sistemAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sistemAyarlarıToolStripMenuItem.Text = "Sistem Ayarları";
            // 
            // kullanıcıAyarlarıToolStripMenuItem
            // 
            this.kullanıcıAyarlarıToolStripMenuItem.Name = "kullanıcıAyarlarıToolStripMenuItem";
            this.kullanıcıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıAyarlarıToolStripMenuItem.Text = "Kullanıcı Ayarları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriHizmetleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterileriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıAyarlarıToolStripMenuItem;
    }
}

