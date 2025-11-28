namespace RecetAppAPI.Models
{
    public class Etiqueta
    {
        int etiquetaId;
        string etiquetaNombre;

        public Etiqueta(int etiquetaId, string etiquetaNombre)
        {
            this.etiquetaId = etiquetaId;
            this.etiquetaNombre = etiquetaNombre;
        }

        public int EtiquetaId { get => etiquetaId; set => etiquetaId = value; }
        public string EtiquetaNombre { get => etiquetaNombre; set => etiquetaNombre = value; }
    }
}
