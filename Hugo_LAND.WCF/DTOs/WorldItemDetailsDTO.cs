using System.Runtime.Serialization;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class WorldItemDetailsDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int x { get; set; }
        [DataMember]
        public int y { get; set; }
        [DataMember]
        public int TypeObject { get; set; }
        [DataMember]
        public int World { get; set; }
    }
}
