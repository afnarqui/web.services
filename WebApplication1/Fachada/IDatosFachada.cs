using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace WebApplication1.Fachada
{

    [ServiceContract]
    interface IDatosFachada
    {
        [OperationContract]
        System.Collections.Generic.List<WebApplication1.Negocio.copia> BuscarDatosCopia(long cedula);

    }
}