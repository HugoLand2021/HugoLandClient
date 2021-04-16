using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : ICompteJoueurService
    {
        public string ConnexionUtilisateur(string NomUtilisateur, string MotDePasse)
        {
            return CompteJoueurCRUD.ValideJoueur(NomUtilisateur, MotDePasse);
        }
    }
}
