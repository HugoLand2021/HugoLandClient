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
        void CreerClasse(ClassDetailsDTO newClass, WorldItemDTO world);
        [OperationContract]
        void DeleteClass(ClassDetailsDTO dto);
        [OperationContract]
        void SaveClass(ClassDetailsDTO dto);
        [OperationContract]
        ClassDetailsDTO GetClasseByName(string name);
    }
}
