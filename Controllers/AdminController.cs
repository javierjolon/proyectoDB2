using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProyectoDB2.Auxiliares;
using ProyectoDB2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Controllers
{
    public class AdminController : Controller
    {

        //fmreservaspordia
        public ActionResult GenerarInforme1(DateTime fecha)
        {
            //ConexionAuxiliar conexionAuxiliar = new ConexionAuxiliar();
            //using (var conn = new SqlConnection(conexionAuxiliar.conexionString()))
            //{
            //    if (conn.State != ConnectionState.Open)
            //        conn.Open();

            //    using (var cmd = new SqlCommand("fmreservaspordia", conn))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        SqlCommandBuilder.DeriveParameters(cmd);

                    
            //        cmd.Parameters.Add(fecha.Date);

            //        cmd.ExecuteNonQuery();
            //        var respuesta = cmd.Parameters["@RETURN_VALUE"].Value;
            //        string test = "";
            //    }
            //}
            return View();
            //try
            //{
            //    ConexionAuxiliar conexion = new ConexionAuxiliar();
            //    using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AerolineaABC;Integrated Security=True"))
            //    using (SqlConnection con = new SqlConnection(conexion.conexionString()))
            //    {
            //        using (SqlCommand cmd = new SqlCommand("uspInsertarCliente", con))
            //        {
            //            cmd.CommandType = CommandType.StoredProcedure;

            //            cmd.Parameters.Add("@opcion", SqlDbType.VarChar).Value = check;

            //            con.Open();
            //            cmd.ExecuteNonQuery();
            //        }
            //        con.Close();
            //    }
            //    return RedirectToAction("clientes");
            //}
            //catch (Exception e)
            //{
            //    string mensaje = e.Message;
            //    return View("clientes");
            //}
        }

        public ActionResult Informe1(DateTime fecha)
        {
            return View();
        }
        public ActionResult Informes()
        {
            return View();
        }

        public ActionResult CargarClientesPorArchivo(IFormFile formArchivo, string saltarRepetidos)
        {
            if (formArchivo == null)
            {
                //TempData["texto"] = "Seleccione un archivo excel";
                //TempData["color"] = "error";
                return RedirectToAction("clientes");
            }
            string check = "";
            if (saltarRepetidos == "1")
            {
                check = "1";
            }
            else
            {
                check = "2";
            }

            ClienteAuxiliar clienteAuxiliar = new ClienteAuxiliar();

            using (var stream = formArchivo.OpenReadStream())
            using (StreamReader sr = new StreamReader(stream))
            {
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DateTime fecha = DateTime.Parse(rows[1]);
                    int tipoPersona = int.Parse(rows[6]);


                    clienteAuxiliar.InsertarClientePorArchivo(rows[0], rows[2], rows[4], rows[5], fecha, rows[3], tipoPersona);
                }
            }

            try
            {
                ConexionAuxiliar conexion = new ConexionAuxiliar();
                //using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AerolineaABC;Integrated Security=True"))
                using (SqlConnection con = new SqlConnection(conexion.conexionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("uspInsertarCliente", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@opcion", SqlDbType.VarChar).Value = check;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                return RedirectToAction("clientes");
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                return View("clientes");
            }

        }


        public ActionResult GuardarClienteMAnual(string dpi, string email, string nombre, string apellido, string telefono, DateTime fechaNacimiento, int tipoPersona )
        {
            ClienteAuxiliar clienteAuxiliar = new ClienteAuxiliar();
            bool respuesta = clienteAuxiliar.GuardarClienteManual(dpi, email, nombre, apellido, fechaNacimiento, telefono, tipoPersona);
            return Redirect("Clientes");
        }
        
        public ActionResult Clientes()
        {
            try
            {
                TripulacionAuxiliar tripulacionAuxiliar = new TripulacionAuxiliar();
                List<Persona> personas = tripulacionAuxiliar.ObtenerTipoDePersona();
                return View(personas);
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                return View();
                throw;
            }
        }
        
        public ActionResult ConfirmarEliminacionDeVuelo(int idVuelo)
        {
            try
            {
                ConexionAuxiliar conexionAuxiliar = new ConexionAuxiliar();
                //using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AerolineaABC;Integrated Security=True"))
                using (SqlConnection con = new SqlConnection(conexionAuxiliar.conexionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("uspEliminarVuelo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Vuelo", SqlDbType.Int).Value = idVuelo;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                return RedirectToAction("Vuelos");
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                return View("AgregarTripulacionAVuelo");
            }
        }

        public ActionResult EliminarVuelo(int idVuelo)
        {
            VueloAuxiliar vueloAuxiliar = new VueloAuxiliar();
            Vuelo vuelo = vueloAuxiliar.ObtenerVuelo(idVuelo.ToString());

            AsientoAuxiliar asientoAuxiliar = new AsientoAuxiliar();
            List<Asiento> asientos = asientoAuxiliar.ObtenerAsientosDeVueloReservados(idVuelo.ToString());

            EliminarVuelo respuesta = new EliminarVuelo();
            respuesta.IdVuelo = idVuelo;
            respuesta.Vuelo = vuelo;
            respuesta.ListadoAsientos = asientos;

            return View(respuesta);
        }

        public ActionResult GuardarTripulacionAsignada(int vueloId, int personaId)
        {
            try
            {
                ConexionAuxiliar conexionAuxiliar = new ConexionAuxiliar();
                //using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AerolineaABC;Integrated Security=True"))
                using (SqlConnection con = new SqlConnection(conexionAuxiliar.conexionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("SPIngresarTripulacion", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Vuelo", SqlDbType.Int).Value = vueloId;
                        cmd.Parameters.Add("@ID_Persona", SqlDbType.Int).Value = personaId;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                return RedirectToAction("AgregarTripulacionAVuelo", new { idVuelo = vueloId });
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                return View("AgregarTripulacionAVuelo");
            }
            
        }

        public ActionResult AgregarTripulacionAVuelo(int idVuelo)
        {
            TripulacionAuxiliar auxiliar = new TripulacionAuxiliar();
            AgregarTripulacionVuelo respuesta = new AgregarTripulacionVuelo();
            respuesta.ListadoTripulacionAsignada = auxiliar.ObtenerTripulacionAsiganda(idVuelo);
            respuesta.ListadoTripulacion = auxiliar.ObtenerTripulacion();
            respuesta.idVuelo = idVuelo;

            return View(respuesta);
        }

        public ActionResult GuardarVuelo(string avion, string ciudadOrigen, string ciudadDestino, string fechaSalida, string horaSalida, string fechaLlegada, string horaLlegada, string checkEscala1, string es1, string es2, string es3)
        {
            int contador = 0;
            int tieneEscala = 0;
            if (checkEscala1 != null)
            {
                tieneEscala = 1;
            }

            try
            {
                int ees1 = 0;
                int ees2 = 0;
                int ees3 = 0;

                if (es1 != null)
                {
                    contador++;
                    ees1 = int.Parse(es1);
                }
                else
                {
                    if (es2 != null)
                    {
                        contador++;
                        ees2 = int.Parse(es2);
                    }
                    else
                    {
                        if (es3 != null)
                        {
                            contador++;
                            ees3 = int.Parse(es3);
                        }
                    }
                }

                var fechaO = DateTime.Parse(fechaSalida + " " + horaSalida);
                var fechaLl = DateTime.Parse(fechaLlegada + " " + horaLlegada);

                //using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AerolineaABC;Integrated Security=True"))
                ConexionAuxiliar conexionAuxiliar = new ConexionAuxiliar();
                using (SqlConnection con = new SqlConnection(conexionAuxiliar.conexionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("uspIngresoVuelo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@idaeropuertoO", SqlDbType.Int).Value = int.Parse(ciudadOrigen);
                        cmd.Parameters.Add("@idaeropuertoD", SqlDbType.Int).Value = int.Parse(ciudadDestino);
                        cmd.Parameters.Add("@idavion", SqlDbType.Int).Value = int.Parse(avion);
                        cmd.Parameters.Add("@fechaS", SqlDbType.DateTime).Value = fechaO;
                        cmd.Parameters.Add("@fechaE", SqlDbType.DateTime).Value = fechaLl;
                        cmd.Parameters.Add("@idescala", SqlDbType.Int).Value = contador;
                        cmd.Parameters.Add("@TieneEscala", SqlDbType.Int).Value = tieneEscala;
                        cmd.Parameters.Add("@Escala1", SqlDbType.Int).Value = ees1;
                        cmd.Parameters.Add("@Escala2", SqlDbType.Int).Value = ees2;
                        cmd.Parameters.Add("@Escala3", SqlDbType.Int).Value = ees3;

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                

                return RedirectToAction("Vuelos");
            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                
                return RedirectToAction("Vuelos");
                throw;
            }
            
        }

        public ActionResult AgregarVuelo()
        {
            try
            {
                AereopuertoAuxiliar aereopuertoAuxiliar = new AereopuertoAuxiliar();
                AvionesAuxiliar avionesAuxiliar = new AvionesAuxiliar();

                NuevoVuelo nuevoVuelo = new NuevoVuelo
                {
                    ListadoAereopuertos = aereopuertoAuxiliar.ObtenerAereopuertos(),
                    ListadoAviones = avionesAuxiliar.ObtenerAviones()
                };

                return View(nuevoVuelo);
            }
            catch (Exception e)
            {

                return View();
            }
        }

        public ActionResult Vuelos()
        {
            try
            {
                VueloAuxiliar vueloAuxiliar = new VueloAuxiliar();
                List<Vuelo> vuelos = vueloAuxiliar.ObtenerVuelos();
                return View(vuelos);
            }
            catch (Exception)
            {

                return View();
                throw;
            }
            
        }
        
        public ActionResult GuardarAereopuerto(string nombre, string pais)
        {
            return RedirectToAction("Aereopuertos");
        }
        
        public ActionResult Aereopuertos()
        {
            try
            {
                AereopuertoAuxiliar aereopuertoAuxiliar = new AereopuertoAuxiliar();
                List<Aereopuerto> aereopuertos = aereopuertoAuxiliar.ObtenerAereopuertos();
                return View(aereopuertos);
            }
            catch (Exception e)
            {
                return View();
                throw;
            }
            
        }

        public ActionResult GuardarTripulacion(string nombre, string puesto)
        {
            return RedirectToAction("Tripulacion");
        }

        public ActionResult Tripulacion()
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select p.*, tp.Clasifiacion as tipo from Persona p " +
                "left join Tipo_Persona tp on p.ID_Tipo_Persona = tp.ID_Tipo_Persona " +
                "where p.ID_Tipo_Persona != 3 " +
                "order by tipo desc";
            SqlDataReader reader = conexion.Conexion(query);

            List<Persona> respuesta = new List<Persona>();

            while (reader.Read())
            {
                Persona persona = new Persona();
                persona.Id = int.Parse(reader["id_persona"].ToString());
                persona.Dpi = reader["dpi"].ToString();
                persona.FechaNacimiento = reader["fechaNacimiento"].ToString();
                persona.Email = reader["email"].ToString();
                persona.Telefono = reader["telefono"].ToString();
                persona.Nombre = reader["nombre"].ToString();
                persona.Apellido = reader["apellido"].ToString();
                persona.Tipo = reader["tipo"].ToString();
                respuesta.Add(persona);
            }
            conexion.ConexionClose();

            return View(respuesta);
        }

        public ActionResult GuardarAvion(string tipoAvion, string capacidad)
        {
            return RedirectToAction("Aviones");
        }

        public ActionResult Aviones()
        {
            AvionesAuxiliar avionesAuxilar = new AvionesAuxiliar();

            List<Avion> respuesta = avionesAuxilar.ObtenerAviones();

            return View(respuesta);
        }
        
        public ActionResult Index()
        {
            List<Vuelo> respuesta = new List<Vuelo>();
            try
            {
                VueloAuxiliar vueloAuxiliar = new VueloAuxiliar();
                respuesta = vueloAuxiliar.ObtenerVuelos();
                return View("Views/Admin/Index.cshtml", respuesta);

            }
            catch (Exception)
            {
                return View("Views/Admin/Index.cshtml");
                throw;
            }

        }

    }
}
