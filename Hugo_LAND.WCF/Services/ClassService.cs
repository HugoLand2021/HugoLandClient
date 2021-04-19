using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IClassService
    {
        public async void CreerClasse(ClassDetailsDTO newClass, WorldItemDTO world)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monde monde = context.Mondes.Find(world.ID);
                var classe = new Classe()
                {
                    NomClasse = newClass.NomClasse,
                    Description = newClass.Description,
                    StatBaseStr = newClass.StatBaseStr,
                    StatBaseDex = newClass.StatBaseDex,
                    StatBaseInt = newClass.StatBaseInt,
                    StatBaseVitalite = newClass.StatBaseVitalite,
                    Monde = monde,
                };
                context.Entry(classe).State = EntityState.Added;
                await context.SaveChangesAsync();
                context.SaveChanges();
            }
        }

        public async void SupprimeClasse(ClassDetailsDTO dto)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                var classe = new Classe()
                {
                    Id = dto.Id,
                    NomClasse = dto.NomClasse
                };

                context.Entry(classe).State = EntityState.Deleted;
                await context.SaveChangesAsync();
                //context.Classes.Remove(context.Classes.Find(id));
                //context.SaveChanges();
            }
        }

        public static void ModifClasse(int id, string nom, string description, int str, int dex, int ints, int vit, int idMonde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Classe result = context.Classes.Find(id);
                Monde monde = context.Mondes.Find(idMonde);
                result.NomClasse = nom;
                result.Description = description;
                result.StatBaseStr = str;
                result.StatBaseDex = dex;
                result.StatBaseInt = ints;
                result.StatBaseVitalite = vit;
                result.Monde = monde;
                context.SaveChanges();
            }
        }
        public List<ClassDetailsDTO> GetClasse()
        {
            using (var context = new HugoLANDContext())
            {
                try
                {
                    return context.Classes
                    .Select(p => new ClassDetailsDTO
                    {
                        Id = p.Id,
                        NomClasse = p.NomClasse,
                        Description = p.Description,
                        StatBaseStr = p.StatBaseStr,
                        StatBaseDex = p.StatBaseDex,
                        StatBaseInt = p.StatBaseInt,
                        StatBaseVitalite = p.StatBaseVitalite

                    }).ToList();
                }
                catch 
                {
                    return null;
                }
                

            }
        }
        public ClassDetailsDTO GetClasseByName(string name) 
        {
            using (var context = new HugoLANDContext())
            {
                try
                {
                    return (ClassDetailsDTO)context.Classes
                       .Where(p => p.NomClasse == name);
                }
                catch
                {
                    return null;
                }
            }

        }

    }
}