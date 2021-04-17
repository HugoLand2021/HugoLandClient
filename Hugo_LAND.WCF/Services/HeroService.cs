using Hugo_LAND.Core.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3Hugo_Land.WCF.DTOs;

namespace TP3Hugo_Land.WCF.Services
{
    public partial class HugoLandService : IHeroService
    {
        public async void CreeHero(int newNiveau, long newExperience, int newX, int newY, int newStatStr, int newStatDex,
            int newStatInt, int newStatVitalite, string newNomHero, bool newConnection, int idClasse, int idCompteJoueur,
              int idMonde)
        {
            using (var context = new HugoLANDContext())
            {
                Monde monde = context.Mondes.Find(idMonde);
                Classe classe = context.Classes.Find(idClasse);
                CompteJoueur compteJoueur = context.CompteJoueurs.Find(idCompteJoueur);
                var hero = new Hero
                {
                    Niveau = newNiveau,
                    Experience = newExperience,
                    x = newX,
                    y = newY,
                    StatStr = newStatStr,
                    StatDex = newStatDex,
                    StatInt = newStatInt,
                    StatVitalite = newStatVitalite,
                    NomHero = newNomHero,
                    EstConnecte = newConnection,
                    Classe = classe,
                    CompteJoueur = compteJoueur,
                    Monde = monde
                };
                context.Entry(hero).State = EntityState.Added;
                await context.SaveChangesAsync();

            }
        }


        public async void SupprimeHero(HeroDetailsDTO dto)
        {
            using (var context = new HugoLANDContext())
            {
                var hero = new Hero()
                {
                    Id = dto.Id,
                    NomHero = dto.NomHero
                };
                context.Entry(hero).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }
        public async void DeplaceHero(HeroDetailsDTO dto, int newX, int newY)
        {
            using (var context = new HugoLANDContext())
            {
                //Hero hero = context.Heros.Find(dto.Id);
                //hero.x = newX;
                //hero.y = newY;
                //context.SaveChanges();

                var hero = new Hero()
                {
                    Id = dto.Id,
                    x = newX,
                    y = newY
                };
                context.Entry(hero).State = EntityState.Modified;
                await context.SaveChangesAsync();


            }
        }
    }
}
