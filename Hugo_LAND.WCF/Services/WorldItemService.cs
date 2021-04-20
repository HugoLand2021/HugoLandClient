using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IWorldItemService
    {
        public List<WorldItemDetailsDTO> ReturnWorldItems(string world, int mapBeginX, int mapBeginY)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {

                    return context.Mondes.First(w => w.Description == world)
                        .ObjetMondes
                        .Where(obj => ((obj.x >= mapBeginX) && (obj.x < mapBeginX + 8)) && ((obj.y >= mapBeginY) && (obj.y < mapBeginY + 8)))
                        .Select(m => new WorldItemDetailsDTO
                        {
                            ID = m.Id,
                            Description = m.Description,
                            x = m.x,
                            y = m.y,
                            World = m.Monde.Id,
                            TypeObject = m.TypeObjet

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
