using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Labo4_PrograQ2
{
    public partial class EcranHorloge : Form
    {
        public EcranHorloge()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Horloge - " + DateTime.Now.ToLongTimeString();
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Améliore la qualité
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Calcul du centre et de la taille en fonction de la fenêtre
            int xc = ClientSize.Width / 2;
            int yc = ClientSize.Height / 2;
            int rayon = Math.Min(xc, yc) - 30;

            // Récupérer l'heure actuelle
            DateTime m = DateTime.Now;

            // DESSIN DU CADRAN
            g.DrawEllipse(new Pen(Color.Black, 3), xc - rayon, yc - rayon, rayon * 2, rayon * 2);

            // CALCUL DES ANGLES (Trigonométrie)
            // On soustrait PI/2 (90°) car en maths le 0 est à droite, pas en haut.

            // Secondes
            double sAng = (2 * Math.PI * m.Second / 60.0) - Math.PI / 2;

            // Minutes (progressives : minute + fraction de seconde)
            double mAng = (2 * Math.PI * (m.Minute + m.Second / 60.0) / 60.0) - Math.PI / 2;

            // Heures (progressives : heure + fraction de minute)
            double hAng = (2 * Math.PI * (m.Hour % 12 + m.Minute / 60.0) / 12.0) - Math.PI / 2;
            // DESSIN DES AIGUILLES
            DessinerUneAiguille(g, xc, yc, sAng, rayon * 0.9, Color.Red, 2);    // Secondes
            DessinerUneAiguille(g, xc, yc, mAng, rayon * 0.7, Color.Black, 4);  // Minutes
            DessinerUneAiguille(g, xc, yc, hAng, rayon * 0.5, Color.Black, 7);  // Heures
        }

        private void DessinerUneAiguille(Graphics g, int x, int y, double angle, double longu, Color coul, int epaisseur)
        {
            using (Pen p = new Pen(coul, epaisseur))
            {
                p.StartCap = LineCap.Round; // Bout arrondi côté centre
                p.EndCap = LineCap.ArrowAnchor; // Pointe en flèche (optionnel)

                int xFin = (int)(x + longu * Math.Cos(angle));
                int yFin = (int)(y + longu * Math.Sin(angle));

                g.DrawLine(p, x, y, xFin, yFin);
            }
        }
    }
}
