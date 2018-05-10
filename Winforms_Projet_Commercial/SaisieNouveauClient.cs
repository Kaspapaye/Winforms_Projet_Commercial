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
    public partial class frmAjoutNouveauClient : Form
    {
        public frmAjoutNouveauClient()
        {
            InitializeComponent();
        }

        private void txtbNumeroClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // créer une référence d'objet MClient
            MClient nouveauClient = new MClient();

            try
            {
                // affecter les données de l'objet MClient :
                // variables simples, ou propriétés ce qui déclenche alors
                // le code des méthodes set
                //
                // conversion NumeroClient saisi en textbox vers le type integrer

                nouveauClient.NumeroClient = Int32.Parse(base.txtbNumeroClient.Text.Trim());

               /* // avec conversion en MAJ
                nouveauStagiaire.Nom = base.txtNom.Text;
                // avec conversion en min
                nouveauStagiaire.Prenom = base.txtPrenom.Text;
                nouveauStagiaire.Rue = base.txtAdresse.Text;
                // avec conversion en MAJ
                nouveauStagiaire.Ville = base.txtVille.Text;
                // avec controle de saisie
                nouveauStagiaire.CodePostal = base.txtCodePostal.Text.Trim(); */

                //ajouter la référence d'objet MClient dans la collection
                Donnees.ArrayStag.Add(nouveauClient); 
            }
            catch (Exception ex)
            {
                nouveauClient = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout d'un client");
            }
            /*// incrémentation compteur de stagiaires
            MClient.Nstag += 1; */

            // fermeture de la boite de dialogue par validation
            this.DialogResult = DialogResult.OK; 
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // fermeture de la boite de dialogue par abandon
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
