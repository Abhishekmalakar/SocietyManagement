using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocietyManagement.Models
{
    public class Details
    {
        public int SocietyId { get; set; }
        public string SocietyName { get; set; }
        public decimal? PayAmount { get; set; }
        public DateTime? Paydate { get; set; }
        public DateTime? Modifydate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public int Contect { get; set; }
        public string Address { get; set; }

    }
}
