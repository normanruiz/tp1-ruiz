using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ruiz
{
    public class Deposito
    {
        public String Denominacion { get; set; }
        public Encargado encargado { get; set; }
        public List<Pasillo> Pasillos { get; set; }
    }
}
