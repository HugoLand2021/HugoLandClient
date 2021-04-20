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
        public List<WorldDetailsDTO> GetAllWorldNames()
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                return context.Mondes
                    .Select(m => new WorldDetailsDTO
                    {
                        ID = m.Id,
                        Description = m.Description,
                        LimiteX = m.LimiteX,
                        LimiteY = m.LimiteY
                    }).ToList();
            }
        }
        public WorldDetailsDTO GetWorldByName(string worldName)
        {
            using (var context = new HugoLANDContext())
            {
                try
                {
                    //Monde monde = context.Mondes.FirstOrDefault(p => p.Description == worldName);
                    //return monde;
                    return context.Mondes
                   .Where(p => p.Description.StartsWith(worldName))
                   .Select(p => new WorldDetailsDTO
                   {
                       ID = p.Id,
                       Description = p.Description,
                       LimiteX = p.LimiteX,
                       LimiteY = p.LimiteY
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
