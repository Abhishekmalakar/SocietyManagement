using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SocietyManagement.Models
{
    public partial class UserRegistration
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
    }
}
