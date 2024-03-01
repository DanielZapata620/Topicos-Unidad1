using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Area_Perimetro_U1
{
    public class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area=>Base*Altura/2.0;
        public double Perimetro => Base + Altura + Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Base, 2));
    }
}
