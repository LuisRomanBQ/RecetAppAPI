using System.ComponentModel.DataAnnotations;

namespace RecetAppAPI.Models
{
    public class Etiqueta
    {
        public Etiqueta(string etiquetaNombre) : this()
        {
            EtiquetaNombre = etiquetaNombre;
        }
        public Etiqueta()
        {
            RecetaEtiquetas = new List<RecetaEtiqueta>();
        }
        [Key]
        public int EtiquetaId { get; set; }
        [Required]
        public string EtiquetaNombre { get; set; }
        //Relacion N:M
        public List<RecetaEtiqueta> RecetaEtiquetas { get; set; } 
    }
}
