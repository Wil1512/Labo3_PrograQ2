namespace Labo4_PrograQ2
{
    partial class EcranBDDirect
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
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.bConsulter = new System.Windows.Forms.Button();
            this.bDenombrer = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbConsole
            // 
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new System.Drawing.Point(4, 7);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(390, 420);
            this.lbConsole.TabIndex = 0;
            // 
            // bConsulter
            // 
            this.bConsulter.Location = new System.Drawing.Point(425, 12);
            this.bConsulter.Name = "bConsulter";
            this.bConsulter.Size = new System.Drawing.Size(284, 44);
            this.bConsulter.TabIndex = 1;
            this.bConsulter.Text = "Consulter";
            this.bConsulter.UseVisualStyleBackColor = true;
            this.bConsulter.Click += new System.EventHandler(this.bConsulter_Click);
            // 
            // bDenombrer
            // 
            this.bDenombrer.Location = new System.Drawing.Point(425, 77);
            this.bDenombrer.Name = "bDenombrer";
            this.bDenombrer.Size = new System.Drawing.Size(284, 44);
            this.bDenombrer.TabIndex = 2;
            this.bDenombrer.Text = "Denombrer";
            this.bDenombrer.UseVisualStyleBackColor = true;
            this.bDenombrer.Click += new System.EventHandler(this.bDenombrer_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(425, 383);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(284, 44);
            this.bAjouter.TabIndex = 3;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(422, 265);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(46, 13);
            this.lbPrenom.TabIndex = 4;
            this.lbPrenom.Text = "Prenom ";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(422, 321);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(29, 13);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nom";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(425, 281);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(276, 20);
            this.tbPrenom.TabIndex = 6;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(425, 337);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(276, 20);
            this.tbNom.TabIndex = 7;
            // 
            // EcranBDDirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.bDenombrer);
            this.Controls.Add(this.bConsulter);
            this.Controls.Add(this.lbConsole);
            this.Name = "EcranBDDirect";
            this.Text = "EcranBDDirect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbConsole;
        private System.Windows.Forms.Button bConsulter;
        private System.Windows.Forms.Button bDenombrer;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
    }
}