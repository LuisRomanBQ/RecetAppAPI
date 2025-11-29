using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecetAppAPI.Models
{
    public class Ingrediente
    {
        public Ingrediente(string ingredienteNombre, double ingredienteCantidad, string ingredienteUnidad) : this()
        {
            IngredienteNombre = ingredienteNombre;
            IngredienteCantidad = ingredienteCantidad;
            IngredienteUnidad = ingredienteUnidad;
            IngredienteOpcional = false;
            IngredienteSustituto = null;
        }
        public Ingrediente()
        {
            RecetaIngredientes = new List<RecetaIngrediente>();
        }

        [Key]
        public int IngredienteId { get; set; }
        [Required]
        public string IngredienteNombre { get; set; }
        [Required]
        public double IngredienteCantidad { get; set; }
        [Required]
        public string IngredienteUnidad { get; set; }
        public bool? IngredienteOpcional { get; set; } = false;
        [ForeignKey("IngredienteSustituto")]
        public int? IngredienteSustitutoId { get; set; }
        public Ingrediente? IngredienteSustituto { get; set; } = null;

        public List<RecetaIngrediente> RecetaIngredientes { get; set; }



    }
}
