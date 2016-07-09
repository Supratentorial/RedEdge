using System.Collections.Generic;

namespace RedEdge.Common.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public ICollection<EmailAddress> EmailAddresses { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public PersonInfo PersonInfo { get; set; }
        public OrganisationInfo OrganisationInfo { get; set; }
    }
}
