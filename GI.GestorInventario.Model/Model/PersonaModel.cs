namespace GI.GestorInventario.Model.Model
{
    /// Clase de la tabla  GI_Persona
    /// Developer; karina Cruz Francisco 
    /// Date : 30 de septiembre 2024
    public class PersonaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public DateTime FechaUltimaModificasion { get; set; }
    }
}
