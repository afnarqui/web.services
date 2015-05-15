using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Logica;
using WebApplication1.Negocio;

namespace WebApplication1.Fachada
{
    public class DatosFachada:IDatosFachada
    {

        /// <summary>
        /// ANDRES NARANJO 2015-05-15 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia() {
            return new CopiaLogica().BuscarDatosCopia().ToList();
        }
    }
}