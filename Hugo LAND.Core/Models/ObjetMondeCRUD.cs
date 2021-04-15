using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Core.Models
{
    public static class ObjetMondeCRUD
    {
        public static void CreeObjetMonde(ObjetMonde om, int monde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monde m = context.Mondes.Find(monde);
                context.ObjetMondes.Add(new ObjetMonde
                {
                    x = om.x,
                    y = om.y,
                    Description = om.Description,
                    TypeObjet = om.TypeObjet,
                    Monde = m
                });
                context.SaveChanges();
            }
        }

        public static void SupprimeObjetMonde(ObjetMonde om, int monde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.ObjetMondes.Remove(context.ObjetMondes.Where(c => c.x == om.x && c.y == om.y && c.Monde.Id == monde)
                                                            .FirstOrDefault());
                context.SaveChanges();
            }

        }
        public static void ChangeDescriptionObjetMonde(ObjetMonde om, int monde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                ObjetMonde objetMonde = context.ObjetMondes.Where(c => c.x == om.x && c.y == om.y && c.Monde.Id == monde)
                                                            .FirstOrDefault();
                objetMonde.Description = om.Description;
                objetMonde.TypeObjet = om.TypeObjet;
                objetMonde.x = om.x;
                objetMonde.y = om.y;

                context.SaveChanges();
            }
        }
    }
}
