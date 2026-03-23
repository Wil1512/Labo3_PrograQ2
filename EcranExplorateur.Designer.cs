namespace Labo4_PrograQ2
{
    partial class FicExplorateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicExplorateur));
            this.tsCommandes = new System.Windows.Forms.ToolStrip();
            this.tsbQuitter = new System.Windows.Forms.ToolStripButton();
            this.tsddbApparence = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.scSeparateur = new System.Windows.Forms.SplitContainer();
            this.tvRepertoire = new System.Windows.Forms.TreeView();
            this.lvFichiers = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Creation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsaDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaPetitesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaGrandesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsaListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCommandes.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSeparateur)).BeginInit();
            this.scSeparateur.Panel1.SuspendLayout();
            this.scSeparateur.Panel2.SuspendLayout();
            this.scSeparateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCommandes
            // 
            this.tsCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuitter,
            this.tsddbApparence});
            this.tsCommandes.Location = new System.Drawing.Point(0, 0);
            this.tsCommandes.Name = "tsCommandes";
            this.tsCommandes.Size = new System.Drawing.Size(800, 25);
            this.tsCommandes.TabIndex = 0;
            this.tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            this.tsbQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQuitter.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuitter.Image")));
            this.tsbQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuitter.Name = "tsbQuitter";
            this.tsbQuitter.Size = new System.Drawing.Size(23, 22);
            this.tsbQuitter.Text = "Quitter";
            this.tsbQuitter.Click += new System.EventHandler(this.tsbQuitter_Click_1);
            // 
            // tsddbApparence
            // 
            this.tsddbApparence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbApparence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsaDetail,
            this.tsaPetitesIcones,
            this.tsaGrandesIcones,
            this.tsaListe});
            this.tsddbApparence.Image = ((System.Drawing.Image)(resources.GetObject("tsddbApparence.Image")));
            this.tsddbApparence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbApparence.Name = "tsddbApparence";
            this.tsddbApparence.Size = new System.Drawing.Size(29, 22);
            this.tsddbApparence.Text = "Affichage";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slMessage
            // 
            this.slMessage.Name = "slMessage";
            this.slMessage.Size = new System.Drawing.Size(28, 17);
            this.slMessage.Text = "Prêt";
            // 
            // scSeparateur
            // 
            this.scSeparateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSeparateur.Location = new System.Drawing.Point(0, 25);
            this.scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            this.scSeparateur.Panel1.Controls.Add(this.tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            this.scSeparateur.Panel2.Controls.Add(this.lvFichiers);
            this.scSeparateur.Size = new System.Drawing.Size(800, 403);
            this.scSeparateur.SplitterDistance = 266;
            this.scSeparateur.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            this.tvRepertoire.Location = new System.Drawing.Point(0, 0);
            this.tvRepertoire.Name = "tvRepertoire";
            this.tvRepertoire.Size = new System.Drawing.Size(262, 403);
            this.tvRepertoire.TabIndex = 0;
            // 
            // lvFichiers
            // 
            this.lvFichiers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Taille,
            this.Creation,
            this.Modification});
            this.lvFichiers.HideSelection = false;
            this.lvFichiers.Location = new System.Drawing.Point(1, 1);
            this.lvFichiers.Name = "lvFichiers";
            this.lvFichiers.Size = new System.Drawing.Size(484, 401);
            this.lvFichiers.TabIndex = 0;
            this.lvFichiers.UseCompatibleStateImageBehavior = false;
            this.lvFichiers.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 150;
            // 
            // Taille
            // 
            this.Taille.Text = "Taille";
            this.Taille.Width = 80;
            // 
            // Creation
            // 
            this.Creation.Text = "Creation";
            this.Creation.Width = 100;
            // 
            // Modification
            // 
            this.Modification.Text = "Modification";
            this.Modification.Width = 100;
            // 
            // tsaDetail
            // 
            this.tsaDetail.Name = "tsaDetail";
            this.tsaDetail.Size = new System.Drawing.Size(180, 22);
            this.tsaDetail.Text = "Details";
            this.tsaDetail.Click += new System.EventHandler(this.tsaDetail_Click);
            // 
            // tsaPetitesIcones
            // 
            this.tsaPetitesIcones.Name = "tsaPetitesIcones";
            this.tsaPetitesIcones.Size = new System.Drawing.Size(180, 22);
            this.tsaPetitesIcones.Text = "PetitesIcones";
            this.tsaPetitesIcones.Click += new System.EventHandler(this.tsaPetitesIcones_Click);
            // 
            // tsaGrandesIcones
            // 
            this.tsaGrandesIcones.Name = "tsaGrandesIcones";
            this.tsaGrandesIcones.Size = new System.Drawing.Size(180, 22);
            this.tsaGrandesIcones.Text = "GrandesIcones";
            this.tsaGrandesIcones.Click += new System.EventHandler(this.tsaGrandesIcones_Click);
            // 
            // tsaListe
            // 
            this.tsaListe.Name = "tsaListe";
            this.tsaListe.Size = new System.Drawing.Size(180, 22);
            this.tsaListe.Text = "Liste";
            this.tsaListe.Click += new System.EventHandler(this.tsaListe_Click);
            // 
            // FicExplorateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scSeparateur);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsCommandes);
            this.Name = "FicExplorateur";
            this.Text = "EcranExplorateur";
            this.Load += new System.EventHandler(this.FicExplorateur_Load);
            this.tsCommandes.ResumeLayout(false);
            this.tsCommandes.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.scSeparateur.Panel1.ResumeLayout(false);
            this.scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSeparateur)).EndInit();
            this.scSeparateur.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCommandes;
        private System.Windows.Forms.ToolStripButton tsbQuitter;
        private System.Windows.Forms.ToolStripDropDownButton tsddbApparence;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slMessage;
        private System.Windows.Forms.SplitContainer scSeparateur;
        private System.Windows.Forms.TreeView tvRepertoire;
        private System.Windows.Forms.ListView lvFichiers;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Taille;
        private System.Windows.Forms.ColumnHeader Creation;
        private System.Windows.Forms.ColumnHeader Modification;
        private System.Windows.Forms.ToolStripMenuItem tsaDetail;
        private System.Windows.Forms.ToolStripMenuItem tsaPetitesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaGrandesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsaListe;
    }
}