using System.Runtime.Serialization;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class ClassDetailsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ClassName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int StatBaseStr { get; set; }
        [DataMember]
        public int StatBaseDex { get; set; }
        [DataMember]
        public int StatBaseReg { get; set; }
        [DataMember]
        public int StatBaseVitality { get; set; }


    }
}
