using System.Runtime.Serialization;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class WorldDetailsDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int LimiteX { get; set; }
        [DataMember]
        public int LimiteY { get; set; }
    }
}
