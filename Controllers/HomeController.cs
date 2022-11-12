using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using ProyectoDB2.Auxiliares;
using ProyectoDB2.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public IActionResult CancelarReserva(int userId, int idReserva)
        {
            try
            {
                ConexionAuxiliar conexionAuxiliar = new ConexionAuxiliar();
                //using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AerolineaABC;Integrated Security=True"))
                using (SqlConnection con = new SqlConnection(conexionAuxiliar.conexionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("uspCancelarReserva", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Reserva", SqlDbType.Int).Value = idReserva;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }

                return RedirectToAction("MisVuelos", "Home", new { userId = userId });
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                return View("Reservar");
                throw;
            }
        }

        public IActionResult ConfirmarReserva(int userId, int idReserva)
        {
            try
            {
                ConexionAuxiliar conexionAuxiliar = new ConexionAuxiliar();
                using (SqlConnection con = new SqlConnection(conexionAuxiliar.conexionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("SPConfirmarAsiento", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Reserva", SqlDbType.Int).Value = idReserva;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }

                return RedirectToAction("MisVuelos", "Home", new { userId = userId });
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                return RedirectToAction("MisVuelos", "Home", new { userId = userId });
                throw;
            }
        }

        public IActionResult VerVuelo()
        {
            return View();
        }

        public IActionResult MisVuelos(string userId)
        {
            VueloAuxiliar vueloAuxiliar = new VueloAuxiliar();
            List<MisAsientos> listado = vueloAuxiliar.ObtenerMisVuelos(userId);

            ViewData["userId"] = userId;
            return View(listado);
        }

        public IActionResult ReservarAsiento(string userId, string idAsientoVuelo, string idVuelo)
        {
            try
            {
                ConexionAuxiliar conexionAuxiliar = new ConexionAuxiliar();
                using (SqlConnection con = new SqlConnection(conexionAuxiliar.conexionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("SPReservaAsiento", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Asiento_Vuelo", SqlDbType.Int).Value = idAsientoVuelo;
                        cmd.Parameters.Add("@ID_Persona", SqlDbType.Int).Value = userId;
                        cmd.Parameters.Add("@HoraReserva", SqlDbType.DateTime).Value = DateTime.Now;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }

                return RedirectToAction("Reservar", "Home", new { id = idVuelo, userId = userId });
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                return View("Reservar");
                throw;
            }
        }

        public IActionResult Reservar(string id, string userId)
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

                ViewData["userId"] = userId;
                return View(respuesta);
            }
            catch (Exception e)
            {
                return View();
                throw;
            }
            
        }

        public IActionResult Index(int userId)
        {
            List<Vuelo> respuesta = new List<Vuelo>();
            try
            {
                VueloAuxiliar vueloAuxiliar = new VueloAuxiliar();
                respuesta = vueloAuxiliar.ObtenerVuelos();

                ViewData["userId"] = userId;
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
