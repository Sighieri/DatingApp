using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //Base
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        
        //Tabelas
        public DbSet<AppUser> Users { get; set; }
    }
}