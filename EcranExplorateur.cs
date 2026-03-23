using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Labo4_PrograQ2
{
    public partial class FicExplorateur : Form
    {
        public FicExplorateur()
        {
            InitializeComponent();
        }

        private void tsaDetail_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.Details;
        }

        private void tsaPetitesIcones_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.SmallIcon;
        }

        private void tsaGrandesIcones_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.LargeIcon;
        }

        private void tsaListe_Click(object sender, EventArgs e)
        {
            lvFichiers.View = View.List;
        }

        private void FicExplorateur_Load(object sender, EventArgs e)
        {
            LireDisques();
        }

        private void LireDisques()

        {

            tvRepertoire.Nodes.Clear();


            TreeNode racine = new TreeNode("Poste de Travail");

            tvRepertoire.Nodes.Add(racine);



            // Récupération des lecteurs du PC

            foreach (string disque in Environment.GetLogicalDrives())

            {

                TreeNode nodeDisque = new TreeNode(disque);

                racine.Nodes.Add(nodeDisque);  
                LireRepertoires(disque, nodeDisque);

            }

            racine.Expand(); 
        }

        // 2. REMPLIR LE TREEVIEW (Dossiers)
        private void LireRepertoires(string chemin, TreeNode parent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(chemin);
                foreach (DirectoryInfo sousDossier in dir.GetDirectories())
                {
                    parent.Nodes.Add(new TreeNode(sousDossier.Name));
                }
            }
            catch {   }
        }

        // 3. QUAND ON CLIQUE SUR UN DOSSIER (TreeView)
        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // On reconstruit le chemin (ex: C:\Windows)
            // On enlève "Poste de Travail" du début pour avoir un vrai chemin
            string cheminNettoye = e.Node.FullPath.Replace("Poste de Travail\\", "");

            if (Directory.Exists(cheminNettoye))
            {
                slMessage.Text = "Dossier : " + cheminNettoye;
                LireFichiers(cheminNettoye);
            }
        }

        private void LireFichiers(string chemin)
        {
            lvFichiers.Items.Clear(); 
            DirectoryInfo dossier = new DirectoryInfo(chemin);

            try
            {
                foreach (FileInfo f in dossier.GetFiles())
                {
                    
                    ListViewItem ligne = new ListViewItem(f.Name);

                   
                    ligne.SubItems.Add((f.Length / 1024).ToString() + " Ko");
                    ligne.SubItems.Add(f.CreationTime.ToShortDateString());
                    ligne.SubItems.Add(f.LastWriteTime.ToShortDateString());

                    lvFichiers.Items.Add(ligne);
                }
            }
            catch { MessageBox.Show("Accès refusé !"); }
        }


        private void tsbQuitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

