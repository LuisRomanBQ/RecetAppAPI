namespace RecetAppAPI.Models
{
    public class Comentario
    {
        int comentarioId;
        string comentarioContenido;
        DateTime comentarioFecha;

        public Comentario(int comentarioId, string comentarioContenido, DateTime comentarioFecha)
        {
            this.comentarioId = comentarioId;
            this.comentarioContenido = comentarioContenido;
            this.comentarioFecha = comentarioFecha;
        }

        public int ComentarioId { get => comentarioId; set => comentarioId = value; }
        public string ComentarioContenido { get => comentarioContenido; set => comentarioContenido = value; }
        public DateTime ComentarioFecha { get => comentarioFecha; set => comentarioFecha = value; }
    }
}
