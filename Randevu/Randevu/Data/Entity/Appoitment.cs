using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Randevu.Data.Entity
{
    public class Appoitment
    {
        public int Id { get; set; }
       
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string  personName { get; set; }
        public string  personSurname { get; set; }
        public string  Description { get; set; }

    }
}
