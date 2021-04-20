using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace Hugo_LAND.WCF.Services
{
    [ServiceContract]
    public interface IWorldItemService
    {
        [OperationContract]
        List<WorldItemDetailsDTO> ReturnWorldItems(string world, int mapBeginX, int mapBeginY);
    }
}
