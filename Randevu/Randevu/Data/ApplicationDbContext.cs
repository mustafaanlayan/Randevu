using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Randevu.Data.Entity;

namespace Randevu.Data
{
    public class ApplicationDbContext:IdentityDbContext<AppUser,AppRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Appoitment> Appoitments { get; set; }
    }
}
