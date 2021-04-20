using System;
using System.Runtime.Serialization;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class MonsterDetailsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public int Niveau { get; set; }
        [DataMember]
        public int x { get; set; }
        [DataMember]
        public int y { get; set; }
        [DataMember]
        public int StatPV { get; set; }
        [DataMember]
        public float StatDmgMin { get; set; }
        [DataMember]
        public float StatDmgMax { get; set; }
        [DataMember]
        public Nullable<int> ImageId { get; set; }

    }
}
