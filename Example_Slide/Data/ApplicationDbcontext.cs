using Microsoft.EntityFrameworkCore; 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;
using Example_Slide.Models; 

namespace Example_Slide.Data
{
  using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using VicemMVCIdentity.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>

      {
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
          {
          }

          public DbSet<Person> Persons { get; set; } 
            public DbSet<Example_Slide.Models.Employee> Employee { get; set; } = default!;
      }

}
