using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using CefSharp.WinForms;
using CefSharp;

namespace Labo4_PrograQ2
{
    public partial class ProjetGPS : Form
    {
        public ChromiumWebBrowser browser;
        private SerialPort portGps;
        public ProjetGPS()
        {
            InitializeComponent();
            InitBrowser(); // On lance Chrome au démarrage
        }

        private void ProjetGPS_Load(object sender, EventArgs e)
        {
            cbPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        public void InitBrowser()
        {
            // Initialisation de Chrome
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            
            browser = new ChromiumWebBrowser("about:blank");
            pnlMap.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (cbPorts.SelectedItem == null) return;

            // Configuration du port
            portGps = new SerialPort(cbPorts.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
            portGps.DataReceived += PortGps_DataReceived;
            portGps.Open();
            btnOuvrir.Text = "Port Ouvert !";
        }

        private void PortGps_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            string trame = portGps.ReadLine();

            // On utilise Invoke car le port série travaille sur un autre "fil" (thread) que l'affichage
            this.Invoke(new MethodInvoker(delegate {
                txtGps.AppendText(trame + Environment.NewLine);
                AnalyserEtAfficher(trame);
            }));
        }

        private void AnalyserEtAfficher(string trame)
        {
            // On cherche la trame $GPGGA qui contient les coordonnées
            if (trame.Contains("$GPGGA"))
            {
                string[] data = trame.Split(',');
                if (data.Length > 6)
                {
                    // Récupération simplifiée de la Lat/Lon
                    string lat = data[3];
                    string lon = data[5];

                    // On charge Google Maps avec ces coordonnées
                   
                    string url = $"https://www.google.com/maps?q={lat},{lon}";
                    browser.Load(url);
                }
            }
        }
    }
}
