using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class ClassDetailsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NomClasse { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int StatBaseStr { get; set; }
        [DataMember]
        public int StatBaseDex { get; set; }
        [DataMember]
        public int StatBaseInt { get; set; }
        [DataMember]
        public int StatBaseVitalite { get; set; }


    }
}
