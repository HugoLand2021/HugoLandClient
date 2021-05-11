using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace Hugo_LAND.WCF.Services
{
    [ServiceContract]
    public interface IWorldService
    {
        [OperationContract]
        List<WorldDetailsDTO> GetAllWorldNames();
        [OperationContract]
        WorldDetailsDTO GetWorldByName(string worldName);
        [OperationContract]
        WorldDetailsDTO KillMonster(int idWorld, int x, int y);

    }
}
