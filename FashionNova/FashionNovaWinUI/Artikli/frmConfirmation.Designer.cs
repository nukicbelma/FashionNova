﻿
namespace FashionNova.WinUI.Artikli
{
    partial class frmConfirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDa = new System.Windows.Forms.Button();
            this.btnNe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jeste li sigurni da zelite obrisati odabrani artikal?";
            // 
            // btnDa
            // 
            this.btnDa.Location = new System.Drawing.Point(205, 92);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(75, 23);
            this.btnDa.TabIndex = 1;
            this.btnDa.Text = "Da";
            this.btnDa.UseVisualStyleBackColor = true;
            this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
            // 
            // btnNe
            // 
            this.btnNe.Location = new System.Drawing.Point(23, 92);
            this.btnNe.Name = "btnNe";
            this.btnNe.Size = new System.Drawing.Size(75, 23);
            this.btnNe.TabIndex = 2;
            this.btnNe.Text = "Ne";
            this.btnNe.UseVisualStyleBackColor = true;
            this.btnNe.Click += new System.EventHandler(this.btnNe_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(312, 150);
            this.Controls.Add(this.btnNe);
            this.Controls.Add(this.btnDa);
            this.Controls.Add(this.label1);
            this.Name = "frmConfirmation";
            this.Text = "Alert!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Button btnNe;
    }
}