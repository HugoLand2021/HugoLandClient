using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IWorldService
    {
        public List<WorldItemDTO> GetAllWorldNames()
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                return context.Mondes
                    .Select(m => new WorldItemDTO
                    {
                        ID = m.Id,
                        Description = m.Description,
                    }).ToList();
            }
        }
        public WorldItemDTO GetWorldByName(string worldName)
        {
            using (var context = new HugoLANDContext())
            {
                try
                {
                    //Monde monde = context.Mondes.FirstOrDefault(p => p.Description == worldName);
                    //return monde;
                    return context.Mondes
                   .Where(p => p.Description.StartsWith(worldName))
                   .Select(p => new WorldItemDTO
                   {
                       ID = p.Id,
                       Description = p.Description
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
