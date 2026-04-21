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
    public partial class Ecran_Principal : Form
    {
        public Ecran_Principal()
        {
            InitializeComponent();
        }

        private void Ecran_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez-vous vraiment quitter ?",
                                              "Confirmation", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MethodeNonImplantee(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non encore implémentée.",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void menuListe_Click(object sender, EventArgs e)
        {
            Manipulation_Listes f = new Manipulation_Listes();

            f.ShowDialog();
        }

        private void menuQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAPropos_Click(object sender, EventArgs e)
        {
            EcranAPropos f = new EcranAPropos();

            f.ShowDialog();
        }

        private void menuProgression_Click(object sender, EventArgs e)
        {
            EcranProgression f = new EcranProgression();
            f.ShowDialog();
        }

        private void malwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicMalware f = new FicMalware();
            f.ShowDialog();
        }

        private void menuEditeur_Click(object sender, EventArgs e)
        {
            FicEditeur f = new FicEditeur();
            f.Show();
            this.Hide();
        }

        private void Horloge_Click(object sender, EventArgs e)
        {
            EcranHorloge f = new EcranHorloge();
            f.Show();
            this.Hide();

        }

        private void ClavierSouris_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f = new EcranClavierSouris();
            f.Show();
            this.Hide();
        }

        private void btnFicExplorateur_Click(object sender, EventArgs e)
        {
            FicExplorateur f = new FicExplorateur();
            f.Show();
            this.Hide();
        }

        
        private void btnGPS_Click(object sender, EventArgs e)
        {
            ProjetGPS f = new ProjetGPS();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EcranBDDirect f = new EcranBDDirect();
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoutonColore f = new BoutonColore();
            f.Show();
            this.Hide();
        }

        private void btnDBLocalCouche_Click(object sender, EventArgs e)
        {
            DataAccessLayer f = new DataAccessLayer();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FicIntegration f = new FicIntegration();
            f.Show();
            this.Hide();
        }
    }
}
