using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace Hugo_LAND.WCF.Services
{
    [ServiceContract]
    public interface IMonsterService
    {
        [OperationContract]
        List<MonsterDetailsDTO> ReturnMonsters(string world, int mapBeginX, int mapBeginY);

    }
}
