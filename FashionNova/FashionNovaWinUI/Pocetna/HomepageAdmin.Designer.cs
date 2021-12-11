
namespace FashionNova.WinUI.Pocetna
{
    partial class HomepageAdmin
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajArtikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.klijentiToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(666, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledArtikalaToolStripMenuItem,
            this.dodajArtikalToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.korisniciToolStripMenuItem.Text = "Artikli";
            // 
            // pregledArtikalaToolStripMenuItem
            // 
            this.pregledArtikalaToolStripMenuItem.Name = "pregledArtikalaToolStripMenuItem";
            this.pregledArtikalaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledArtikalaToolStripMenuItem.Text = "Pregled artikala";
            this.pregledArtikalaToolStripMenuItem.Click += new System.EventHandler(this.pregledArtikalaToolStripMenuItem_Click);
            // 
            // dodajArtikalToolStripMenuItem
            // 
            this.dodajArtikalToolStripMenuItem.Name = "dodajArtikalToolStripMenuItem";
            this.dodajArtikalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajArtikalToolStripMenuItem.Text = "Dodaj artikal";
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.klijentiToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled korisnika";
            // 
            // klijentiToolStripMenuItem1
            // 
            this.klijentiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKlijenataToolStripMenuItem});
            this.klijentiToolStripMenuItem1.Name = "klijentiToolStripMenuItem1";
            this.klijentiToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.klijentiToolStripMenuItem1.Text = "Klijenti";
            // 
            // pregledKlijenataToolStripMenuItem
            // 
            this.pregledKlijenataToolStripMenuItem.Name = "pregledKlijenataToolStripMenuItem";
            this.pregledKlijenataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledKlijenataToolStripMenuItem.Text = "Pregled klijenata";
            this.pregledKlijenataToolStripMenuItem.Click += new System.EventHandler(this.pregledKlijenataToolStripMenuItem_Click);
            // 
            // HomepageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 247);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomepageAdmin";
            this.Text = "Homepage::admin";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajArtikalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKlijenataToolStripMenuItem;
    }
}



