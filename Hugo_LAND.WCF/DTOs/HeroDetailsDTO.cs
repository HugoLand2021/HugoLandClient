using System.Runtime.Serialization;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class HeroDetailsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Level { get; set; }
        [DataMember]
        public int Experience { get; set; }
        [DataMember]
        public int x { get; set; }
        [DataMember]
        public int y { get; set; }
        [DataMember]
        public int StatStr { get; set; }
        [DataMember]
        public int StatDex { get; set; }
        [DataMember]
        public int StatReg { get; set; }
        [DataMember]
        public int StatVitality { get; set; }
        [DataMember]
        public string HeroName { get; set; }
        [DataMember]
        public bool isConnected { get; set; }
        [DataMember]
        public string World { get; set; }
        [DataMember]
        public string Class { get; set; }
        [DataMember]
        public string UserName { get; set; }

    }
}
