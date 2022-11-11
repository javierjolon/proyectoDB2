using Microsoft.Data.SqlClient;
using ProyectoDB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Auxiliares
{
    public class AereopuertoAuxiliar
    {
        public List<Aereopuerto> ObtenerAereopuertos()
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select a.ID_Aeropuerto as id, a.Nombre as nombre , c.Nombre as ciudad, p.Nombre as pais " +
                "from Aeropuerto a " +
                "left join Ciudad c on a.ID_Ciudad = c.ID_Ciudad " +
                "left join Pais p on c.ID_Pais = p.ID_Pais";
            SqlDataReader reader = conexion.Conexion(query);

            List<Aereopuerto> respuesta = new List<Aereopuerto>();

            while (reader.Read())
            {
                Aereopuerto aereopuerto = new Aereopuerto();
                aereopuerto.Id = int.Parse(reader["id"].ToString());
                aereopuerto.Nombre = reader["nombre"].ToString();
                aereopuerto.Ciudad = reader["ciudad"].ToString();
                aereopuerto.Pais = reader["pais"].ToString();
                respuesta.Add(aereopuerto);
            }
            conexion.ConexionClose();

            return respuesta;
        }
    }
}
