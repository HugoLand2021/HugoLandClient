using Hugo_LAND.Core.Models;
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
