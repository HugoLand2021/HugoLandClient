using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace Hugo_LAND.WCF.Services
{
    [ServiceContract]
    public interface IInventoryService
    {
        [OperationContract]
        List<InventoryDetailsDTO> ReturnInventory(int idHero);
        [OperationContract]
        List<InventoryDetailsDTO> ReturnObject(int idHero, int idItem);
    }
}
