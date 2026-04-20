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
    public partial class DataAccessLayer : Form
    {
        public DataAccessLayer()
        {
            InitializeComponent();
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            try
            {
                // On appelle la couche DAL
                ClientDataAccessLayer dal = new ClientDataAccessLayer();

                // On récupère la liste des clients
                List<Client> maListe = dal.LireTout();

                // Mettre la liste sur le DataGridView
                dataGridView1.DataSource = maListe;

                //Pour que les colonnes prennent toute la place
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }
    }
}
