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
    public partial class frmListeClients : Form
    {
        public frmListeClients()
        {
            InitializeComponent();
        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            // instancie un form de saisie de client et l'affiche en modal
            frmAjoutNouveauClient frmAjout = new frmAjoutNouveauClient();
            // si on sort de la saisie par OK
            if (frmAjout.ShowDialog() == DialogResult.OK)
            {
                // régénère l'affichage du dataGridView
                afficheClients();
            }
        }

        private void afficheClients()
        {
            throw new NotImplementedException();
        }
    }
}
