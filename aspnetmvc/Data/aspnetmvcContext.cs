using Microsoft.EntityFrameworkCore;

namespace aspnetmvc.Data
{
    public class aspnetmvcContext : DbContext
    {
        public aspnetmvcContext(DbContextOptions<aspnetmvcContext> options)
            : base(options)
        {
        }

        public DbSet<aspnetmvc.Models.Department> Department { get; set; }
    }
}
