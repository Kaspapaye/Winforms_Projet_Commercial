using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_projet_Commerciale
{
    /// <summary>
    /// classe des Clients :
    /// permet de mémoriser les informations concernant un clients
    /// comporte des membres propriétés et attributs,
    /// donnée partagée par toutes les instances (==> static)
    /// </summary>
    public class MClient
    {
        /// <summary>
        /// obtient le numéro du client
        /// </summary>
        private Int32 numeroClient;

        /// <summary>
        /// numéro du Client,
        /// l'appelant devra prendre garde à passer un entier valide
        /// </summary>
        public Int32 NumeroClient
        {
            get { return numeroClient; }
            set { numeroClient = value; }
        }
    }
}
