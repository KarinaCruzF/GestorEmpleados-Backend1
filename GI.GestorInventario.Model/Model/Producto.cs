namespace GI.GestorInventario.Model.Model
{
    public class Producto
    {
       public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get ; set; }
        public string Color {  get; set; }
        public int Stock { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }


    }
}
