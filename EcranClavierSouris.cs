using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4_PrograQ2
{
    public partial class EcranClavierSouris : Form
    {
        private int nbGauche = 0;
        private int nbDroit = 0;
        public EcranClavierSouris()
        {
            InitializeComponent();
            // Permet au formulaire de capter les touches clavier avant les contrôles
            this.KeyPreview = true;
            AfficherClic();
        }
        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString();
            tbxClicDroit.Text = nbDroit.ToString();
        }

        // --- ÉVÉNEMENTS SOURIS (Sur le Panel pnlSouris) ---
        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private void pnlSouris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) nbGauche++;
            if (e.Button == MouseButtons.Right) nbDroit++;

            AfficherClic();

            int colonne = (e.X / (pnlSouris.Width / 3)) + 1;
            int ligne = (e.Y / (pnlSouris.Height / 3)) + 1;

            // On utilise Insert(0, ...) pour que le message le plus récent soit en haut
            lsbClavier.Items.Insert(0, $"Souris : Clic en L{ligne}, C{colonne}");
        }

        private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Insert(0, $"Down - Code: {e.KeyCode}, Value: {e.KeyValue}");
        }

        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            lsbClavier.Items.Insert(0, $"Press - Char: {e.KeyChar}");
        }

        private void EcranClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            lsbClavier.Items.Insert(0, $"Up - Code: {e.KeyCode}");
        }

        // --- BOUTON REMISE À ZÉRO ---
        private void butRAZ_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();
            tbxPositionX.Text = "0";
            tbxPositionY.Text = "0";
            lsbClavier.Items.Clear();
        }
    }
}
