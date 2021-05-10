using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IItemService
    {
        public List<ItemDetailsDTO> ReturnItems(string world, int mapBeginX, int mapBeginY)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {

                    return context.Mondes.First(w => w.Description == world)
                        .Items
                        .Where(obj => ((obj.x >= mapBeginX) && (obj.x < mapBeginX + 8)) && ((obj.y >= mapBeginY) && (obj.y < mapBeginY + 8)) && obj.Hero is null)
                        .Select(m => new ItemDetailsDTO
                        {
                            Id = m.Id,
                            Nom = m.Nom,
                            x = m.x,
                            y = m.y,
                            ImageId = m.ImageId,
                            Description = m.Description

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
