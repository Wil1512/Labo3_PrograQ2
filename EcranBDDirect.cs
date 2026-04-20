using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo4_PrograQ2
{
    public partial class EcranBDDirect : Form
    {
        string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Kam-Computer\source\repos\Labo4_PrograQ2\perso.mdb";
        public EcranBDDirect()
        {
            InitializeComponent();
        }

        private void bConsulter_Click(object sender, EventArgs e)
        {
            lbConsole.Items.Clear();

            using (OleDbConnection cnx = new OleDbConnection(strConn))
            {
                string sql = "SELECT PRE, NOM, NUMCLI FROM Client";
                OleDbCommand cmd = new OleDbCommand(sql, cnx);
                cnx.Open();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lbConsole.Items.Add($"{rd["PRE"]} {rd["NOM"]} ({rd["NUMCLI"]})");
                }
            } 
        }

        // BOUTON DENOMBRER : Utilise ExecuteScalar()
        private void bDenombrer_Click(object sender, EventArgs e)
        {
            using (OleDbConnection cnx = new OleDbConnection(strConn))
            {
                string sql = "SELECT COUNT(*) FROM Client";
                OleDbCommand cmd = new OleDbCommand(sql, cnx);
                cnx.Open();
                int nb = (int)cmd.ExecuteScalar();
                lbConsole.Items.Add($"Nombre d'enregistrements : {nb}");
            }
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            using (OleDbConnection cnx = new OleDbConnection(strConn))
            {
                // On insère dans NOM et PRE
                string sql = "INSERT INTO Client (NOM, PRE) VALUES (?, ?)";
                OleDbCommand cmd = new OleDbCommand(sql, cnx);

                cmd.Parameters.AddWithValue("@nom", tbNom.Text);
                cmd.Parameters.AddWithValue("@pre", tbPrenom.Text);

                cnx.Open();
                cmd.ExecuteNonQuery();
                lbConsole.Items.Add($"Ajouté avec succès : {tbPrenom.Text} {tbNom.Text}");
            }
        }
    }
}
