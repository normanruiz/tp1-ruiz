using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ruiz
{
    public class Pasillo
    {
        public Int32 Numero { get; set; }
        public Boolean Espacio { get; set; }
        public List<Lado> Lados { get; set; }
    }
}
