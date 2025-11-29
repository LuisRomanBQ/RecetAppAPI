using Microsoft.EntityFrameworkCore;
using RecetAppAPI.Models;

namespace RecetAppAPI.Data
{
    public class RecetAppDbContext : DbContext
    {
        public RecetAppDbContext(DbContextOptions<RecetAppDbContext> options)
       : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Paso> Pasos { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<RecetaIngrediente> RecetaIngredientes { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<RecetaEtiqueta> RecetaEtiquetas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

    }
}
