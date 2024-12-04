using Microsoft.EntityFrameworkCore;
using Test.models.entites;
 

namespace Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet <employee> Employees { get; set; }
    }
}
