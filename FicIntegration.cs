using CefSharp.DevTools.Cast;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//une fonction qui prend un double et rend un double
public delegate double fctAIntegrer(double x);

namespace Labo4_PrograQ2
{
    public partial class FicIntegration : Form
    {
        //Fonctions à intégrer 
        private double MaFonctionPolynome(double x) => (x * x) + 2;
        private double MaFonctionTrigo(double x) => Math.Sin(x);
        public FicIntegration()
        {
            InitializeComponent();
        }


        public double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroit, int nInterval)
        {
            double h = (xDroit - xGauche) / nInterval; // Largeur d'un trapèze
            double aireTotale = 0;

            for (int i = 0; i < nInterval; i++)
            {
                double x1 = xGauche + i * h;
                double x2 = x1 + h;

                aireTotale += (f(x1) + f(x2)) * h / 2;
            }
            return aireTotale;
        }

        private void LancerCalcul(fctAIntegrer f, string nomFct)
        {
            lbResultats.Items.Add($"Méthode des trapèzes");
            lbResultats.Items.Add($"{nomFct}");

            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int nBase = int.Parse(tbNbInt.Text);

            for (int i = 0; i < 5; i++)
            {
                // Calcul de n, 2n, 4n... (n * 2^i)
                int nActuel = nBase * (int)Math.Pow(2, i);
                double resultat = IntegrationTrapeze(f, a, b, nActuel);
                lbResultats.Items.Add($"  Nb Int : {nActuel} => {resultat}");
            }
            lbResultats.Items.Add(""); // Espace vide
        }

  
        private void bPolynome_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbGauche.Text);
            double b = double.Parse(tbDroite.Text);
            int n = int.Parse(tbNbInt.Text);
            double h = (b - a) / n;
            double somme = 0;

            for (int i = 0; i < n; i++)
            {
                double x1 = a + i * h;
                double x2 = x1 + h;

                // Le calcul mathématique est écrit ici en dur
                somme += (((x1 * x1 + 2) + (x2 * x2 + 2)) / 2) * h;
            }
            lbResultats.Items.Add($"Poly Trad (n={n}) : {somme}");
        }

        
        public double Polynome(double x)
        {
            return (x * x) + 2;
        }

        public double Sinus(double x)
        {
            return Math.Sin(x);
        }

        private void bPointeurPolynome_Click_1(object sender, EventArgs e) => LancerCalcul(Polynome, "Polynôme : x*x + 2");

        private void bPointeurTrigonometrique_Click(object sender, EventArgs e) => LancerCalcul(Sinus, "Trigonométrique : sin(x)");

        private void bTrigonometrique_Click(object sender, EventArgs e)
        {
            LancerCalcul(x => Math.Sin(x), "Trigonométrique : sin(x)");
        }
    }
}
