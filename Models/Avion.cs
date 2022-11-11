using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Models
{
    public class TipoAvion
    {
        public int IdTipoAvion { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
    }

    public class Avion
    {
        public int IdAvion { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
    }
}
