using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4_PrograQ2
{
    public partial class Manipulation_Listes : Form
    {
        private string NomFichier = "";
        private int compteurEncodage = 1;

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int smLire = 0x0199;  
        private const int smEcrire = 0x019A;
        public Manipulation_Listes()
        {
            InitializeComponent();
        }

        private void Activer(bool argument)
        {
           
            lbPersonne.Enabled = argument;
            bOuvrir.Enabled = argument;
            bEnregistrer.Enabled = argument;
            bAjouter.Enabled = argument;
            bSupprimer.Enabled = argument;

           
            gbDetail.Enabled = !argument;
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbNom.Clear();
            tbNom.Focus();
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            int indexSup = lbPersonne.SelectedIndex;
            if (indexSup != -1)
            {
                int valeurSupprimee = SendMessage(lbPersonne.Handle, smLire, indexSup, 0);
                lbPersonne.Items.RemoveAt(indexSup);

                // On parcourt le reste de la liste pour mettre à jour
                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    int valActuelle = SendMessage(lbPersonne.Handle, smLire, i, 0);
                    if (valActuelle > valeurSupprimee)
                    {
                        SendMessage(lbPersonne.Handle, smEcrire, i, valActuelle - 1);
                    }
                }
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNom.Text))
            {
                string ligne = tbNom.Text + " (" + cbQualite.Text + ")";

                int index = lbPersonne.Items.Add(ligne);

                SendMessage(lbPersonne.Handle, smEcrire, index, compteurEncodage);

                compteurEncodage++;
                Activer(true);
            }
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true); 
        }


        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            int index = lbPersonne.SelectedIndex;
            if (index != -1)
            {
                int donneeCachee = SendMessage(lbPersonne.Handle, smLire, index, 0);

                string texte = lbPersonne.SelectedItem.ToString();

                MessageBox.Show("Donnée : " + texte +
                                "\nIndex : " + index +
                                "\nDonnée cachée : " + donneeCachee);
            }
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                lbPersonne.Items.Clear();
                string[] lignes = File.ReadAllLines(ofdOuvrir.FileName);

                for (int i = 0; i < lignes.Length; i++)
                {
                    string[] parties = lignes[i].Split('#'); 
                    if (parties.Length == 2)
                    {
                        int index = lbPersonne.Items.Add(parties[0]); 
                        int numCaché = int.Parse(parties[1]);      
                        SendMessage(lbPersonne.Handle, smEcrire, index, numCaché);
                    }
                }
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfdEnregistrer.FileName))
                {
                    for (int i = 0; i < lbPersonne.Items.Count; i++)
                    {
                        // Lire la donnée cachée via l'API
                        int num = SendMessage(lbPersonne.Handle, smLire, i, 0);
                        // Ecrire : Texte de la ligne # Numéro
                        sw.WriteLine(lbPersonne.Items[i].ToString() + "#" + num);
                    }
                }
            }
        }

        private void bModifer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex != -1)
            {
                string texteActuel = lbPersonne.SelectedItem.ToString();
                tbNom.Text = texteActuel;

                Activer(false);
            }
        }

        private void Manipulation_Listes_Load(object sender, EventArgs e)
        {

        }
    }
}
