using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Area_Perimetro_U1
{
    public class Cuadrado
    {
        public double Lado { get; set; }
        public double Area => Lado * Lado;
        public double Perimetro => Lado * 4;
    }
}
