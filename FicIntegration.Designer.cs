namespace Labo4_PrograQ2
{
    partial class FicIntegration
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
            this.tbNbInt = new System.Windows.Forms.TextBox();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.lbGauche = new System.Windows.Forms.Label();
            this.lbDroite = new System.Windows.Forms.Label();
            this.lbNbInt = new System.Windows.Forms.Label();
            this.lbResultats = new System.Windows.Forms.ListBox();
            this.bPolynome = new System.Windows.Forms.Button();
            this.bTrigonometrique = new System.Windows.Forms.Button();
            this.bPointeurPolynome = new System.Windows.Forms.Button();
            this.bPointeurTrigonometrique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNbInt
            // 
            this.tbNbInt.Location = new System.Drawing.Point(561, 60);
            this.tbNbInt.Name = "tbNbInt";
            this.tbNbInt.Size = new System.Drawing.Size(165, 20);
            this.tbNbInt.TabIndex = 0;
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(299, 60);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.Size = new System.Drawing.Size(165, 20);
            this.tbDroite.TabIndex = 1;
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(50, 60);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(165, 20);
            this.tbGauche.TabIndex = 2;
            // 
            // lbGauche
            // 
            this.lbGauche.AutoSize = true;
            this.lbGauche.Location = new System.Drawing.Point(47, 38);
            this.lbGauche.Name = "lbGauche";
            this.lbGauche.Size = new System.Drawing.Size(45, 13);
            this.lbGauche.TabIndex = 3;
            this.lbGauche.Text = "Gauche";
            // 
            // lbDroite
            // 
            this.lbDroite.AutoSize = true;
            this.lbDroite.Location = new System.Drawing.Point(296, 38);
            this.lbDroite.Name = "lbDroite";
            this.lbDroite.Size = new System.Drawing.Size(35, 13);
            this.lbDroite.TabIndex = 4;
            this.lbDroite.Text = "Droite";
            // 
            // lbNbInt
            // 
            this.lbNbInt.AutoSize = true;
            this.lbNbInt.Location = new System.Drawing.Point(558, 38);
            this.lbNbInt.Name = "lbNbInt";
            this.lbNbInt.Size = new System.Drawing.Size(67, 13);
            this.lbNbInt.TabIndex = 5;
            this.lbNbInt.Text = "Nb Intervalle";
            // 
            // lbResultats
            // 
            this.lbResultats.FormattingEnabled = true;
            this.lbResultats.Location = new System.Drawing.Point(51, 94);
            this.lbResultats.Name = "lbResultats";
            this.lbResultats.Size = new System.Drawing.Size(674, 186);
            this.lbResultats.TabIndex = 6;
            // 
            // bPolynome
            // 
            this.bPolynome.Location = new System.Drawing.Point(51, 305);
            this.bPolynome.Name = "bPolynome";
            this.bPolynome.Size = new System.Drawing.Size(281, 39);
            this.bPolynome.TabIndex = 7;
            this.bPolynome.Text = "Polynôme : x*x + 2";
            this.bPolynome.UseVisualStyleBackColor = true;
            this.bPolynome.Click += new System.EventHandler(this.bPolynome_Click);
            // 
            // bTrigonometrique
            // 
            this.bTrigonometrique.Location = new System.Drawing.Point(51, 350);
            this.bTrigonometrique.Name = "bTrigonometrique";
            this.bTrigonometrique.Size = new System.Drawing.Size(281, 42);
            this.bTrigonometrique.TabIndex = 8;
            this.bTrigonometrique.Text = "Trigonométrique : sin(x)";
            this.bTrigonometrique.UseVisualStyleBackColor = true;
            this.bTrigonometrique.Click += new System.EventHandler(this.bTrigonometrique_Click);
            // 
            // bPointeurPolynome
            // 
            this.bPointeurPolynome.Location = new System.Drawing.Point(445, 305);
            this.bPointeurPolynome.Name = "bPointeurPolynome";
            this.bPointeurPolynome.Size = new System.Drawing.Size(280, 39);
            this.bPointeurPolynome.TabIndex = 9;
            this.bPointeurPolynome.Text = "Idem Pointeur";
            this.bPointeurPolynome.UseVisualStyleBackColor = true;
            this.bPointeurPolynome.Click += new System.EventHandler(this.bPointeurPolynome_Click_1);
            // 
            // bPointeurTrigonometrique
            // 
            this.bPointeurTrigonometrique.Location = new System.Drawing.Point(445, 350);
            this.bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            this.bPointeurTrigonometrique.Size = new System.Drawing.Size(280, 42);
            this.bPointeurTrigonometrique.TabIndex = 10;
            this.bPointeurTrigonometrique.Text = "Idem Pointeur";
            this.bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            this.bPointeurTrigonometrique.Click += new System.EventHandler(this.bPointeurTrigonometrique_Click);
            // 
            // FicIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bPointeurTrigonometrique);
            this.Controls.Add(this.bPointeurPolynome);
            this.Controls.Add(this.bTrigonometrique);
            this.Controls.Add(this.bPolynome);
            this.Controls.Add(this.lbResultats);
            this.Controls.Add(this.lbNbInt);
            this.Controls.Add(this.lbDroite);
            this.Controls.Add(this.lbGauche);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.tbNbInt);
            this.Name = "FicIntegration";
            this.Text = "GestionDeProcessus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNbInt;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.Label lbGauche;
        private System.Windows.Forms.Label lbDroite;
        private System.Windows.Forms.Label lbNbInt;
        private System.Windows.Forms.ListBox lbResultats;
        private System.Windows.Forms.Button bPolynome;
        private System.Windows.Forms.Button bTrigonometrique;
        private System.Windows.Forms.Button bPointeurPolynome;
        private System.Windows.Forms.Button bPointeurTrigonometrique;
    }
}