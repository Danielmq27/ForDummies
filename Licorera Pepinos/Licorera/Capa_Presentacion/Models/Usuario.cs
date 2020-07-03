using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capa_Presentacion.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public int Telefono { get; set; }

        public DateTime FecNacimiento { get; set; }

        public string Email { get; set; }

        public string Pass { get; set; }

        public int IdRol { get; set; }
    }
}