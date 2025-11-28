namespace RecetAppAPI.Models
{
    public class Paso
    {
        int pasoId;
        int pasoNum;
        string pasoDescripcion;

        public Paso(int pasoId, int pasoNum, string pasoDescripcion)
        {
            this.pasoId = pasoId;
            this.pasoNum = pasoNum;
            this.pasoDescripcion = pasoDescripcion;
        }

        public int PasoId { get => pasoId; set => pasoId = value; }
        public int PasoNum { get => pasoNum; set => pasoNum = value; }
        public string PasoDescripcion { get => pasoDescripcion; set => pasoDescripcion = value; }
    }
}
