using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioDePiloto.Controllers
{
    public class RecepcionSolicitudController : ApiController
    {
        /*
         * public Boolean get(); Aprueba la solicitud del Servicio
         */
        [HttpGet]
        public Boolean get()
        {
            return true;
        }
    }
}
