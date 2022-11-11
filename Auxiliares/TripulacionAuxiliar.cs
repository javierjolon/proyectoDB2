using Microsoft.Data.SqlClient;
using ProyectoDB2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Auxiliares
{
    public class TripulacionAuxiliar
    {
        public void GuardarTripulacionAsignada(int vueloId, int personaId)
        {

        }

        public List<Persona> ObtenerTripulacionAsiganda(int vueloId)
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select p.ID_Persona, p.Email, p.Nombre, p.Apellido, tp.Clasifiacion as puesto " +
                "from Bitacora b " +
                "left join Persona p on b.ID_Persona = p.ID_Persona " +
                "left join Tipo_Persona tp on p.ID_Tipo_Persona = tp.ID_Tipo_Persona " +
                "where b.ID_Vuelo = "+vueloId+" and tp.ID_Tipo_Persona != 3";
            SqlDataReader reader = conexion.Conexion(query);

            List<Persona> respuesta = new List<Persona>();

            while (reader.Read())
            {
                Persona persona = new Persona();
                persona.Id = int.Parse(reader["ID_Persona"].ToString());
                persona.Email = reader["Email"].ToString();
                persona.Nombre = reader["Nombre"].ToString();
                persona.Apellido = reader["Apellido"].ToString();
                persona.Tipo = reader["puesto"].ToString();
                respuesta.Add(persona);
            }
            conexion.ConexionClose();

            return respuesta;
        }

        public List<Persona> ObtenerTripulacion()
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "select p.ID_Persona, p.Email, p.Nombre, p.Apellido, tp.Clasifiacion as puesto " +
                "from Persona p " +
                "left join Tipo_Persona tp on p.ID_Tipo_Persona = tp.ID_Tipo_Persona " +
                "where tp.ID_Tipo_Persona != 3 " +
                "order by puesto desc";
            SqlDataReader reader = conexion.Conexion(query);

            List<Persona> respuesta = new List<Persona>();

            while (reader.Read())
            {
                Persona persona = new Persona();
                persona.Id = int.Parse(reader["ID_Persona"].ToString());
                persona.Email = reader["Email"].ToString();
                persona.Nombre = reader["Nombre"].ToString();
                persona.Apellido = reader["Apellido"].ToString();
                persona.Tipo = reader["puesto"].ToString();
                respuesta.Add(persona);
            }
            conexion.ConexionClose();

            return respuesta;
        }
    }
}
