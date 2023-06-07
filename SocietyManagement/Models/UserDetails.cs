using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SocietyManagement.Models
{
    public partial class UserDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public int Contect { get; set; }
        public string Address { get; set; }
        public int? SocietyId { get; set; }

        public virtual SocietyFeeDetail Society { get; set; }
    }
}
