using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Core.Models
{
    public static class CompteJoueursCRUD
    {
        public static string CreerJoueur(string nomJoueur, string courriel, string prenom, string nom, int typeUtilisateur, string mdp)
        {
            ObjectParameter message = new ObjectParameter("message", typeof(string));
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.CreerCompteJoueur(nomJoueur, courriel, prenom, nom, typeUtilisateur, mdp, message);
                context.SaveChanges();
                return (string)message.Value;
            }
        }

        public static void SupprimerJoueur(int id)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.CompteJoueurs.Remove(context.CompteJoueurs.Find(id));
                context.SaveChanges();
            }
        }

        public static string ModifCompteJoueur(int id, string nomJoueur, string courriel, string prenom, string nom, TypeUtilisateur typeUtilisateur, string mdp)
        {
            ObjectParameter message = new ObjectParameter("message", typeof(string));
            using (HugoLANDContext context = new HugoLANDContext())
            {
                CompteJoueur result = context.CompteJoueurs.Find(id);
                result.NomJoueur = nomJoueur;
                result.Courriel = courriel;
                result.Prenom = prenom;
                result.Nom = nom;
                result.TypeUtilisateur = typeUtilisateur;
                context.SaveChanges();
                context.ChangerMdp(result.NomJoueur, mdp, message);
            }
            return (string)message.Value;

        }

        public static string ValideJoueur(string nomJoueur, string mdp)
        {
            ObjectParameter message = new ObjectParameter("message", typeof(string));
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.Connexion(nomJoueur, mdp, message);
                return (string)message.Value;
            }
        }

        public static string ValideAdmin(string nomJoueur, string mdp)
        {
            ObjectParameter message = new ObjectParameter("message", typeof(string));
            using (HugoLANDContext context = new HugoLANDContext())
            {
                try {
                    if (context.CompteJoueurs.Where(c => c.NomJoueur == nomJoueur).FirstOrDefault().TypeUtilisateur != TypeUtilisateur.Admin)
                        return "INCORRECT";
                } catch {
                    return "INCORRECT";
                }

                context.Connexion(nomJoueur, mdp, message);
                return (string)message.Value;
            }
        }
    }
}
