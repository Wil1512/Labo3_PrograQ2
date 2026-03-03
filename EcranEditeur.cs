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
    public partial class FicEditeur : Form
    {
        private string sFichier = ""; 
        private bool bModifier = false;
        public FicEditeur()
        {
            InitializeComponent();
            sFichier = "";
            bModifier = false;
            this.Text = "Nouvel éditeur";
        }

        private void FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
                {
                    sFichier = sfdEnregistrer.FileName;
                }
                else return; 
            }

            rtbTexte.SaveFile(sFichier, RichTextBoxStreamType.RichText);
            bModifier = false;
            this.Text = sFichier;
        }

        private bool VerifierSauver()
        {
            if (bModifier)
            {
                DialogResult reponse = MessageBox.Show("Voulez-vous enregistrer les modifications ?",
                                                       "Enregistrement", MessageBoxButtons.YesNoCancel);
                if (reponse == DialogResult.Yes)
                {
                    FichierEnregistrer();
                    return true;
                }
                return reponse == DialogResult.No; // Si Cancel, on renvoie false pour bloquer l'action
            }
            return true; // Pas de modif, on peut continuer
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private void grasItaliqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                Font oldFont = rtbTexte.SelectionFont;
                FontStyle newStyle;

                // On utilise XOR (^) pour inverser uniquement le bit "Bold"
                newStyle = oldFont.Style ^ FontStyle.Bold;

                rtbTexte.SelectionFont = new Font(oldFont, newStyle);
            }
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste();
        }

        private void italiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void soulignéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void barréToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, rtbTexte.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdPolice.ShowDialog() == DialogResult.OK)
            {
                rtbTexte.SelectionFont = fdPolice.Font;
            }
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VerifierSauver())
            {
                rtbTexte.Clear();
                sFichier = "";
                bModifier = false;
                this.Text = "Nouveau document";
            }
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VerifierSauver())
            {
                if (ofdOuvrir.ShowDialog() == DialogResult.OK)
                {
                    sFichier = ofdOuvrir.FileName;
                    rtbTexte.LoadFile(sFichier, RichTextBoxStreamType.RichText); // Charge le format RTF stylisé
                    bModifier = false;
                    this.Text = sFichier;
                }
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {
            if (VerifierSauver())
            {
                rtbTexte.Clear();
                sFichier = "";
                bModifier = false;
                this.Text = "Nouveau document";
            }
        }

        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void pbOuvrir_Click(object sender, EventArgs e)
        {
            if (VerifierSauver())
            {
                if (ofdOuvrir.ShowDialog() == DialogResult.OK)
                {
                    sFichier = ofdOuvrir.FileName;
                    rtbTexte.LoadFile(sFichier, RichTextBoxStreamType.RichText); // Charge le format RTF stylisé
                    bModifier = false;
                    this.Text = sFichier;
                }
            }
        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
