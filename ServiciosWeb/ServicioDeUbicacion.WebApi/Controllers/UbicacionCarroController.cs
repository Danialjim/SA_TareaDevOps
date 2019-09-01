using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioDeUbicacion.WebApi.Controllers
{
    public class UbicacionCarroController : ApiController
    {
        /*
         * public String get(int id); Devuelve la ubicacion del carro segun el id del piloto
         * parametro int id : Indica el id del piloto registrado
         */
        [HttpGet]
        public String get(int id)
        {
            var random = new Random();
            int calle = random.Next(0, 50);
            int avenida = random.Next(0, 50);
            int zona = random.Next(0, 25);

            return "la ubicacion del auto es : " + calle + " calle 13-53 zona " + zona + " Guatemala, Guatemala";
        }

    }
}
