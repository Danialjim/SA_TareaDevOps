using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioDePiloto.Controllers
{
    public class AsignacionPilotoController : ApiController
    {
        /*
         * public int get(); Retorna el id del piloto que le fue asignado al cliente.
         * int id_piloto; Id del piloto simulado
         */
        [HttpGet]
        public int get()
        {
            var random = new Random();
            int id_piloto = random.Next(0, 10);
            return id_piloto;
        }
    }
}
