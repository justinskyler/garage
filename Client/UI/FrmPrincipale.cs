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
using Interface;

namespace UI
{
    public partial class FrmPrincipale : Form
    {
        public Interface.InterfaceUtilisateur ctu;
        public FrmPrincipale(Interface.InterfaceUtilisateur ctc)
        {
            InitializeComponent();
            ctu = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), Service.ServeurService.getConfiguration() + "tcp://localhost:1224/Utilisateurs");
        }


        public static void CloseAll()
        {
            foreach (var form in Application.OpenForms.Cast<Form>().Where(f => f.IsMdiChild).ToArray())
                form.Close();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctu.Deconnexion(ctu.retournerPseudo());
            venteToolStripMenuItem.Visible = false;
            stockToolStripMenuItem.Visible = false;
            pièceToolStripMenuItem.Visible = false;
            rapportToolStripMenuItem.Visible = false;
            utilisateurToolStripMenuItem.Visible = false;
            barRestaurantToolStripMenuItem.Visible = false;
            transfertToolStripMenuItem.Visible = false;
        }

        private void changerMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmModifierMotdePasse mp = new FrmModifierMotdePasse(ctu);
            mp.MdiParent = this;
            mp.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctu.Deconnexion(ctu.retournerPseudo());
            this.Close(); 
        }

        private void effectuerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmVente vt = new FrmVente(ctu);
            vt.MdiParent = this;
            vt.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmRechercherVente rv = new FrmRechercherVente(ctu);
            rv.MdiParent = this;
            rv.Show();
            
        }

        private void verifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmVerifierStock vs = new FrmVerifierStock(ctu);
            vs.MdiParent = this;
            vs.Show();
        }

        private void ajusterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmModifierPiece mp = new FrmModifierPiece(ctu);
            mp.MdiParent = this;
            mp.Show();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmAjouterPiece aj = new FrmAjouterPiece(ctu);
            aj.MdiParent = this;
            aj.Show();
        }

        private void rechercherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmRechercherPiece lp = new FrmRechercherPiece(ctu);
            lp.MdiParent = this;
            lp.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // FrmModifierPiece mp=new
        }

        private void listerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmListerPiece lp = new FrmListerPiece(ctu);
            lp.MdiParent = this;
            lp.Show();
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmRapport rp = new FrmRapport(ctu);
            rp.MdiParent = this;
            rp.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmAjouterUtilisateur aj = new FrmAjouterUtilisateur(ctu);
            aj.MdiParent = this;
            aj.Show();
        }

        private void rechercherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmRechercherUtilisateur ru = new FrmRechercherUtilisateur(ctu);
            ru.MdiParent = this;
            ru.Show();
        }

        private void modifierUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmModifierUtilisateur mu = new FrmModifierUtilisateur(ctu);
            mu.MdiParent = this;
            mu.Show();
        }

        private void bloquerDebloquerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmModifierEtat me = new FrmModifierEtat(ctu);
            me.MdiParent = this;
            me.Show();
        }

        private void listerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmListerUtilisateur lu = new FrmListerUtilisateur(ctu);
            lu.MdiParent = this;
            lu.Show();
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CloseAll();
            //FrmSupprimerUtilisateur su = new FrmSupprimerUtilisateur();
            //su.Show();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmListerVentes lv = new FrmListerVentes(ctu);
            lv.MdiParent = this;
            lv.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void FrmPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctu.Deconnexion(ctu.retournerPseudo());
        }

        private void rechercherTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmRechercherTranzaction rt = new FrmRechercherTranzaction(ctu);
            rt.MdiParent = this;
            rt.Show();
        }



    }
}
