using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using Interface;
using System.Runtime.Remoting.Channels;
using UI;
namespace UI
{
    public partial class FrmConfiguration : Form
    {
        public static TcpChannel Garage = null;
        public static Interface.InterfaceUtilisateur ut;
        public FrmConfiguration(Interface.InterfaceUtilisateur utt)
        {
            InitializeComponent();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {

        }

        private void btntest_Click(object sender, EventArgs e)
        {
            string ip = txtip.Text;
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ip, 50);
                if (reply != null)
                {
                    if (reply.Status.ToString() == "Success")
                    {
                        lblstatut.Text = "Connection reussie";
                    }
                }
            }
            catch
            {
                lblstatut.Text = "ERROR: You have Some TIMEOUT issue";
            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            string ip = txtip.Text;
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ip, 10);
                if (reply != null)
                {
                    if (reply.Status.ToString() == "Success")
                    {

                        StreamWriter ecrire = new StreamWriter(@"C:\\Users\\" + Environment.UserName + "\\Documents\\configuration.config");
                        File.SetAttributes(@"C:\\Users\\" + Environment.UserName + "\\Documents\\configuration.config", File.GetAttributes(@"C:\\Users\\" + Environment.UserName + "\\Documents\\configuration.config") | FileAttributes.Hidden);
                        ecrire.Write(ip + ":1224");

                        ecrire.Flush();
                        ecrire.Close();
                        this.Hide();
                        FrmConnexion main = new FrmConnexion();
                        main.Show();

                    }
                }
                else
                {
                    lblstatut.Text = "Erreur de connection";
                }
            }
            catch
            {
                lblstatut.Text = "ERROR: You have Some TIMEOUT issue";
            }
        }

        private void FrmConfiguration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
