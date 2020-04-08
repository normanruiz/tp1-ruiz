using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ruiz
{
    public class Lado
    {
        public Char Nombre { get; set; }
        public Boolean Espacio { get; set; }
        public List<Compartimento> Compartimentos{ get; set; }
    }
}
