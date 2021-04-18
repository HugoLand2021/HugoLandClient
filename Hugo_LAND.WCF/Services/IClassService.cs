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
    public interface IClassService
    {
        [OperationContract]
        List<ClassDetailsDTO> GetClasse();

        [OperationContract]
        void CreerClasse(ClassDetailsDTO newClass, WorldItemDTO world);
        [OperationContract]
        void SupprimeClasse(ClassDetailsDTO dto);
    }
}
