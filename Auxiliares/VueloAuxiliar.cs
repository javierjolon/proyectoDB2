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
        public List<MisAsientos> ObtenerMisVuelos(string userId)
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select r.ID_Reserva, r.ID_Asiento_Vuelo, av.NO_Asiento, sa.ID_Status_Reserva, sa.Nombre status, ae1.Nombre aeo, ae2.Nombre aed " +
                "from Reserva r " +
                "left join Asiento_Vuelo av on r.ID_Asiento_Vuelo = av.ID_Asiento_Vuelo " +
                "left join Status_Reserva sa on r.ID_Status_Reserva = sa.ID_Status_Reserva " +
                "left join Vuelo v on av.ID_Vuelo = v.ID_Vuelo " +
                "left join Aeropuerto ae1 on v.ID_AeropuertoOrigen = ae1.ID_Aeropuerto " +
                "left join Aeropuerto ae2 on v.ID_AeropuertoDestino = ae2.ID_Aeropuerto " +
                "where r.ID_Persona = '"+ userId + "'";
            SqlDataReader reader = conexion.Conexion(query);

            List<MisAsientos> respuesta = new List<MisAsientos>();

            while (reader.Read())
            {
                MisAsientos misAsientos = new MisAsientos();
                misAsientos.IdReserva = int.Parse(reader["id_reserva"].ToString());
                misAsientos.IdAsientoVuelo = int.Parse(reader["id_asiento_vuelo"].ToString());
                misAsientos.NoAsiento = reader["no_asiento"].ToString();
                misAsientos.IdStatusReserva = int.Parse(reader["id_status_reserva"].ToString());
                misAsientos.Status = reader["status"].ToString();
                misAsientos.Origen = reader["aeo"].ToString();
                misAsientos.Destino = reader["aed"].ToString();
                respuesta.Add(misAsientos);
            }
            conexion.ConexionClose();
            return respuesta;
        }


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
