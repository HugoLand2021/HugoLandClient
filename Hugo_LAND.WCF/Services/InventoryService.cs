using Hugo_LAND.Core.Models;
using Hugo_LAND.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.Services
{
    public partial class HugoLandService : IInventoryService
    {
        public List<InventoryDetailsDTO> ReturnInventory(int idHero)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {
                    return context.InventaireHeroes.Where(c => c.Hero.Id == idHero)
                        .Select(m=> new InventoryDetailsDTO 
                        { 
                            Id = m.IdInventaireHero,
                            IdItem=m.Item.Id,
                            IdHero =m.Hero.Id
                        }).ToList();
                }
            }
            catch
            {

                return null;
            }
        }
        public List<InventoryDetailsDTO> ReturnObject(int idHero, int idItem)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {
                    return context.InventaireHeroes.Where(c => c.Hero.Id == idHero && c.Item.ImageId == idItem).Select(m => new InventoryDetailsDTO
                    {
                        Id = m.IdInventaireHero,
                        IdItem = m.Item.Id,
                        IdHero = m.Hero.Id
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
