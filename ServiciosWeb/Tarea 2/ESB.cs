using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class ESB
    {
        /*
         * public void SolicitarServicio(int id); -> Funcion que sirve para la solicitud de un nuevo servicio de Uber para el cliente.
         * int id -> ID del cliente que solicita el servicio
         */
        public static void SolicitarServicio(int id)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://localhost:53653");
            var request = clienteHttp.GetAsync("api/SolicitudDeServicio?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                Console.WriteLine(resultString);
                RecepcionSolicitudYAvisoPiloto(id);
            }
        }

        /*
         * public void RecepcionSolicitudYAvisoPiloto(int id); -> Funcion que sirve para la recepcion del servicio del cliente.
         * int id -> ID del cliente que solicita el servicio
         */
        public static String mensajePiloto = "";
        public static void RecepcionSolicitudYAvisoPiloto(int id)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://localhost:51523");
            var request = clienteHttp.GetAsync("api/RecepcionSolicitud").Result;

            if (request.IsSuccessStatusCode)
            {
                Console.Write("La solicitud del cliente a sido aprobada, se le asignara un piloto");
                var request2 = clienteHttp.GetAsync("api/AsignacionPiloto").Result;
                var resultString = request2.Content.ReadAsStringAsync().Result;
                Console.Write("El piloto asignado para realizar el servicio fue: " + resultString);
                mensajePiloto = "El Usuario Daniel requiere de su servicio";
                SolicitudUbicacion(id);
            }else{
                Console.Write("La solicitud del cliente a sido denegada");
            }
        }

        /*
         * public void SolicitudUbicacion(int id); -> Funcion que sirve para la solicitud de la ubicacion del carro.
         * int id_piloto -> ID del piloto
         */
        public static String mensajeClinte= "";
        public static void SolicitudUbicacion(int id_piloto)
        {
            HttpClient clienteHttp = new HttpClient();
            clienteHttp.BaseAddress = new Uri("http://localhost:50342");
            var request = clienteHttp.GetAsync("api/UbicacionCarro?id=" + id_piloto).Result;

            if (request.IsSuccessStatusCode)
            {
                var resultString = request.Content.ReadAsStringAsync().Result;
                mensajeClinte = "Su solicitud a sido aceptada, " + resultString;
            }
            else
            {
                Console.Write("La solicitud del cliente a sido denegada");
            }
        }
    }
}
