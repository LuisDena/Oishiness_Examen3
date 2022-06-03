using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Oishiness.Models;

namespace Oishiness.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Platillo> Platillos { get; set; }
    }
}