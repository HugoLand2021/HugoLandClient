using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IWorldService
    {
        public List<WorldDetailsDTO> GetAllWorldNames()
        {
            try
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
            catch
            {
                return null;
            }

        }
        public WorldDetailsDTO GetWorldByName(string worldName)
        {
            try
            {
                using (var context = new HugoLANDContext())
                {
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
            }
            catch
            {
                return null;
            }
        }

        public WorldDetailsDTO KillMonster(int idWorld, int x, int y)
        {
            return new WorldDetailsDTO();
        }
    }
}
