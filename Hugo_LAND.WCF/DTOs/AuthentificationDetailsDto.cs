using System.Runtime.Serialization;

namespace Hugo_LAND.WCF.DTOs
{
    [DataContract]
    public class AuthentificationDetailsDTO
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
