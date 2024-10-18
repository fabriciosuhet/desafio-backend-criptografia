using desafio_criptografia.Entities;
using Microsoft.EntityFrameworkCore;

namespace desafio_criptografia.Infrastructure
{
    public class DesafioContext : DbContext
    {
        public DesafioContext(DbContextOptions<DesafioContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        
    }
}
