using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class InventoryDetailsDTO
    {
        [DataMember]
        public int IdInventory { get; set; }
        [DataMember]
        public int IdHero { get; set; }
        [DataMember]
        public int IdItem { get; set; }

    }
}
