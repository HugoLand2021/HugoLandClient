using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IHeroService
    {

        public bool CreateHero(HeroDetailsDTO dto)
        {
            try
            {
                using (var context = new HugoLANDContext())
                {
                    Monde monde = context.Mondes.First(m => m.Description == dto.World);
                    Classe classe = context.Classes.First(c => c.NomClasse == dto.Class);
                    CompteJoueur compteJoueur = context.CompteJoueurs.First(a => a.NomJoueur == dto.UserName);
                    var hero = new Hero
                    {
                        Niveau = 1,
                        Experience = 0,
                        x = 0,
                        y = 0,
                        StatStr = dto.StatStr,
                        StatDex = dto.StatDex,
                        StatReg = dto.StatReg,
                        StatVitalite = dto.StatVitality,
                        NomHero = dto.HeroName,
                        EstConnecte = false,
                        Classe = classe,
                        CompteJoueur = compteJoueur,
                        Monde = monde
                    };
                    context.Entry(hero).State = EntityState.Added;
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool DeleteHero(HeroDetailsDTO dto)
        {
            try
            {
                using (var context = new HugoLANDContext())
                {
                    var hero = context.Heros.Find(dto.Id);
                    context.Entry(hero).State = EntityState.Deleted;
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async void MoveHero(HeroDetailsDTO dto, int newX, int newY)
        {
            try
            {
                using (var context = new HugoLANDContext())
                {
                    var hero = context.Heros.Find(dto.Id);
                    hero.x = newX;
                    hero.y = newY;
                    await context.SaveChangesAsync();
                }
            }
            catch
            {

            }

        }
        public List<HeroDetailsDTO> ReturnHerosFromAccount(int idCompteJoueur)
        {
            try
            {
                using (var context = new HugoLANDContext())
                {
                    return context.CompteJoueurs.Find(idCompteJoueur)?.Heros
                        .Select(p => new HeroDetailsDTO
                        {
                            Id = p.Id,
                            Level = p.Niveau,
                            Experience = (int)p.Experience,
                            x = p.x,
                            y = p.y,
                            StatStr = p.StatStr,
                            StatDex = p.StatDex,
                            StatReg = p.StatReg,
                            StatVitality = p.StatVitalite,
                            HeroName = p.NomHero,
                            isConnected = p.EstConnecte,
                            World = p.Monde.Description,
                            Class = p.Classe.NomClasse
                        }).ToList();
                }
            }
            catch
            {
                return null;

            }
        }

        public HeroDetailsDTO ReturnHero(string idhero)
        {
            try
            {
                using (var context = new HugoLANDContext())
                {
                    return context.Heros
                        .Where(p => p.Id == Int32.Parse(idhero))
                        .Select(e => new HeroDetailsDTO
                        {
                            Id = e.Id
                        }).First();
                }
            }
            catch
            {
                return null;
            }

        }

        public string ConnectHero(bool isConnected, int idHero)
        {
            try
            {
                using (var context = new HugoLANDContext())
                {
                    context.Heros.Find(idHero).EstConnecte = isConnected;
                    context.SaveChanges();
                }
                return "SUCCESS";
            }
            catch
            {
                return "ERROR";
            }
        }

        public List<HeroDetailsDTO> ReturnHeroes(string world, int mapBeginX, int mapBeginY, int idHero)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {

                    return context.Mondes.First(w => w.Description == world)
                        .Heros
                        .Where(obj => ((obj.x >= mapBeginX) && (obj.x < mapBeginX + 8)) && ((obj.y >= mapBeginY) && (obj.y < mapBeginY + 8)) && obj.EstConnecte == true && obj.Id != idHero)
                        .Select(m => new HeroDetailsDTO
                        {
                            Id = m.Id,
                            x = m.x,
                            y = m.y,
                            StatDex = m.StatDex,
                            StatReg = m.StatReg,
                            StatStr = m.StatStr,
                            StatVitality = m.StatVitalite,
                            Class = m.Classe.NomClasse,
                            isConnected = m.EstConnecte,
                            Experience = (int)m.Experience,
                            HeroName = m.NomHero,
                            Level = m.Niveau,
                            UserName = m.CompteJoueur.Nom,
                            World = m.Monde.Description
                        }).ToList();
                }
            }
            catch
            {
                return null;
            }
        }


        public bool IsHeroConnected(string HeroName, int AccountID)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {
                    return context.Heros.Any(h => h.NomHero == HeroName && h.EstConnecte == true && h.CompteJoueur.Id == AccountID);
                }
            }
            catch
            {
                return false;
            }
        }

        public HeroDetailsDTO PicksUpItem(string itemType,int world, int X, int Y, HeroDetailsDTO hero, bool force = false)
        {
            //RESTE À VERIF C'EST QUOI LE TYPE d'ITEM !! SI DOIT BOOST LA VIE OU QUELQUE CHOSE
            //heros.StatVitalite = heros.StatVitalite + 10;

            using (var context = new HugoLANDContext())
            {
                Hero currHero;
                Item item;
                try
                {
                    currHero = context.Heros.Find(hero.Id);
                    item = context.Items.FirstOrDefault(i => i.x == X && i.y == Y && i.Monde.Id == world && i.Hero == null);
                    currHero.Items.Add(item);
                    item.Hero = currHero;
                    switch (itemType)
                    {
                        case "food":
                            hero.StatVitality += 10;
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    return hero; //DOES NOT PICK UP ITEM
                }

                int itr = force ? 5 : 1;
                var currVersion = currHero.RowVersion;
                do
                {
                    itr--;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (itr > 0)
                        {
                            var objContext = ((IObjectContextAdapter)context).ObjectContext;
                            objContext.Refresh(RefreshMode.ClientWins, currHero);
                            objContext.Refresh(RefreshMode.ClientWins, item);
                        }
                    }
                } while (itr > 0 && currVersion != currHero.RowVersion);

                return new HeroDetailsDTO()
                {
                    Id = currHero.Id,
                    Class = currHero.Classe.Description,
                    Level = currHero.Niveau,
                    Experience = (int)currHero.Experience,
                    x = currHero.x,
                    y = currHero.y,
                    StatStr = currHero.StatStr,
                    StatDex = currHero.StatDex,
                    StatReg = currHero.StatReg,
                    StatVitality = currHero.StatVitalite,
                    HeroName = currHero.NomHero,
                    isConnected = currHero.EstConnecte,
                    World = currHero.Monde.Description,
                    UserName = currHero.CompteJoueur.Nom
                };
            }
        }
    }
}
