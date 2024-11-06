namespace GI.GestorInventario.Model.Data
{
    public class PersonaData : IPersonaInteface
    {
        /// <summary>
        /// Permite actualizar 
        /// </summary>
        /// <returns></returns>
        /// <exeption cref="NotImplementedException"></exeption>
        public async Task<RespuestaBD> ActualizarPersona()
        {
            var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se Actualizo correctamente.";
            return respuesta;
        }
        /// <summary>
        /// Permite Agregar persona
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<RespuestaBD> AgregarPersona()
        {
            var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se agrego correctamente.";
            return respuesta;
        }
        /// <summary>
        /// permite consultar una persona
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<PersonaModel>> ConsultaEntrada(ParametrosEntrada param)
        {
            var lista = new List<PersonaModel>();
            lista.Add(new PersonaModel
            {
                Nombre = "Diego",
                ApellidoPaterno = "Garcia",
                ApellidoMaterno = "Gonzalez",
                Edad = 20
            });

            lista.Add(new PersonaModel
            {
                Nombre = "Flor",
                ApellidoPaterno = "Trujillo",
                ApellidoMaterno = "Trejo",
                Edad = 24
            });
            return lista;
        }

        /// <summary>
        /// permite eliminar una persona
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<RespuestaBD> EliminarPersona()
        {
            var respuesta = new RespuestaBD();
            respuesta.NumError = 1;
            respuesta.Mensaje = "El registro se Elimino correctamente.";
            return respuesta;
        }
        /// <summary>
        /// permite consultar una persona
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
       
        public async Task<List<Producto>> ConsultaProduct(Producto param)
        {
            var lista = new List<Producto>();
            lista.Add(new Producto
            {
                Nombre = "Diego",
                Precio = 10.00M,
                Categoria = "Gonzalez",
                Color = "Rojo",
                Stock = 8,
                FechaUltimaModificacion = DateTime.Now
              
         });
            return lista;

        }
    }
    
}

