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
            // Met à jour le titre et force le redessin (OnPaint)
            this.Text = "Horloge & Spirographe - " + DateTime.Now.ToLongTimeString();
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Améliore la qualité des traits (Anti-crénelage)
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //CALCULS DE BASE
            int xc = ClientSize.Width / 2;
            int yc = ClientSize.Height / 2;
            int rayonBase = Math.Min(xc, yc) - 30;

            //DESSIN DU CADRAN
            using (Pen penCadran = new Pen(Color.Black, 3))
            {
                g.DrawEllipse(penCadran, xc - rayonBase, yc - rayonBase, rayonBase * 2, rayonBase * 2);
            }

            //DESSIN DU SPIROGRAPHE (En arrière-plan)
            DessinerSpirographe(g, xc, yc, rayonBase);

            //CALCUL DES ANGLES DES AIGUILLES
            DateTime m = DateTime.Now;

            //Secondes
            double sAng = (2 * Math.PI * m.Second / 60.0) - Math.PI / 2;
            //Minutes (avec fraction de seconde pour la fluidité)
            double mAng = (2 * Math.PI * (m.Minute + m.Second / 60.0) / 60.0) - Math.PI / 2;
            //Heures (avec fraction de minute)
            double hAng = (2 * Math.PI * (m.Hour % 12 + m.Minute / 60.0) / 12.0) - Math.PI / 2;

            //DESSIN DES AIGUILLES
            DessinerUneAiguille(g, xc, yc, sAng, rayonBase * 0.9, Color.Red, 2);    // Secondes
            DessinerUneAiguille(g, xc, yc, mAng, rayonBase * 0.7, Color.Black, 4);  // Minutes
            DessinerUneAiguille(g, xc, yc, hAng, rayonBase * 0.5, Color.Black, 7);  // Heures

            //Petit cercle central pour la finition
            g.FillEllipse(Brushes.Black, xc - 8, yc - 8, 16, 16);
        }

        private void DessinerSpirographe(Graphics g, int xc, int yc, int rayonMax)
        {
            // Paramètres du spirographe (Hypotrochoïde)
            // R = Rayon grand cercle, r = Rayon petit cercle, d = Distance du point
            double R = rayonMax;
            double r = rayonMax * 0.55;
            double d = rayonMax * 0.4;

            //liste de points pour former une courbe continue
            int resolution = 720; // Plus c'est élevé, plus c'est précis
            PointF[] points = new PointF[resolution + 1];

            for (int i = 0; i <= resolution; i++)
            {
                // On fait varier t (angle)
                double t = i * (Math.PI / 180) * 2;

                // Formule mathématique du spirographe
                double x = (R - r) * Math.Cos(t) + d * Math.Cos(((R - r) / r) * t);
                double y = (R - r) * Math.Sin(t) - d * Math.Sin(((R - r) / r) * t);

                points[i] = new PointF((float)(xc + x), (float)(yc + y));
            }

            // Dessin avec un stylo fin et légèrement transparent pour ne pas masquer les aiguilles
            using (Pen pSpiro = new Pen(Color.FromArgb(80, Color.RoyalBlue), 1))
            {
                g.DrawLines(pSpiro, points);
            }
        }

        private void DessinerUneAiguille(Graphics g, int x, int y, double angle, double longu, Color coul, int epaisseur)
        {
            using (Pen p = new Pen(coul, epaisseur))
            {
                p.StartCap = LineCap.Round;
                p.EndCap = LineCap.ArrowAnchor;

                
                int xFin = (int)(x + longu * Math.Cos(angle));
                int yFin = (int)(y + longu * Math.Sin(angle));

                g.DrawLine(p, x, y, xFin, yFin);
            }
        }
    }
}