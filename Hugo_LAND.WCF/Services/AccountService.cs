using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IAccountService
    {
        public string Authentification(string Username, string Password)
        {
            ObjectParameter message = new ObjectParameter("message", typeof(string));
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {
                    context.Connexion(Username, Password, message);
                }
            }
            catch
            {
                message.Value = "NETWORKERROR";
            }
            return (string)message.Value;
        }
        public AccountDetailsDTO GetAccountInfoByUsername(string username)
        {
            try
            {
                using (var context = new HugoLANDContext())
                {

                    CompteJoueur account = context.CompteJoueurs
                   .Where(p => p.NomJoueur == username)
                   .First();
                    AccountDetailsDTO a = new AccountDetailsDTO
                    {
                        Id = account.Id,
                        Email = account.Courriel,
                        LastName = account.Nom,
                        PlayerName = account.NomJoueur,
                        FirstName = account.Prenom,
                        TypeUtilisateur = account.TypeUtilisateur
                    };

                    return a;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
