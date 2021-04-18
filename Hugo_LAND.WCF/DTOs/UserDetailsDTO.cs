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
    public class UserDetailsDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string NomJoueur { get; set; }
        [DataMember]
        public string Courriel { get; set; }
        [DataMember]
        public string Prenom { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public TypeUtilisateur TypeUtilisateur { get; set; }
    }
}
