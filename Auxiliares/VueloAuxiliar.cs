using Microsoft.Data.SqlClient;
using ProyectoDB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Auxiliares
{
    public class VueloAuxiliar
    {
        public List<Vuelo> ObtenerVuelos()
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select v.ID_Vuelo as id, v.FechaEntrada, v.FechaSalida, a.Nombre as origen, ae.Nombre as destino, av.Placa_Avion as avion, sv.Nombre as status, sv.ID_Status_Vuelo as idStatus " +
                "from Vuelo v " +
                "left join Aeropuerto a on v.ID_AeropuertoOrigen = a.ID_Aeropuerto " +
                "left join Aeropuerto ae on v.ID_AeropuertoDestino = ae.ID_Aeropuerto " +
                "left join Avion av on v.ID_Avion = av.ID_Avion " +
                "left join Status_Vuelo sv on v.ID_Status_Vuelo = sv.ID_Status_Vuelo";
            SqlDataReader reader = conexion.Conexion(query);

            List<Vuelo> respuesta = new List<Vuelo>();

            while (reader.Read())
            {
                Vuelo vuelo = new Vuelo();
                vuelo.Id = int.Parse(reader["id"].ToString());
                vuelo.FechaEntrada = reader["fechaentrada"].ToString();
                vuelo.FechaSalida = reader["fechasalida"].ToString();
                vuelo.Origen = reader["origen"].ToString();
                vuelo.Destino = reader["destino"].ToString();
                vuelo.Avion = reader["avion"].ToString();
                vuelo.Status = reader["status"].ToString();
                vuelo.IdStatus = reader["idstatus"].ToString();
                respuesta.Add(vuelo);
            }
            conexion.ConexionClose();
            return respuesta;
        }

        public Vuelo ObtenerVuelo(string id)
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select v.ID_Vuelo as id, v.FechaEntrada, v.FechaSalida, a.Nombre as origen, ae.Nombre as destino, av.Placa_Avion as avion, sv.Nombre as status, sv.ID_Status_Vuelo as idStatus " +
                "from Vuelo v " +
                "left join Aeropuerto a on v.ID_AeropuertoOrigen = a.ID_Aeropuerto " +
                "left join Aeropuerto ae on v.ID_AeropuertoDestino = ae.ID_Aeropuerto " +
                "left join Avion av on v.ID_Avion = av.ID_Avion " +
                "left join Status_Vuelo sv on v.ID_Status_Vuelo = sv.ID_Status_Vuelo " +
                "where v.ID_Vuelo = "+id+"";
            SqlDataReader reader = conexion.Conexion(query);

            Vuelo vuelo = new Vuelo();

            while (reader.Read())
            {
                vuelo.Id = int.Parse(reader["id"].ToString());
                vuelo.FechaEntrada = reader["fechaentrada"].ToString();
                vuelo.FechaSalida = reader["fechasalida"].ToString();
                vuelo.Origen = reader["origen"].ToString();
                vuelo.Destino = reader["destino"].ToString();
                vuelo.Avion = reader["avion"].ToString();
                vuelo.Status = reader["status"].ToString();
                vuelo.IdStatus = reader["idstatus"].ToString();
            }
            conexion.ConexionClose();
            return vuelo;
        }
    }
}
