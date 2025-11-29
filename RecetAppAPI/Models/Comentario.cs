using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecetAppAPI.Models
{
    public class Comentario
    {
        public Comentario(string comentarioContenido) : this()
        {
            ComentarioContenido = comentarioContenido;
        }
        public Comentario()
        {
            ComentarioFecha = DateTime.Now;
        }
        [Key]
        public int ComentarioId { get; set; }
        [Required]
        public string ComentarioContenido { get; set; }
        public DateTime ComentarioFecha { get; set; }

        // FK Hacia Usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        //FK Hacia Receta
        public int RecetaId { get; set; }
        public Receta Receta { get; set; }

    }
}
