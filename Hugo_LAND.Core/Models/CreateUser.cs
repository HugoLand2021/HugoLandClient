using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Core.Models
{
    public class CreateUser
    {
        public string NomJoueur { get; set; }
        public string Courriel { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public TypeUtilisateur TypeUtilisateur { get; set; }
        public string MotDePasse { get; set; }
        public string MotDePasseConfirmation { get; set; }

    }
}
