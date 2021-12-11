using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Randevu.Data.Entity
{
    public class AppUser:IdentityUser
    {
        public bool IsEmployee { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Color { get; set; }
        public List<Appoitment> Appoitments { get; set; }
    }
}
