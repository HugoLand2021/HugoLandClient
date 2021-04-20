﻿using Hugo_LAND.Core.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugo_LAND.WCF.DTOs;

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
                        StatInt = dto.StatInt,
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
                            Experience = p.Experience,
                            x = p.x,
                            y = p.y,
                            StatStr = p.StatStr,
                            StatDex = p.StatDex,
                            StatInt = p.StatInt,
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
    }
}
