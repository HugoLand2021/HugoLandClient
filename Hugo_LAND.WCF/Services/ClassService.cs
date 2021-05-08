using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IClassService
    {
        public bool CreateClass(ClassDetailsDTO newClass, WorldDetailsDTO world)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {
                    Monde monde = context.Mondes.Find(world.ID);
                    var classe = new Classe()
                    {
                        NomClasse = newClass.ClassName,
                        Description = newClass.Description,
                        StatBaseStr = newClass.StatBaseStr,
                        StatBaseDex = newClass.StatBaseDex,
                        StatBaseReg = newClass.StatBaseReg,
                        StatBaseVitalite = newClass.StatBaseVitality,
                        Monde = monde,
                    };
                    context.Entry(classe).State = EntityState.Added;
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteClass(ClassDetailsDTO dto)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {

                    var delClass = context.Classes.Find(dto.Id);
                    List<int> listDelHero = new List<int>();
                    List<int> listDelHeroItems = new List<int>();
                    List<int> listDelHeroInventaire = new List<int>();
                    foreach (Hero hero in delClass.Heros)
                    {
                        listDelHero.Add(hero.Id);
                        foreach (Item item in hero.Items)
                            listDelHeroItems.Add(item.Id);
                        foreach (InventaireHero inv in hero.InventaireHeroes)
                            listDelHeroInventaire.Add(inv.IdInventaireHero);
                    }
                    foreach (int id in listDelHeroItems)
                        context.Entry(context.Items.Find(id)).State = EntityState.Deleted;
                    foreach (int id in listDelHeroInventaire)
                        context.Entry(context.InventaireHeroes.Find(id)).State = EntityState.Deleted;
                    foreach (int id in listDelHero)
                        context.Entry(context.Heros.Find(id)).State = EntityState.Deleted;


                    context.Entry(delClass).State = EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool SaveClass(ClassDetailsDTO dto)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                try
                {
                    var currClass = new Classe()
                    {
                        Id = dto.Id,
                        NomClasse = dto.ClassName,
                        Description = dto.Description,
                        StatBaseStr = dto.StatBaseStr,
                        StatBaseDex = dto.StatBaseDex,
                        StatBaseReg = dto.StatBaseReg,
                        StatBaseVitalite = dto.StatBaseVitality,
                    };
                    context.Entry(currClass).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
        public List<ClassDetailsDTO> GetAllClasses()
        {
            using (var context = new HugoLANDContext())
            {
                try
                {
                    return context.Classes
                    .Select(p => new ClassDetailsDTO
                    {
                        Id = p.Id,
                        ClassName = p.NomClasse,
                        Description = p.Description,
                        StatBaseStr = p.StatBaseStr,
                        StatBaseDex = p.StatBaseDex,
                        StatBaseReg = p.StatBaseReg,
                        StatBaseVitality = p.StatBaseVitalite

                    }).ToList();
                }
                catch
                {
                    return null;
                }
            }
        }
        public ClassDetailsDTO GetClassByName(string name)
        {
            using (var context = new HugoLANDContext())
            {
                try
                {
                    return context.Classes
                   .Where(p => p.NomClasse.StartsWith(name))
                   .Select(p => new ClassDetailsDTO
                   {
                       Id = p.Id,
                       ClassName = p.NomClasse
                   }).FirstOrDefault();

                }
                catch
                {
                    return null;
                }
            }
        }
    }
}