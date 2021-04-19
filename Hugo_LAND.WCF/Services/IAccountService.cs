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
    public interface IAccountService
    {
        [OperationContract]
        string Authentification(string Username, string Password);
        [OperationContract]
        AccountDetailsDTO GetAccountInfoByUsername(string username);
    }
}
