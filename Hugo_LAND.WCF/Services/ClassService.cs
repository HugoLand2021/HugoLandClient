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
        public async void CreateClass(ClassDetailsDTO newClass, WorldItemDTO world)
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
            }
        }

        public void DeleteClass(ClassDetailsDTO dto)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {
                    var delClass = context.Classes.Find(dto.Id);
                    context.Entry(delClass).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch
            {
                //METTRREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE UNE EEEEEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRREEEEEEEEEEUUUUUUUUURRRRRRRR
            }
        }

        public void SaveClass(ClassDetailsDTO dto)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                try
                {
                    var currClass = new Classe()
                    {
                        Id = dto.Id,
                        NomClasse = dto.NomClasse,
                        Description = dto.Description,
                        StatBaseStr = dto.StatBaseStr,
                        StatBaseDex = dto.StatBaseDex,
                        StatBaseInt = dto.StatBaseInt,
                        StatBaseVitalite = dto.StatBaseVitalite,
                    };
                    context.Entry(currClass).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    //METTRREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE UNE EEEEEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRREEEEEEEEEEUUUUUUUUURRRRRRRR
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
                       NomClasse = p.NomClasse
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