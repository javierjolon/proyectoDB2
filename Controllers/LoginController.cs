using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ProyectoDB2.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult ValidarUsuario(string user, string password)
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select * from Persona where Email = '"+user+"'";
            SqlDataReader reader = conexion.Conexion(query);

            string pass = "";
            int userId = 0;
            while (reader.Read())
            {
                userId = int.Parse(reader["id_persona"].ToString());
                pass = reader["DPI"].ToString();
            }
            conexion.ConexionClose();


            if (pass == password)
            {
                return RedirectToAction("Index", "Home", new { userId = userId });
            }
            else
            {
                ViewData["status"] = "1";
                ViewData["message"] = "Usuario o contraseña no válidos";
                return View("Index");
            }
        }

        public ActionResult Index()
        {
            ViewData["status"] = "0";
            return View();
        }

        
    }
}
