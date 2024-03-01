using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Panaderia
{
    public class Pan
    {
        public string NombrePan { get; set; }
        public byte CantidadDisponible { get; set; } = 20;
        public decimal Precio { get; set; }

        public string Imagen { get; set; }

        public byte CantidadComprar { get; set; } 


    }
}
