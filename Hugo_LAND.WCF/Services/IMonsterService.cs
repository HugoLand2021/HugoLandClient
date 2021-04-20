using Hugo_LAND.WCF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.Services
{
    [ServiceContract]
    public interface IMonsterService
    {
        [OperationContract]
        List<MonsterDetailsDTO> ReturnMonsters(string world, int mapBeginX, int mapBeginY);

    }
}
