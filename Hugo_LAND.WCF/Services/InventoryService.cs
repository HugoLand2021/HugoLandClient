using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IInventoryService
    {
        public List<ItemDetailsDTO> GetPlayerInventory(int HeroID) {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {
                    return context.Items.Where(c => c.Hero.Id == HeroID).Select(m => new ItemDetailsDTO
                    {
                        Description = m.Description,
                        Id = m.Id,
                        ImageId = m.ImageId,
                        Nom = m.Nom,
                        x = m.x,
                        y = m.y
                    }).ToList();
                }
            }
            catch
            {
                return null;
            }
        }


    }
}
