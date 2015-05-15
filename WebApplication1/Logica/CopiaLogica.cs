using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Datos;
using WebApplication1.Negocio;

namespace WebApplication1.Logica
{
    internal  class CopiaLogica
    {
        /// <summary>
        ///  ANDRES NARANJO 2015-05-15 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia() {
            return new CopiaDatos().BuscarDatosCopia().ToList();
        }
    }
}