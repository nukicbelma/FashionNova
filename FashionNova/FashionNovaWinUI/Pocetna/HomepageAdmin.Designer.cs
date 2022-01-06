
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
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajVelicinuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajMaterijalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajBojuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajVrstuArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.klijentiToolStripMenuItem1,
            this.stavkeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(562, 24);
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
            this.pregledArtikalaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pregledArtikalaToolStripMenuItem.Text = "Pregled artikala";
            this.pregledArtikalaToolStripMenuItem.Click += new System.EventHandler(this.pregledArtikalaToolStripMenuItem_Click);
            // 
            // dodajArtikalToolStripMenuItem
            // 
            this.dodajArtikalToolStripMenuItem.Name = "dodajArtikalToolStripMenuItem";
            this.dodajArtikalToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dodajArtikalToolStripMenuItem.Text = "Dodaj artikal";
            this.dodajArtikalToolStripMenuItem.Click += new System.EventHandler(this.dodajArtikalToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.klijentiToolStripMenuItem.Text = "Korisnici";
            this.klijentiToolStripMenuItem.Click += new System.EventHandler(this.klijentiToolStripMenuItem_Click);
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click_1);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
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
            this.pregledKlijenataToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pregledKlijenataToolStripMenuItem.Text = "Pregled klijenata";
            this.pregledKlijenataToolStripMenuItem.Click += new System.EventHandler(this.pregledKlijenataToolStripMenuItem_Click);
            // 
            // stavkeToolStripMenuItem
            // 
            this.stavkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajVelicinuToolStripMenuItem,
            this.dodajMaterijalToolStripMenuItem,
            this.dodajBojuToolStripMenuItem,
            this.dodajVrstuArtiklaToolStripMenuItem});
            this.stavkeToolStripMenuItem.Name = "stavkeToolStripMenuItem";
            this.stavkeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.stavkeToolStripMenuItem.Text = "Stavke";
            // 
            // dodajVelicinuToolStripMenuItem
            // 
            this.dodajVelicinuToolStripMenuItem.Name = "dodajVelicinuToolStripMenuItem";
            this.dodajVelicinuToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dodajVelicinuToolStripMenuItem.Text = "Dodaj velicinu";
            this.dodajVelicinuToolStripMenuItem.Click += new System.EventHandler(this.dodajVelicinuToolStripMenuItem_Click);
            // 
            // dodajMaterijalToolStripMenuItem
            // 
            this.dodajMaterijalToolStripMenuItem.Name = "dodajMaterijalToolStripMenuItem";
            this.dodajMaterijalToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dodajMaterijalToolStripMenuItem.Text = "Dodaj materijal";
            this.dodajMaterijalToolStripMenuItem.Click += new System.EventHandler(this.dodajMaterijalToolStripMenuItem_Click);
            // 
            // dodajBojuToolStripMenuItem
            // 
            this.dodajBojuToolStripMenuItem.Name = "dodajBojuToolStripMenuItem";
            this.dodajBojuToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dodajBojuToolStripMenuItem.Text = "Dodaj boju";
            this.dodajBojuToolStripMenuItem.Click += new System.EventHandler(this.dodajBojuToolStripMenuItem_Click);
            // 
            // dodajVrstuArtiklaToolStripMenuItem
            // 
            this.dodajVrstuArtiklaToolStripMenuItem.Name = "dodajVrstuArtiklaToolStripMenuItem";
            this.dodajVrstuArtiklaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dodajVrstuArtiklaToolStripMenuItem.Text = "Dodaj vrstu artikla";
            this.dodajVrstuArtiklaToolStripMenuItem.Click += new System.EventHandler(this.dodajVrstuArtiklaToolStripMenuItem_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(461, 0);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(101, 23);
            this.btnOdjava.TabIndex = 2;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // HomepageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 254);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HomepageAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage::admin";
            this.Load += new System.EventHandler(this.HomepageAdmin_Load);
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
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajVelicinuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajMaterijalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajBojuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajVrstuArtiklaToolStripMenuItem;
        private System.Windows.Forms.Button btnOdjava;
    }
}



