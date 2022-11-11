using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoDB2.Auxiliares;
using ProyectoDB2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult VerVuelo()
        {
            return View();
        }

        public IActionResult MisVuelos()
        {   
            return View();
        }

        public IActionResult Reservar(string id)
        {
            VueloYAsientos respuesta = new VueloYAsientos();

            try
            {
                AsientoAuxiliar asientoAsuxiliar = new AsientoAuxiliar();
                List<Asiento> listadoAsientos = new List<Asiento>();
                listadoAsientos = asientoAsuxiliar.ObtenerAsientosDeVuelo(id);
                respuesta.listadoAsientos = listadoAsientos;

                VueloAuxiliar vueloAuxiliar = new VueloAuxiliar();
                Vuelo listadoVuelo = new Vuelo();
                listadoVuelo = vueloAuxiliar.ObtenerVuelo(id);
                respuesta.Vuelo = listadoVuelo;

                return View(respuesta);
            }
            catch (Exception e)
            {
                return View();
                throw;
            }
            
        }

        public IActionResult Index()
        {
            List<Vuelo> respuesta = new List<Vuelo>();
            try
            {
                VueloAuxiliar vueloAuxiliar = new VueloAuxiliar();
                respuesta = vueloAuxiliar.ObtenerVuelos();
                return View(respuesta);
            }
            catch (Exception)
            {
                return View();
                throw;
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
