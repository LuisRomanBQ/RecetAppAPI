using System.ComponentModel.DataAnnotations.Schema;

namespace RecetAppAPI.Models
{
    public class RecetaEtiqueta
    {
        [ForeignKey("Receta")]
        public int RecetaId { get; set; }
        public Receta Receta { get; set; }
        [ForeignKey("Etiqueta")]
        public int EtiquetaId { get; set; }
        public Etiqueta Etiqueta { get; set; }

    }
}
