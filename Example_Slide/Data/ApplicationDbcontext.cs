using Microsoft.EntityFrameworkCore; 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks;
using Example_Slide.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    namespace Example_Slide.Data
    {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
                public DbSet<Person> Persons { get; set; } 
        }
    }
