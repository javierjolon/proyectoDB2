using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Auxiliares
{
    public class ConexionAuxiliar
    {
        //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AerolineaABC;Integrated Security=True");
        SqlConnection conn = new SqlConnection("Server=tcp:areolineabc.database.windows.net,1433;Initial Catalog=AerolineaABC;Persist Security Info=False;User ID=AerolineaABC;Password=Prueba123#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public void ConexionOpen()
        {
            this.conn.Open();
        }  

        public SqlDataReader Conexion(string query)
        {
            ConexionOpen();
            SqlCommand comando = new SqlCommand(query, conn);
            SqlDataReader reader;
            reader = comando.ExecuteReader();
            return reader;
        }

        public void ConexionClose()
        {
            this.conn.Close();

        }

        public string conexionString()
        {
            return "Server=tcp:areolineabc.database.windows.net,1433;Initial Catalog=AerolineaABC;Persist Security Info=False;User ID=AerolineaABC;Password=Prueba123#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
    }
}
