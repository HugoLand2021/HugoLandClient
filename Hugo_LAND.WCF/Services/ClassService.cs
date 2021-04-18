using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hugo_Land.WCF.DTOs;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IClassService
    {
        public async void CreerClasse(string nom, string description, int str, int dex, int ints, int vit, int idMonde)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                Monde monde = context.Mondes.Find(idMonde);
                var classe = new Classe()
                {
                    NomClasse = nom,
                    Description = description,
                    StatBaseStr = str,
                    StatBaseDex = dex,
                    StatBaseInt = ints,
                    StatBaseVitalite = vit,
                    Monde = monde
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
        }
        
    }
}