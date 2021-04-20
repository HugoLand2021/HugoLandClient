using Hugo_LAND.WCF.DTOs;
using System.Collections.Generic;
using System.ServiceModel;

namespace Hugo_LAND.WCF.Services
{
    [ServiceContract]
    public interface IClassService
    {
        [OperationContract]
        List<ClassDetailsDTO> GetAllClasses();

        [OperationContract]
        bool CreateClass(ClassDetailsDTO newClass, WorldDetailsDTO world);
        [OperationContract]
        bool DeleteClass(ClassDetailsDTO dto);
        [OperationContract]
        bool SaveClass(ClassDetailsDTO dto);
        [OperationContract]
        ClassDetailsDTO GetClassByName(string name);
    }
}
