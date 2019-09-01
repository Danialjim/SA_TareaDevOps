using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class SolicitudDeServicioController : ApiController
    {

        /*
         * public String get(int id); Permite realizar la solicitud del servicio de Uber
         * parametro int id : Indica el id del cliente registrado
         */
        [HttpGet]
        public String get(int id)
        {
            if (id == 1){
                return "El cliente Carlos esta pidiendo un servicio de Uber";
            }else if(id == 2){
                return "El cliente Daniel esta pidiendo un servicio de Uber";
            }else{
                return "El cliente Alonzo esta pidiendo un servicio de Uber";
            }
        }
        

    }
}
