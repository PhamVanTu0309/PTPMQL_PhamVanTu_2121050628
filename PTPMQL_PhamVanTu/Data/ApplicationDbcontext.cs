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
        public DbSet<PTPMQL_PhamVanTu.Models.Employee> Employee { get; set; } = default!;
    }
}
