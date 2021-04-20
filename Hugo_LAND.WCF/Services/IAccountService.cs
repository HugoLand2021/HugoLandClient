using Hugo_LAND.WCF.DTOs;
using System.ServiceModel;

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
