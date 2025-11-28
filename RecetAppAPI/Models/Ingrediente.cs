namespace RecetAppAPI.Models
{
    public class Ingrediente
    {
        int ingredienteId;
        string ingredienteNombre;
        double ingredienteCantidad;
        string ingredienteUnidad;
        bool ingredienteOpcional;
        Ingrediente ingredienteSustituto;

        public Ingrediente(int ingredienteId, string ingredienteNombre, double ingredienteCantidad, string ingredienteUnidad, bool ingredienteOpcional, Ingrediente ingredienteSustituto)
        {
            this.ingredienteId = ingredienteId;
            this.ingredienteNombre = ingredienteNombre;
            this.ingredienteCantidad = ingredienteCantidad;
            this.ingredienteUnidad = ingredienteUnidad;
            this.ingredienteOpcional = ingredienteOpcional;
            this.ingredienteSustituto = ingredienteSustituto;
        }

        public int IngredienteId { get => ingredienteId; set => ingredienteId = value; }
        public string IngredienteNombre { get => ingredienteNombre; set => ingredienteNombre = value; }
        public double IngredienteCantidad { get => ingredienteCantidad; set => ingredienteCantidad = value; }
        public string IngredienteUnidad { get => ingredienteUnidad; set => ingredienteUnidad = value; }
        public bool IngredienteOpcional { get => ingredienteOpcional; set => ingredienteOpcional = value; }
        public Ingrediente IngredienteSustituto { get => ingredienteSustituto; set => ingredienteSustituto = value; }
    }
}
