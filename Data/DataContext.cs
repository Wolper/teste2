using Microsoft.EntityFrameworkCore;
using Teste2.WebAPI.Models;

namespace Teste2.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Usuario> Usuarios { get; set; }
    }
}