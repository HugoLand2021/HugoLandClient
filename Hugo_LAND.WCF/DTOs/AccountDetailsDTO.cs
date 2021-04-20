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
        public string PlayerName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public TypeUtilisateur TypeUtilisateur { get; set; }
    }
}
