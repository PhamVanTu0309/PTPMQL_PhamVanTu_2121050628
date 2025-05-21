using Microsoft.EntityFrameworkCore;
using PTPMQL_PhamVanTu.Models;

namespace PTPMQL_PhamVanTu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
