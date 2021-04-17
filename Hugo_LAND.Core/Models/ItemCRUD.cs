using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.Core.Models
{
    public static class ItemCRUD
    {
        public static void CreerItem(Item item, int monde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monde m = context.Mondes.Find(monde);
                context.Items.Add(new Item()
                {
                    Nom = item.Nom,
                    Description = item.Description,
                    x = item.x,
                    y = item.y,
                    ImageId = item.ImageId,
                    Hero = item.Hero,
                    Monde = m
                }) ;
                context.SaveChanges();
            }
        }

        public static void RamasserItem(int idItem, int idHero)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Hero hero = context.Heros.Find(idHero);
                Item item = context.Items.Find(idItem);
                item.x = null;
                item.y = null;
                item.Hero = hero;
                hero.Items.Add(item);
                context.SaveChanges();
            }
        }

        public static void SupprimerItem(Item item)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                context.Items.Remove(context.Items.Find(item));
                context.SaveChanges();
            }
        }

        public static void ModifierQuantiteItem(int idItem, int idHero, int quantite, int monde) //On s'excuse 
        {
            if (quantite < 0)
                throw new Exception("ErreurQuantitéNégative");

            using (HugoLANDContext context = new HugoLANDContext())
            {
                Hero hero = context.Heros.Find(idHero);
                Item item = context.Items.Find(idItem);
                Monde m = context.Mondes.Find(monde);
                int nombreItems = hero.Items.Where(it => it.Nom == item.Nom && it.Hero.Id == idHero && it.Monde.Id == item.Monde.Id).Count();
                int nombreDiff = Math.Abs(quantite - nombreItems);
                if (nombreDiff > 0)
                {
                    if (nombreItems < quantite) //En ajouter
                    {
                        for (int i = 0; i < nombreDiff; i++)
                        {
                            CreerItem(new Item()
                            {
                                Nom = item.Nom,
                                Description = item.Description,
                                x = item.x,
                                y = item.y,
                                ImageId = item.ImageId,
                                Monde = m
                            },3);
                            RamasserItem(context.Items.ToList().LastOrDefault(it => it.Nom == item.Nom).Id, idHero);
                        }
                    }
                    else if (nombreItems > quantite)  // En retirer
                    {
                        for (int i = 0; i < nombreDiff; i++)
                        {
                            Item itemRemove = context.Items.ToList().LastOrDefault(it => it.Nom == item.Nom && it.Hero.Id == idHero && it.Monde.Id == item.Monde.Id);
                            hero.Items.Remove(itemRemove);
                            context.Items.Remove(context.Items.Find(itemRemove.Id));
                        }
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
