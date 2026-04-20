using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4_PrograQ2
{
    [ToolboxBitmap(typeof(BoutonColore), "BoutonColore.bmp")]
    public partial class BoutonColore : Button
    {
        // 1. Les champs (données privées)
        private Color cGauche = Color.LightBlue;
        private Color cDroite = Color.DarkBlue;
        private int tGauche = 255;
        private int tDroite = 255;
        public BoutonColore()
        {
            //valeurs par défaut
            this.Size = new Size(150, 40);
            this.Text = "Bouton Coloré";
        }

        
        [Category("Design Labo"), Description("Couleur de départ du dégradé")]
        public Color CouleurGauche
        {
            get { return cGauche; }
            set { cGauche = value; this.Invalidate(); }
        }

        [Category("Design Labo"), Description("Couleur de fin du dégradé")]
        public Color CouleurDroite
        {
            get { return cDroite; }
            set { cDroite = value; this.Invalidate(); }
        }

        [Category("Design Labo"), Description("Transparence gauche (0-255)")]
        public int TranspGauche
        {
            get { return tGauche; }
            set { tGauche = Math.Max(0, Math.Min(255, value)); this.Invalidate(); }
        }

        [Category("Design Labo"), Description("Transparence droite (0-255)")]
        public int TranspDroite
        {
            get { return tDroite; }
            set { tDroite = Math.Max(0, Math.Min(255, value)); this.Invalidate(); }
        }

        // 4. La méthode de dessin (Surcharge de OnPaint)
        protected override void OnPaint(PaintEventArgs pevent)
        {
            
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;

           
            Color col1 = Color.FromArgb(tGauche, cGauche);
            Color col2 = Color.FromArgb(tDroite, cDroite);

            
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, col1, col2, LinearGradientMode.Horizontal))
            {
                g.FillRectangle(brush, this.ClientRectangle);
            }


            SizeF textSize = g.MeasureString(this.Text, this.Font);
            float x = (this.Width - textSize.Width) / 2;
            float y = (this.Height - textSize.Height) / 2;

            using (SolidBrush drawBrush = new SolidBrush(this.ForeColor))
            {
                g.DrawString(this.Text, this.Font, drawBrush, x, y);
            }
        }
    }
}
