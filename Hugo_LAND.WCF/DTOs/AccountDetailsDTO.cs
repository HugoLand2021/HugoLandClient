using Hugo_LAND.Core.Models;
using System.Runtime.Serialization;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class AccountDetailsDTO
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
