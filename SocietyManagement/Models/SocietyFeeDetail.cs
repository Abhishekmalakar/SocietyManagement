using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SocietyManagement.Models
{
    public partial class SocietyFeeDetail
    {
        public SocietyFeeDetail()
        {
            UserDetails = new HashSet<UserDetails>();
        }

        public int SocietyId { get; set; }
        public string SocietyName { get; set; }
        public decimal? PayAmount { get; set; }
        public DateTime? Paydate { get; set; }
        public DateTime? Modifydate { get; set; }

        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
