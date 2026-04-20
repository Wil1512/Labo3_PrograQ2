using System.Windows.Forms;

namespace Labo4_PrograQ2
{
    partial class Ecran_Principal : Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contrôlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.malwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.Horloge = new System.Windows.Forms.Button();
            this.ClavierSouris = new System.Windows.Forms.Button();
            this.btnFicExplorateur = new System.Windows.Forms.Button();
            this.btnGPS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.boutonColore1 = new Labo4_PrograQ2.BoutonColore();
            this.btnDBLocalCouche = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrôlesToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contrôlesToolStripMenuItem
            // 
            this.contrôlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuListe,
            this.menuProgression,
            this.menuQuitter});
            this.contrôlesToolStripMenuItem.Name = "contrôlesToolStripMenuItem";
            this.contrôlesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.contrôlesToolStripMenuItem.Text = "Contrôles";
            // 
            // menuListe
            // 
            this.menuListe.Name = "menuListe";
            this.menuListe.Size = new System.Drawing.Size(182, 22);
            this.menuListe.Text = "Liste";
            this.menuListe.Click += new System.EventHandler(this.menuListe_Click);
            // 
            // menuProgression
            // 
            this.menuProgression.Name = "menuProgression";
            this.menuProgression.Size = new System.Drawing.Size(182, 22);
            this.menuProgression.Text = "Barre de progression";
            this.menuProgression.Click += new System.EventHandler(this.menuProgression_Click);
            // 
            // menuQuitter
            // 
            this.menuQuitter.Name = "menuQuitter";
            this.menuQuitter.Size = new System.Drawing.Size(182, 22);
            this.menuQuitter.Text = "Quitter";
            this.menuQuitter.Click += new System.EventHandler(this.menuQuitter_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditeur,
            this.malwareToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // menuEditeur
            // 
            this.menuEditeur.Name = "menuEditeur";
            this.menuEditeur.Size = new System.Drawing.Size(119, 22);
            this.menuEditeur.Text = "Editeur";
            this.menuEditeur.Click += new System.EventHandler(this.menuEditeur_Click);
            // 
            // malwareToolStripMenuItem
            // 
            this.malwareToolStripMenuItem.Name = "malwareToolStripMenuItem";
            this.malwareToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.malwareToolStripMenuItem.Text = "Malware";
            this.malwareToolStripMenuItem.Click += new System.EventHandler(this.malwareToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAPropos});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // menuAPropos
            // 
            this.menuAPropos.Name = "menuAPropos";
            this.menuAPropos.Size = new System.Drawing.Size(111, 22);
            this.menuAPropos.Text = "Propos";
            this.menuAPropos.Click += new System.EventHandler(this.menuAPropos_Click);
            // 
            // Horloge
            // 
            this.Horloge.Location = new System.Drawing.Point(41, 116);
            this.Horloge.Name = "Horloge";
            this.Horloge.Size = new System.Drawing.Size(150, 42);
            this.Horloge.TabIndex = 1;
            this.Horloge.Text = "Horloge";
            this.Horloge.UseVisualStyleBackColor = true;
            this.Horloge.Click += new System.EventHandler(this.Horloge_Click);
            // 
            // ClavierSouris
            // 
            this.ClavierSouris.Location = new System.Drawing.Point(231, 117);
            this.ClavierSouris.Name = "ClavierSouris";
            this.ClavierSouris.Size = new System.Drawing.Size(150, 41);
            this.ClavierSouris.TabIndex = 2;
            this.ClavierSouris.Text = "ClavierSouris";
            this.ClavierSouris.UseVisualStyleBackColor = true;
            this.ClavierSouris.Click += new System.EventHandler(this.ClavierSouris_Click);
            // 
            // btnFicExplorateur
            // 
            this.btnFicExplorateur.Location = new System.Drawing.Point(41, 193);
            this.btnFicExplorateur.Name = "btnFicExplorateur";
            this.btnFicExplorateur.Size = new System.Drawing.Size(150, 41);
            this.btnFicExplorateur.TabIndex = 3;
            this.btnFicExplorateur.Text = "EcranExplorateur";
            this.btnFicExplorateur.UseVisualStyleBackColor = true;
            this.btnFicExplorateur.Click += new System.EventHandler(this.btnFicExplorateur_Click);
            // 
            // btnGPS
            // 
            this.btnGPS.Location = new System.Drawing.Point(231, 193);
            this.btnGPS.Name = "btnGPS";
            this.btnGPS.Size = new System.Drawing.Size(150, 40);
            this.btnGPS.TabIndex = 4;
            this.btnGPS.Text = "PartieGps";
            this.btnGPS.UseVisualStyleBackColor = true;
            this.btnGPS.Click += new System.EventHandler(this.btnGPS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "BD-Direct";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "BoutonColore";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boutonColore1
            // 
            this.boutonColore1.CouleurDroite = System.Drawing.Color.DarkBlue;
            this.boutonColore1.CouleurGauche = System.Drawing.Color.LightBlue;
            this.boutonColore1.Location = new System.Drawing.Point(41, 265);
            this.boutonColore1.Name = "boutonColore1";
            this.boutonColore1.Size = new System.Drawing.Size(150, 40);
            this.boutonColore1.TabIndex = 7;
            this.boutonColore1.Text = "boutonColore1";
            this.boutonColore1.TranspDroite = 255;
            this.boutonColore1.TranspGauche = 255;
            this.boutonColore1.UseVisualStyleBackColor = true;
            // 
            // btnDBLocalCouche
            // 
            this.btnDBLocalCouche.Location = new System.Drawing.Point(231, 261);
            this.btnDBLocalCouche.Name = "btnDBLocalCouche";
            this.btnDBLocalCouche.Size = new System.Drawing.Size(149, 43);
            this.btnDBLocalCouche.TabIndex = 8;
            this.btnDBLocalCouche.Text = "DBLocalCouche";
            this.btnDBLocalCouche.UseVisualStyleBackColor = true;
            this.btnDBLocalCouche.Click += new System.EventHandler(this.btnDBLocalCouche_Click);
            // 
            // Ecran_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDBLocalCouche);
            this.Controls.Add(this.boutonColore1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGPS);
            this.Controls.Add(this.btnFicExplorateur);
            this.Controls.Add(this.ClavierSouris);
            this.Controls.Add(this.Horloge);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ecran_Principal";
            this.Text = "Ecran_Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ecran_Principal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contrôlesToolStripMenuItem;
        private ToolStripMenuItem menuListe;
        private ToolStripMenuItem menuProgression;
        private ToolStripMenuItem menuQuitter;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem menuAPropos;
        private ToolStripMenuItem menuEditeur;
        private ToolStripMenuItem malwareToolStripMenuItem;
        private Button Horloge;
        private Button ClavierSouris;
        private Button btnFicExplorateur;
        private Button btnGPS;
        private Button button1;
        private Button button2;
        private BoutonColore boutonColore1;
        private Button btnDBLocalCouche;
    }
}