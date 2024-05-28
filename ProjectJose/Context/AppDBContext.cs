using Microsoft.EntityFrameworkCore;
using ProjectJose.Models;

namespace ProjectJose.Context
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) 
        {
        }
        public DbSet<Personas> personas { get; set; }

    }
}
