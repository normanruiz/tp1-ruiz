using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ruiz
{
    public class Item
    {
        public Producto producto { get; set; }
        public Int32 Cantidad { get; set; }
        public Pasillo Ubicacion { get; set; }
    }
}