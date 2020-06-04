using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Controleur;

namespace Serveur
{
    public partial class FrmServeur : Form
    {
        private static TcpChannel Garage ;
        public FrmServeur()
        {
            Garage = new TcpChannel(1224);
            ChannelServices.RegisterChannel(Garage);
            InitializeComponent();
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControleurUtilisateurs), "Utilisateurs", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControleurVehicule), "Vehicule", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControleurVente), "Vente", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControleurPieces), "Piece", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControleurTransaction), "Tranzaction", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControleurClient), "Client", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControleurServeur), "Serveur", WellKnownObjectMode.Singleton);
            
        }

        private void FrmServeur_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.notification.Icon = this.Icon;
            this.notification.BalloonTipTitle = "GARAGE"; // Titre du message.
            this.notification.BalloonTipText = "Serveur Demarré avec succès !!"; // Corps du message.

            this.notification.ShowBalloonTip(0); // On affiche le message indéfiniment.
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("----------------------------------------GARAGE--------------------------------------" +
                           " Programme réalise Guens," +
                           " Ingenieur Informaticien" +
                           " ---------------------------------------------------------------------------------------" +
                           "\n--------------------------------------------------------------------------------------" +
                           "\n--------------------------------------------------------------------------------------" +
                           "\n---------------------------------------------------------------------------------------");
        }

        private void redemarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
