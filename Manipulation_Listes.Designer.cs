namespace Labo4_PrograQ2
{
    partial class Manipulation_Listes
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
            this.bOuvrir = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cbQualite = new System.Windows.Forms.ComboBox();
            this.tbQualite = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bConfirmer = new System.Windows.Forms.Button();
            this.lFichier = new System.Windows.Forms.Label();
            this.lbPersonne = new System.Windows.Forms.ListBox();
            this.bModifer = new System.Windows.Forms.Button();
            this.sfdEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.ofdOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOuvrir
            // 
            this.bOuvrir.Location = new System.Drawing.Point(48, 194);
            this.bOuvrir.Name = "bOuvrir";
            this.bOuvrir.Size = new System.Drawing.Size(131, 21);
            this.bOuvrir.TabIndex = 0;
            this.bOuvrir.Text = "Ouvrir";
            this.bOuvrir.UseVisualStyleBackColor = true;
            this.bOuvrir.Click += new System.EventHandler(this.bOuvrir_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(48, 221);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(130, 22);
            this.bEnregistrer.TabIndex = 1;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(48, 340);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(129, 23);
            this.bAjouter.TabIndex = 2;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(49, 369);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(128, 22);
            this.bSupprimer.TabIndex = 3;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.tbNom);
            this.gbDetail.Controls.Add(this.cbQualite);
            this.gbDetail.Controls.Add(this.tbQualite);
            this.gbDetail.Controls.Add(this.lNom);
            this.gbDetail.Controls.Add(this.bAnnuler);
            this.gbDetail.Controls.Add(this.bConfirmer);
            this.gbDetail.Location = new System.Drawing.Point(248, 186);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(425, 217);
            this.gbDetail.TabIndex = 4;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Détail personne";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(29, 135);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(371, 20);
            this.tbNom.TabIndex = 7;
            // 
            // cbQualite
            // 
            this.cbQualite.FormattingEnabled = true;
            this.cbQualite.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "Mondamoiseau",
            "Indéfini"});
            this.cbQualite.Location = new System.Drawing.Point(29, 64);
            this.cbQualite.Name = "cbQualite";
            this.cbQualite.Size = new System.Drawing.Size(372, 21);
            this.cbQualite.TabIndex = 6;
            // 
            // tbQualite
            // 
            this.tbQualite.AutoSize = true;
            this.tbQualite.Location = new System.Drawing.Point(26, 44);
            this.tbQualite.Name = "tbQualite";
            this.tbQualite.Size = new System.Drawing.Size(40, 13);
            this.tbQualite.TabIndex = 5;
            this.tbQualite.Text = "Qualité";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(26, 112);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 4;
            this.lNom.Text = "Nom";
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(222, 174);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(179, 31);
            this.bAnnuler.TabIndex = 1;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bConfirmer
            // 
            this.bConfirmer.Location = new System.Drawing.Point(28, 174);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(171, 31);
            this.bConfirmer.TabIndex = 0;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.UseVisualStyleBackColor = true;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // lFichier
            // 
            this.lFichier.AutoSize = true;
            this.lFichier.Location = new System.Drawing.Point(46, 19);
            this.lFichier.Name = "lFichier";
            this.lFichier.Size = new System.Drawing.Size(75, 13);
            this.lFichier.TabIndex = 5;
            this.lFichier.Text = "Nom de fichier";
            // 
            // lbPersonne
            // 
            this.lbPersonne.FormattingEnabled = true;
            this.lbPersonne.Location = new System.Drawing.Point(49, 35);
            this.lbPersonne.Name = "lbPersonne";
            this.lbPersonne.Size = new System.Drawing.Size(623, 134);
            this.lbPersonne.TabIndex = 6;
            this.lbPersonne.DoubleClick += new System.EventHandler(this.lbPersonne_DoubleClick);
            // 
            // bModifer
            // 
            this.bModifer.Location = new System.Drawing.Point(49, 275);
            this.bModifer.Name = "bModifer";
            this.bModifer.Size = new System.Drawing.Size(129, 23);
            this.bModifer.TabIndex = 7;
            this.bModifer.Text = "Modifier";
            this.bModifer.UseVisualStyleBackColor = true;
            this.bModifer.Click += new System.EventHandler(this.bModifer_Click);
            // 
            // ofdOuvrir
            // 
            this.ofdOuvrir.FileName = "openFileDialog1";
            // 
            // Manipulation_Listes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bModifer);
            this.Controls.Add(this.lbPersonne);
            this.Controls.Add(this.lFichier);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bOuvrir);
            this.Name = "Manipulation_Listes";
            this.Text = "Manipulation_Listes";
            this.Load += new System.EventHandler(this.Manipulation_Listes_Load);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOuvrir;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bConfirmer;
        private System.Windows.Forms.Label tbQualite;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lFichier;
        private System.Windows.Forms.ListBox lbPersonne;
        private System.Windows.Forms.ComboBox cbQualite;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button bModifer;
        private System.Windows.Forms.SaveFileDialog sfdEnregistrer;
        private System.Windows.Forms.OpenFileDialog ofdOuvrir;
    }
}