using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class ItemDetailsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Nullable<int> x { get; set; }
        [DataMember]
        public Nullable<int> y { get; set; }
        [DataMember]
        public Nullable<int> ImageId { get; set; }
    }
}
