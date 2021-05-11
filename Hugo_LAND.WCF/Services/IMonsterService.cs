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
        [OperationContract]
        MonsterDetailsDTO ReplaceMonsterToBones(int X, int Y, int world, bool force = false);
        [OperationContract]
        int RemoveHealthMonster(MonsterDetailsDTO monster, int heroDamage, bool force = false);
    }
}
