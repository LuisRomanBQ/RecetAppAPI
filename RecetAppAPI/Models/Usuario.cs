using System.ComponentModel.DataAnnotations;

namespace RecetAppAPI.Models
{
    public class Usuario
    {
        public Usuario(string usuarioNombre, string usuarioCorreo, string usuarioContraseña, string? usuarioBiografia) : this()
        {
            UsuarioNombre = usuarioNombre;
            UsuarioCorreo = usuarioCorreo;
            UsuarioContraseña = usuarioContraseña;
            UsuarioBiografia = usuarioBiografia;
        }
        public Usuario()
        {
            RecetasPublicadas = new List<Receta>();
            Comentarios = new List<Comentario>();
            RecetasRealizadas = new List<Receta>();
        }

        [Key]
        public int UsuarioId { get; set; }
        [Required]
        public string UsuarioNombre { get; set; }
        [Required]
        public string UsuarioCorreo { get; set; }
        [Required]
        public string UsuarioContraseña { get; set; }
        public string? UsuarioBiografia { get; set; } = "";

        public List<Receta> RecetasPublicadas { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<Receta> RecetasRealizadas { get; set; }

    }
}
