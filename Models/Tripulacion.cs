using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Models
{
    public class Tripulacion
    {
    }

    public class AgregarTripulacionVuelo
    {
        public List<Persona> ListadoTripulacion { get; set; }
        public List<Persona> ListadoTripulacionAsignada { get; set; }
        public int idVuelo { get; set; }
    }
}
