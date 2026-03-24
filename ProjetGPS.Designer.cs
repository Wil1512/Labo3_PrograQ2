namespace Labo4_PrograQ2
{
    partial class ProjetGPS
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
            this.pnlMap = new System.Windows.Forms.Panel();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.txtGps = new System.Windows.Forms.TextBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMap
            // 
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMap.Location = new System.Drawing.Point(488, 0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(312, 450);
            this.pnlMap.TabIndex = 0;
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(6, 7);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(476, 21);
            this.cbPorts.TabIndex = 1;
            // 
            // txtGps
            // 
            this.txtGps.Location = new System.Drawing.Point(8, 166);
            this.txtGps.Multiline = true;
            this.txtGps.Name = "txtGps";
            this.txtGps.Size = new System.Drawing.Size(473, 283);
            this.txtGps.TabIndex = 2;
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(9, 43);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(132, 47);
            this.btnOuvrir.TabIndex = 3;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // ProjetGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.txtGps);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.pnlMap);
            this.Name = "ProjetGPS";
            this.Text = "ProjetGPS";
            this.Load += new System.EventHandler(this.ProjetGPS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.TextBox txtGps;
        private System.Windows.Forms.Button btnOuvrir;
    }
}