﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class WorldItemDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
