using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ruiz
{
    public class Lote
    {
        public String NumeroLote { get; set; }
        public Cliente cliente { get; set; }
        public List<Item> Articulos { get; set; }
    }
}
