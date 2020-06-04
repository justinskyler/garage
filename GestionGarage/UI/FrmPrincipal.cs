using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dal;
using Domaine;
using Controleur;

namespace UI
{
    public partial class FrmPrincipal : Form
    {
        public ControleurUtilisateurs ctu;
        public FrmPrincipal(ControleurUtilisateurs ctc)
        {
            InitializeComponent();
            ctu = ctc;
        }

        public static void CloseAll()
        {
            foreach (var form in Application.OpenForms.Cast<Form>().Where(f => f.IsMdiChild).ToArray())
                form.Close();
        }

        private void effectuerVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseAll();
            FrmVente vt = new FrmVente(ctu);
            vt.MdiParent = this;
            vt.Show();
        }

        private void annulerVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmVerifierStock vs = new FrmVerifierStock(ctu);
            vs.MdiParent = this;
            vs.Show();
        }

        private void listerPièceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmListerPiece lp = new FrmListerPiece(ctu);
            lp.MdiParent = this;
            lp.Show();
        }

        private void supprimerPieceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmSupprimerPiece sp = new FrmSupprimerPiece();
            sp.MdiParent = this;
            sp.Show();
        }

        private void aJouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmAjouterUtilisateur aj = new FrmAjouterUtilisateur(ctu);
            aj.MdiParent = this;
            aj.Show();
        }

        private void rechercherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmRechercherUtilisateur ru = new FrmRechercherUtilisateur(ctu);
            ru.MdiParent = this;
            ru.Show();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmListerUtilisateur lu = new FrmListerUtilisateur(ctu);
            lu.MdiParent = this;
            lu.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CloseAll();
            //FrmSupprimerUtilisateur su = new FrmSupprimerUtilisateur();
            //su.Show();
        }

        private void changerMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmModifierMotdePasse mp = new FrmModifierMotdePasse(ctu);
            mp.MdiParent = this;
            mp.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            LblStatut.Text = ctu.retournerPseudo() + " online " + DateTime.Now.Hour;
            //if (ctu.retournerFonction() == "AdminSys")
            //{
            //    effectuerVenteToolStripMenuItem.Visible = false;
            //}
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctu.Deconnexion(ctu.retournerPseudo());
            this.Close(); 

        }

        private void ajouterPieceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAll();
            FrmAjouterPiece aj = new FrmAjouterPiece(ctu);
            aj.MdiParent = this;
            aj.Show();
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctu.Deconnexion(ctu.retournerPseudo());
            autoPartsToolStripMenuItem.Visible = false;
            garageToolStripMenuItem.Visible = false;
            barRestoToolStripMenuItem.Visible = false;
            transfertToolStripMenuItem.Visible = false;
            utilisateursToolStripMenuItem.Visible = false;



        }
    }
}
