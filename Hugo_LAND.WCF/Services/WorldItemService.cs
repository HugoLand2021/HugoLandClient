using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IWorldItemService
    {
        public ICollection<WorldItemDetailsDTO> ReturnWorldItems(int mondeId, int heroX, int heroY, int rayon)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                return context.Mondes.Find(mondeId)
                    .ObjetMondes
                    .Where(obj => Math.Abs(obj.x - heroX) < rayon && Math.Abs(obj.y - heroY) < rayon)
                    .Select(m => new WorldItemDetailsDTO
                    {
                        ID = m.Id,
                        Description = m.Description,
                        x = m.x,
                        y = m.y,
                        World = m.Monde.Id,
                        TypeObject = m.TypeObjet

                    })
                    .ToList();
            }
        }
    }
}
