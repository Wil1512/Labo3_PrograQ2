namespace Labo4_PrograQ2
{
    partial class FicEditeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicEditeur));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactèreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grasItaliqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soulignéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barréToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMenu = new System.Windows.Forms.Panel();
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            this.pbOuvrir = new System.Windows.Forms.PictureBox();
            this.pbEnregistrer = new System.Windows.Forms.PictureBox();
            this.rtbTexte = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbNouveau = new System.Windows.Forms.PictureBox();
            this.ofdOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.fdPolice = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOuvrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnregistrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNouveau)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.nToolStripMenuItem.Text = "Nouveau";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.collerToolStripMenuItem});
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editerToolStripMenuItem.Text = "Editer";
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justifierToolStripMenuItem,
            this.policeToolStripMenuItem,
            this.charactèreToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // justifierToolStripMenuItem
            // 
            this.justifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaucheToolStripMenuItem,
            this.centreToolStripMenuItem,
            this.droiteToolStripMenuItem});
            this.justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            this.justifierToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.justifierToolStripMenuItem.Text = "Justifier";
            // 
            // gaucheToolStripMenuItem
            // 
            this.gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            this.gaucheToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.gaucheToolStripMenuItem.Text = "Gauche";
            // 
            // centreToolStripMenuItem
            // 
            this.centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            this.centreToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.centreToolStripMenuItem.Text = "Centre";
            // 
            // droiteToolStripMenuItem
            // 
            this.droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            this.droiteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.droiteToolStripMenuItem.Text = "Droite ";
            // 
            // policeToolStripMenuItem
            // 
            this.policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            this.policeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.policeToolStripMenuItem.Text = "Police";
            this.policeToolStripMenuItem.Click += new System.EventHandler(this.policeToolStripMenuItem_Click);
            // 
            // charactèreToolStripMenuItem
            // 
            this.charactèreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grasItaliqueToolStripMenuItem,
            this.italiqueToolStripMenuItem,
            this.soulignéToolStripMenuItem,
            this.barréToolStripMenuItem});
            this.charactèreToolStripMenuItem.Name = "charactèreToolStripMenuItem";
            this.charactèreToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.charactèreToolStripMenuItem.Text = "Charactère";
            // 
            // grasItaliqueToolStripMenuItem
            // 
            this.grasItaliqueToolStripMenuItem.Name = "grasItaliqueToolStripMenuItem";
            this.grasItaliqueToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.grasItaliqueToolStripMenuItem.Text = "Gras";
            this.grasItaliqueToolStripMenuItem.Click += new System.EventHandler(this.grasItaliqueToolStripMenuItem_Click);
            // 
            // italiqueToolStripMenuItem
            // 
            this.italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            this.italiqueToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.italiqueToolStripMenuItem.Text = "Italique";
            this.italiqueToolStripMenuItem.Click += new System.EventHandler(this.italiqueToolStripMenuItem_Click);
            // 
            // soulignéToolStripMenuItem
            // 
            this.soulignéToolStripMenuItem.Name = "soulignéToolStripMenuItem";
            this.soulignéToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.soulignéToolStripMenuItem.Text = "Souligné";
            this.soulignéToolStripMenuItem.Click += new System.EventHandler(this.soulignéToolStripMenuItem_Click);
            // 
            // barréToolStripMenuItem
            // 
            this.barréToolStripMenuItem.Name = "barréToolStripMenuItem";
            this.barréToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.barréToolStripMenuItem.Text = "Barré ";
            this.barréToolStripMenuItem.Click += new System.EventHandler(this.barréToolStripMenuItem_Click);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.pbQuitter);
            this.pMenu.Controls.Add(this.pbOuvrir);
            this.pMenu.Controls.Add(this.pbEnregistrer);
            this.pMenu.Controls.Add(this.rtbTexte);
            this.pMenu.Controls.Add(this.pictureBox2);
            this.pMenu.Controls.Add(this.pbNouveau);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMenu.Location = new System.Drawing.Point(0, 24);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(800, 426);
            this.pMenu.TabIndex = 1;
            // 
            // pbQuitter
            // 
            this.pbQuitter.Image = ((System.Drawing.Image)(resources.GetObject("pbQuitter.Image")));
            this.pbQuitter.Location = new System.Drawing.Point(164, 4);
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.Size = new System.Drawing.Size(47, 17);
            this.pbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuitter.TabIndex = 4;
            this.pbQuitter.TabStop = false;
            this.pbQuitter.Click += new System.EventHandler(this.pbQuitter_Click);
            // 
            // pbOuvrir
            // 
            this.pbOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("pbOuvrir.Image")));
            this.pbOuvrir.Location = new System.Drawing.Point(63, 4);
            this.pbOuvrir.Name = "pbOuvrir";
            this.pbOuvrir.Size = new System.Drawing.Size(42, 18);
            this.pbOuvrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOuvrir.TabIndex = 5;
            this.pbOuvrir.TabStop = false;
            this.pbOuvrir.Click += new System.EventHandler(this.pbOuvrir_Click);
            // 
            // pbEnregistrer
            // 
            this.pbEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("pbEnregistrer.Image")));
            this.pbEnregistrer.Location = new System.Drawing.Point(111, 4);
            this.pbEnregistrer.Name = "pbEnregistrer";
            this.pbEnregistrer.Size = new System.Drawing.Size(47, 18);
            this.pbEnregistrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnregistrer.TabIndex = 3;
            this.pbEnregistrer.TabStop = false;
            this.pbEnregistrer.Click += new System.EventHandler(this.pbEnregistrer_Click);
            // 
            // rtbTexte
            // 
            this.rtbTexte.Location = new System.Drawing.Point(18, 25);
            this.rtbTexte.Name = "rtbTexte";
            this.rtbTexte.Size = new System.Drawing.Size(662, 288);
            this.rtbTexte.TabIndex = 4;
            this.rtbTexte.Text = "";
            this.rtbTexte.TextChanged += new System.EventHandler(this.rtbTexte_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(46, -24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 18);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pbNouveau
            // 
            this.pbNouveau.Image = ((System.Drawing.Image)(resources.GetObject("pbNouveau.Image")));
            this.pbNouveau.Location = new System.Drawing.Point(18, 3);
            this.pbNouveau.Name = "pbNouveau";
            this.pbNouveau.Size = new System.Drawing.Size(39, 18);
            this.pbNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNouveau.TabIndex = 2;
            this.pbNouveau.TabStop = false;
            this.pbNouveau.Click += new System.EventHandler(this.pbNouveau_Click);
            // 
            // ofdOuvrir
            // 
            this.ofdOuvrir.FileName = "openFileDialog1";
            // 
            // FicEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FicEditeur";
            this.Text = "EcranEditeur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOuvrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnregistrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNouveau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactèreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grasItaliqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soulignéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barréToolStripMenuItem;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pbQuitter;
        private System.Windows.Forms.PictureBox pbOuvrir;
        private System.Windows.Forms.PictureBox pbEnregistrer;
        private System.Windows.Forms.RichTextBox rtbTexte;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbNouveau;
        private System.Windows.Forms.OpenFileDialog ofdOuvrir;
        private System.Windows.Forms.SaveFileDialog sfdEnregistrer;
        private System.Windows.Forms.FontDialog fdPolice;
    }
}