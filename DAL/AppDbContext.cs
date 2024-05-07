using CRUD_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Razor.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public virtual DbSet<Product> Products{ get; set; }
    }
}
