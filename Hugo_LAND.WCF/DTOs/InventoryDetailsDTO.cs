using System.Runtime.Serialization;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class InventoryDetailsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdHero { get; set; }
        [DataMember]
        public int IdItem { get; set; }

    }
}
