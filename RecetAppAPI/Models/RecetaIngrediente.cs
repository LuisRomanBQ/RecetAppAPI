using System.ComponentModel.DataAnnotations.Schema;

namespace RecetAppAPI.Models
{
    public class RecetaIngrediente
    {
        [ForeignKey("Receta")]
        public int RecetaId { get; set; }
        public Receta Receta { get; set; }
        [ForeignKey("Ingrediente")]
        public string IngredienteId { get; set; }
        Ingrediente Ingrediente { get; set; }
    }
}
