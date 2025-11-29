using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecetAppAPI.Models
{
    public class Paso
    {
        public Paso(int pasoOrden, string pasoDescripcion) : this()
        {
            PasoOrden = pasoOrden;
            PasoDescripcion = pasoDescripcion;
        }
        public Paso()
        {

        }
        [Key]
        public int PasoId { get; set; }
        [Required]
        public int PasoOrden { get; set; }
        [Required]
        public string PasoDescripcion { get; set; }

        // FK Hacia Receta
        [ForeignKey("Receta")]
        public int RecetaId { get; set; }
        public Receta Receta { get; set; }

    }
}
