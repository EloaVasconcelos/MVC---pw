using Microsoft.EntityFrameworkCore;
using Projeto3ds.Models;

namespace Projeto3ds.Controllers
{
    public class AppDbContext:DbContext
    {
        // Programar
        //NÃO QUEBRAR ESSA LINHA DE JEITO NENHUM 
        // Essas classes serão mapeadas 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
        public DbSet <Categoria> Categoria { get; set; } 
        public DbSet <Lanche> lanche { get; set; }
         


    }
}
