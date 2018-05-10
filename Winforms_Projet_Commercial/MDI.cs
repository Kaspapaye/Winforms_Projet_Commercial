using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_projet_Commerciale
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }


        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Onglet Fenetres > Afficher > Liste des Clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeClients frmL; // déclare une instance du form
            frmL = new frmListeClients(); // instancie le form (ListeClients)
            frmL.MdiParent = this;
            frmL.Show(); // affiche le form (ListeClients) dans son conteneur (MDI)
        }

        /// <summary>
        /// Onglet Fichier > Nouveau > Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutNouveauClient frmS; // déclare une instance du form
            frmS = new frmAjoutNouveauClient(); // instancie le form (SaisieNouveauClient)
            frmS.MdiParent = this;
            frmS.Show(); // affiche le form (SaisieNouveauClient) dans son conteneur (MDI)
        }
    }
}
