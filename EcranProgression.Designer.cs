namespace Labo4_PrograQ2
{
    partial class EcranProgression
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
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.bExecuter = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.lPrincipal = new System.Windows.Forms.Label();
            this.lSecondaire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.Location = new System.Drawing.Point(216, 91);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(215, 42);
            this.pbPrincipal.TabIndex = 0;
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.Location = new System.Drawing.Point(217, 177);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(214, 44);
            this.pbSecondaire.TabIndex = 1;
            // 
            // bExecuter
            // 
            this.bExecuter.Location = new System.Drawing.Point(217, 248);
            this.bExecuter.Name = "bExecuter";
            this.bExecuter.Size = new System.Drawing.Size(94, 39);
            this.bExecuter.TabIndex = 2;
            this.bExecuter.Text = "Exécuter";
            this.bExecuter.UseVisualStyleBackColor = true;
            this.bExecuter.Click += new System.EventHandler(this.bExecuter_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(339, 248);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(92, 38);
            this.bQuitter.TabIndex = 3;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // lPrincipal
            // 
            this.lPrincipal.AutoSize = true;
            this.lPrincipal.Location = new System.Drawing.Point(214, 65);
            this.lPrincipal.Name = "lPrincipal";
            this.lPrincipal.Size = new System.Drawing.Size(76, 13);
            this.lPrincipal.TabIndex = 4;
            this.lPrincipal.Text = "Index Principal";
            // 
            // lSecondaire
            // 
            this.lSecondaire.AutoSize = true;
            this.lSecondaire.Location = new System.Drawing.Point(214, 161);
            this.lSecondaire.Name = "lSecondaire";
            this.lSecondaire.Size = new System.Drawing.Size(90, 13);
            this.lSecondaire.TabIndex = 5;
            this.lSecondaire.Text = "Index Secondaire";
            // 
            // EcranProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSecondaire);
            this.Controls.Add(this.lPrincipal);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bExecuter);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.pbPrincipal);
            this.Name = "EcranProgression";
            this.Text = "EcranProgression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Button bExecuter;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Label lPrincipal;
        private System.Windows.Forms.Label lSecondaire;
    }
}