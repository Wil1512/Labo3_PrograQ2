namespace Labo4_PrograQ2
{
    partial class EcranClavierSouris
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
            this.lsbClavier = new System.Windows.Forms.ListBox();
            this.Interception_clavier = new System.Windows.Forms.Label();
            this.butRAZ = new System.Windows.Forms.Button();
            this.tbxClicGauche = new System.Windows.Forms.TextBox();
            this.tbxClicDroit = new System.Windows.Forms.TextBox();
            this.tbxPositionX = new System.Windows.Forms.TextBox();
            this.tbxPositionY = new System.Windows.Forms.TextBox();
            this.pnlSouris = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbClavier
            // 
            this.lsbClavier.FormattingEnabled = true;
            this.lsbClavier.Location = new System.Drawing.Point(54, 49);
            this.lsbClavier.Name = "lsbClavier";
            this.lsbClavier.Size = new System.Drawing.Size(182, 277);
            this.lsbClavier.TabIndex = 0;
            // 
            // Interception_clavier
            // 
            this.Interception_clavier.AutoSize = true;
            this.Interception_clavier.Location = new System.Drawing.Point(52, 34);
            this.Interception_clavier.Name = "Interception_clavier";
            this.Interception_clavier.Size = new System.Drawing.Size(100, 13);
            this.Interception_clavier.TabIndex = 1;
            this.Interception_clavier.Text = "Interception_clavier";
            // 
            // butRAZ
            // 
            this.butRAZ.Location = new System.Drawing.Point(55, 338);
            this.butRAZ.Name = "butRAZ";
            this.butRAZ.Size = new System.Drawing.Size(180, 30);
            this.butRAZ.TabIndex = 2;
            this.butRAZ.Text = "Remis a Zéro";
            this.butRAZ.UseVisualStyleBackColor = true;
            this.butRAZ.Click += new System.EventHandler(this.butRAZ_Click);
            // 
            // tbxClicGauche
            // 
            this.tbxClicGauche.Location = new System.Drawing.Point(245, 50);
            this.tbxClicGauche.Name = "tbxClicGauche";
            this.tbxClicGauche.Size = new System.Drawing.Size(62, 20);
            this.tbxClicGauche.TabIndex = 3;
            // 
            // tbxClicDroit
            // 
            this.tbxClicDroit.Location = new System.Drawing.Point(334, 50);
            this.tbxClicDroit.Name = "tbxClicDroit";
            this.tbxClicDroit.Size = new System.Drawing.Size(63, 20);
            this.tbxClicDroit.TabIndex = 4;
            // 
            // tbxPositionX
            // 
            this.tbxPositionX.Location = new System.Drawing.Point(415, 49);
            this.tbxPositionX.Name = "tbxPositionX";
            this.tbxPositionX.Size = new System.Drawing.Size(61, 20);
            this.tbxPositionX.TabIndex = 5;
            // 
            // tbxPositionY
            // 
            this.tbxPositionY.Location = new System.Drawing.Point(504, 48);
            this.tbxPositionY.Name = "tbxPositionY";
            this.tbxPositionY.Size = new System.Drawing.Size(66, 20);
            this.tbxPositionY.TabIndex = 6;
            // 
            // pnlSouris
            // 
            this.pnlSouris.Location = new System.Drawing.Point(246, 80);
            this.pnlSouris.Name = "pnlSouris";
            this.pnlSouris.Size = new System.Drawing.Size(323, 287);
            this.pnlSouris.TabIndex = 7;
            this.pnlSouris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSouris_MouseDown);
            this.pnlSouris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSouris_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click Gauche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Click Droit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Position X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Position Y";
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSouris);
            this.Controls.Add(this.tbxPositionY);
            this.Controls.Add(this.tbxPositionX);
            this.Controls.Add(this.tbxClicDroit);
            this.Controls.Add(this.tbxClicGauche);
            this.Controls.Add(this.butRAZ);
            this.Controls.Add(this.Interception_clavier);
            this.Controls.Add(this.lsbClavier);
            this.Name = "EcranClavierSouris";
            this.Text = "EcranClavierSouris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EcranClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbClavier;
        private System.Windows.Forms.Label Interception_clavier;
        private System.Windows.Forms.Button butRAZ;
        private System.Windows.Forms.TextBox tbxClicGauche;
        private System.Windows.Forms.TextBox tbxClicDroit;
        private System.Windows.Forms.TextBox tbxPositionX;
        private System.Windows.Forms.TextBox tbxPositionY;
        private System.Windows.Forms.Panel pnlSouris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}