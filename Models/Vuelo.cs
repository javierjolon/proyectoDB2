using System.Collections.Generic;

namespace ProyectoDB2.Models
{
    public class Vuelo
    {
        public int Id { get; set; }
        public string FechaEntrada { get; set; }
        public string FechaSalida { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Avion { get; set; }
        public string IdStatus { get; set; }
        public string Status { get; set; }
    }

    public class NuevoVuelo
    {
        public List<Avion> ListadoAviones { get; set; }
        public List<Aereopuerto> ListadoAereopuertos { get; set; }
    }
}
