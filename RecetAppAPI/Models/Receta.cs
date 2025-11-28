namespace RecetAppAPI.Models
{
    public class Receta
    {
        int recetaId;
        string recetaTitulo;
        string recetaDescripcion;
        int recetaTiempoPreparacion;
        string recetaDificultad;
        int recetaLikes;
        List<Paso> recetaPasos;
        List<Ingrediente> recetaIngredientes;
        List<Etiqueta> recetaEtiquetas;
        List<Comentario> recetaComentarios;

        public Receta(int recetaId, string recetaTitulo, string recetaDescripcion, int recetaTiempoPreparacion, string recetaDificultad, List<Paso> recetaPasos, List<Ingrediente> recetaIngredientes, List<Etiqueta> recetaEtiquetas)
        {
            this.recetaId = recetaId;
            this.recetaTitulo = recetaTitulo;
            this.recetaDescripcion = recetaDescripcion;
            this.recetaTiempoPreparacion = recetaTiempoPreparacion;
            this.recetaDificultad = recetaDificultad;
            this.recetaPasos = recetaPasos;
            this.recetaIngredientes = recetaIngredientes;
            this.recetaEtiquetas = recetaEtiquetas;
            recetaComentarios = new List<Comentario>();
            recetaLikes = 0;
        }

        public int RecetaId { get => recetaId; set => recetaId = value; }
        public string RecetaTitulo { get => recetaTitulo; set => recetaTitulo = value; }
        public string RecetaDescripcion { get => recetaDescripcion; set => recetaDescripcion = value; }
        public int RecetaTiempoPreparacion { get => recetaTiempoPreparacion; set => recetaTiempoPreparacion = value; }
        public string RecetaDificultad { get => recetaDificultad; set => recetaDificultad = value; }
        public int RecetaLikes { get => recetaLikes; set => recetaLikes = value; }
        public List<Paso> RecetaPasos { get => recetaPasos; set => recetaPasos = value; }
        public List<Ingrediente> RecetaIngredientes { get => recetaIngredientes; set => recetaIngredientes = value; }
        public List<Etiqueta> RecetaEtiquetas { get => recetaEtiquetas; set => recetaEtiquetas = value; }
        public List<Comentario> RecetaComentarios { get => recetaComentarios; set => recetaComentarios = value; }
    }
}
