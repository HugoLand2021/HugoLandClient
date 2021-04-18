using Hugo_LAND.Core.Models;
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
            using (HugoLANDContext context = new HugoLANDContext())
            {
                try
                {
                    context.Connexion(Username, Password, message);
                }
                catch
                {
                    message.Value = "NETWORKERROR";
                }
                return (string)message.Value;
            }
        }
        public int RetourneIdCompteParNom(string username)
        {
            using (var context = new HugoLANDContext())
            {
                return context.CompteJoueurs
                    .Where(p => p.NomJoueur == username)
                    .First().Id;
            }
        }
    }
}
