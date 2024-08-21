using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlMigracion.Models
{
    public class Viajero
    {
        public int IDViajero { get; set; }
        public string CedulaPasaporte { get; set; }
        public string Nombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
    }
}