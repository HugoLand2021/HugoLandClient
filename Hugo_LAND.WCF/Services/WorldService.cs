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
        public Monde GetWorldByName(string worldName)
        {
            using (HugoLANDContext context = new HugoLANDContext())
            {
                return context.Mondes.FirstOrDefault(p => p.Description == worldName);
            }
        }

    }
}
