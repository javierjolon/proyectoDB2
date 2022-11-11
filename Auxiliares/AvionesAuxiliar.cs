using Microsoft.Data.SqlClient;
using ProyectoDB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Auxiliares
{
    public class AvionesAuxiliar
    {
        public List<Avion> ObtenerAviones()
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select a.ID_Avion as id, a.Placa_Avion as placa, a.modelo as modelo, ta.Nombre as tipo, ta.Capacidad as capacidad " +
                "from Avion a " +
                "left join Tipo_Avion ta on a.ID_Tipo_Avion = ta.ID_Tipo_Avion ";
            SqlDataReader reader = conexion.Conexion(query);

            List<Avion> respuesta = new List<Avion>();

            while (reader.Read())
            {
                Avion avion = new Avion();
                avion.IdAvion = int.Parse(reader["id"].ToString());
                avion.Placa = reader["placa"].ToString();
                avion.Modelo = reader["modelo"].ToString();
                avion.Tipo = reader["tipo"].ToString();
                avion.Capacidad = int.Parse(reader["capacidad"].ToString());
                respuesta.Add(avion);
            }
            conexion.ConexionClose();

            return respuesta;
        }
    }
}
