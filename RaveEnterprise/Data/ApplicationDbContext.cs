using Microsoft.EntityFrameworkCore;
using RaveEnterprise.Models;

namespace RaveEnterprise.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
            
        }
        public DbSet<Rave> Raves { get; set; }
    }
}
