namespace GI.GestorInventario.Model.inteface
{
    public interface IPersonaInteface
    {
        /// <summary>
        /// Este metodo permite Agregar Un Usuario
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> AgregarPersona();
        /// <summary>
        /// Este metodo permite actualizar un usuario 
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> ActualizarPersona();
        /// <summary>
        /// Este metodo permite eliminar un usuario 
        /// </summary>
        /// <returns></returns>
        Task<RespuestaBD> EliminarPersona();

        /// <summary>
        /// Este metodo permite elimnar un usuario 
        /// </summary>
        /// <returns></returns>
        Task<List<PersonaModel>> ConsultaEntrada(ParametrosEntrada param);

        /// <summary>
        /// Este metodo permite consultar producto  
        /// </summary>
        /// <returns></returns>
        Task<List<Producto>> ConsultaProduct(Producto param);
    }

}
