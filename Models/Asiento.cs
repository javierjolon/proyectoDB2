using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Models
{
    public class Asiento
    {
        public int Id { get; set; }
        public string NumeroAsiento { get; set; }
        public string IdStatus { get; set; }
        public string NombreStatus { get; set; }
    }

    public class VueloYAsientos
    {
        public List<Asiento> listadoAsientos { get; set; }
        public Vuelo Vuelo { get; set; }
    }
}
