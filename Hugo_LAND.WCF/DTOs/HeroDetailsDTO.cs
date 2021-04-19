using Hugo_LAND.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class HeroDetailsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Niveau { get; set; }
        [DataMember]
        public long Experience { get; set; }
        [DataMember]
        public int x { get; set; }
        [DataMember]
        public int y { get; set; }
        [DataMember]
        public int StatStr { get; set; }
        [DataMember]
        public int StatDex { get; set; }
        [DataMember]
        public int StatInt { get; set; }
        [DataMember]
        public int StatVitalite { get; set; }
        [DataMember]
        public string NomHero { get; set; }
        [DataMember]
        public bool EstConnecte { get; set; }
        [DataMember]
        public string Monde { get; set; }
        [DataMember]
        public string Classe { get; set; }
        [DataMember]
        public string NomJoueur { get; set; }

    }
}
