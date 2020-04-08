using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ruiz
{
    public class Persona
    {
        public String DNI { get; set; }
        public String Norman { get; set; }
        public String Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Char Sexo { get; set; }
        public Domicilio domicilio { get; set; }
        public Telefono telefono { get; set; }
        public Correo correo { get; set; }
    }
}
