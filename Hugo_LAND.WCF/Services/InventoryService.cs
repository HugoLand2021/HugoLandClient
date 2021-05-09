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
        public InventoryDetailsDTO ReturnInventory(int idHero)
        {
            try
            {
                using (HugoLANDContext context = new HugoLANDContext())
                {
                    return (InventoryDetailsDTO)context.InventaireHeroes.Where(c => c.Hero.Id == idHero);
                }
            }
            catch
            {

                return null;
            }
        }
    }
}
