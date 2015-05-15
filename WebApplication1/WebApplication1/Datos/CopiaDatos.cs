using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Negocio;


namespace WebApplication1.Datos
{
    internal class CopiaDatos
    {
        /// <summary>
        /// ANDRES NARANJO 2015-05-15 devuelve una lista de la entidad copia
        /// </summary>
        /// <returns></returns>
        public List<copia> BuscarDatosCopia()
        {


            using (DatosopawebEntities bd = new DatosopawebEntities())
            {

                return bd.copias.ToList();

            }


        }



    }
}