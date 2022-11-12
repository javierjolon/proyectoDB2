using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoDB2.Models
{
    public class MisAsientos
    {
        public int IdReserva { get; set; }
        public int IdAsientoVuelo { get; set; }
        public string NoAsiento { get; set; }
        public int IdStatusReserva { get; set; }
        public string Status { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
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
