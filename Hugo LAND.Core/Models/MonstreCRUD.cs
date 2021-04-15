using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Core.Models
{
    public class MonstreCRUD
    {
        public static void CreerMonstre(Monstre monstre, int monde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monde m = context.Mondes.Find(monde);
                context.Monstres.Add(new Monstre()
                {
                    Nom = monstre.Nom,
                    Niveau = monstre.Niveau,
                    x = monstre.x,
                    y = monstre.y,
                    StatPV = monstre.StatPV,
                    StatDmgMin = monstre.StatDmgMin,
                    StatDmgMax = monstre.StatDmgMax,
                    ImageId= monstre.ImageId,
                    Monde = m
                });
                context.SaveChanges();
            }
        }
        public static void SupprimerMonstre(Monstre monstre)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.Monstres.Remove(context.Monstres.Find(monstre));
                context.SaveChanges();
            }
        }
        public static void ModifierMonstre(Monstre mons, int monde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monstre monstre = context.Monstres.Where(c => c.x == mons.x && c.y == mons.y && c.Monde.Id == monde).FirstOrDefault();
                monstre.ImageId = mons.ImageId;
                monstre.Monde = mons.Monde;
                monstre.Niveau = mons.Niveau;
                monstre.Nom = mons.Nom;
                monstre.StatDmgMax = mons.StatDmgMax;
                monstre.StatDmgMin = mons.StatDmgMin;
                monstre.StatPV = mons.StatPV;
                monstre.x = mons.x;
                monstre.y = mons.y;
                context.SaveChanges();
            }
        }
    }
}
