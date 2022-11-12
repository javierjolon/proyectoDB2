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
        public List<Asiento> ObtenerAsientosDeVueloReservados(string idVuelo)
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select v.ID_Vuelo, av.* " +
                "from vuelo v " +
                "left join asiento_vuelo av on v.ID_Vuelo = av.ID_Vuelo " +
                "where v.ID_Vuelo = "+idVuelo+" and av.ID_Estatus = 2 ";
            SqlDataReader reader = conexion.Conexion(query);

            List<Asiento> respuesta = new List<Asiento>();

            while (reader.Read())
            {
                Asiento asiento = new Asiento();
                asiento.Id = int.Parse(reader["id_asiento_vuelo"].ToString());
                asiento.NumeroAsiento = reader["no_asiento"].ToString();
                asiento.IdStatus = reader["id_estatus"].ToString();
                respuesta.Add(asiento);
            }
            conexion.ConexionClose();

            return respuesta;
        }

        public List<Asiento> ObtenerAsientosDeVuelo(string id)
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select av.ID_Asiento_Vuelo, av.NO_Asiento, sa.ID_Status_Asiento, sa.Nombre " +
                "from Asiento_Vuelo av " +
                "left join Status_Asiento sa on av.ID_Estatus = sa.ID_Status_Asiento " +
                "where av.ID_Vuelo = "+id+"";
            SqlDataReader reader = conexion.Conexion(query);

            List<Asiento> respuesta = new List<Asiento>();

            while (reader.Read())
            {
                Asiento asiento = new Asiento();
                asiento.Id = int.Parse(reader["ID_Asiento_Vuelo"].ToString());
                asiento.NumeroAsiento = reader["NO_Asiento"].ToString();
                asiento.IdStatus = reader["ID_Status_Asiento"].ToString();
                asiento.NombreStatus = reader["Nombre"].ToString();
                respuesta.Add(asiento);
            }
            conexion.ConexionClose();

            return respuesta;
        }
    }
}
