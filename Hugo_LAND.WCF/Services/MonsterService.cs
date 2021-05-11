using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IMonsterService
    {
        public List<MonsterDetailsDTO> ReturnMonsters(string world, int mapBeginX, int mapBeginY)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {

                    return context.Mondes.First(w => w.Description == world)
                        .Monstres
                        .Where(obj => ((obj.x >= mapBeginX) && (obj.x < mapBeginX + 8)) && ((obj.y >= mapBeginY) && (obj.y < mapBeginY + 8)))
                        .Select(m => new MonsterDetailsDTO
                        {
                            Id = m.Id,
                            Nom = m.Nom,
                            x = m.x,
                            y = m.y,
                            ImageId = m.ImageId,
                            Niveau = m.Niveau,
                            StatDmgMax = m.StatDmgMax,
                            StatDmgMin = m.StatDmgMin,
                            StatPV = m.StatPV
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
