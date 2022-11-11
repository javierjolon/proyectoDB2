using Microsoft.Data.SqlClient;
using ProyectoDB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Auxiliares
{
    public class AsientoAuxiliar
    {
        public List<Asiento> ObtenerAsientosDeVuelo(string id)
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select av.ID_Asiento_Vuelo as id, av.NO_Asiento as numeroAsiento, sa.ID_Status_Asiento idStatus, sa.Nombre nombreStatus " +
                "from Asiento_Vuelo av " +
                "left join Status_Asiento sa on av.ID_Estatus = sa.ID_Status_Asiento " +
                "where av.ID_Vuelo = "+id+"";
            SqlDataReader reader = conexion.Conexion(query);

            List<Asiento> respuesta = new List<Asiento>();

            while (reader.Read())
            {
                Asiento asiento = new Asiento();
                asiento.Id = int.Parse(reader["id"].ToString());
                asiento.NumeroAsiento = reader["numeroAsiento"].ToString();
                asiento.IdStatus = reader["idstatus"].ToString();
                asiento.NombreStatus = reader["nombrestatus"].ToString();
                respuesta.Add(asiento);
            }
            conexion.ConexionClose();

            return respuesta;
        }
    }
}
