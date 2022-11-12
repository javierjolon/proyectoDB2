using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Auxiliares
{
    public class ClienteAuxiliar
    {
        public bool GuardarClienteManual(string dpi, string email, string nombre, string apellido, DateTime fechaNacimiento, string telefono, int tipoPersona)
        {
            ConexionAuxiliar conexion = new ConexionAuxiliar();
            string query = "insert into Persona (DPI, FechaNacimiento, Email, Telefono, Nombre, Apellido, ID_Tipo_Persona) " +
                "values ('"+dpi+"','"+fechaNacimiento+"', '"+email+"', '"+telefono+"','"+nombre+"','"+apellido+"', "+tipoPersona+")";
            SqlDataReader reader = conexion.Conexion(query);

            return true;
        }
    }
}
