﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ruiz
{
    public class OrdenRetiro
    {
        public Int32 NumeroRemito { get; set; }
        public DateTime FechaRetiro { get; set; }
        public Lote NumeroLote { get; set; }
        public Operario operario { get; set; }
        public Estado estado { get; set; }        
    }
}
