namespace RecetAppAPI.Models
{
    public class Usuario
    {
        int usuarioId;
        string usuarioNombre;
        string usuarioCorreo;
        string usuarioContraseña;
        string usuarioBiografia;

        public int UsuarioId { get => usuarioId; set => usuarioId = value; }
        public string UsuarioNombre { get => usuarioNombre; set => usuarioNombre = value; }
        public string UsuarioCorreo { get => usuarioCorreo; set => usuarioCorreo = value; }
        public string UsuarioContraseña { get => usuarioContraseña; set => usuarioContraseña = value; }
        public string UsuarioBiografia { get => usuarioBiografia; set => usuarioBiografia = value; }

        public Usuario(int usuarioId, string usuarioNombre, string usuarioCorreo, string usuarioContraseña)
        {
            this.usuarioId = usuarioId;
            this.usuarioNombre = usuarioNombre;
            this.usuarioCorreo = usuarioCorreo;
            this.usuarioContraseña = usuarioContraseña;
        }
    }
}
