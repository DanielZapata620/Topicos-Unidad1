using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Area_Perimetro_U1
{
    public class Circulo:INotifyPropertyChanged
    {
        private double r;

        public double Radio
        {
            get { return r; }
            set { r = value;

                PropertyChanged?.Invoke(this, new(nameof(Area)));
                PropertyChanged?.Invoke(this, new(nameof(Perimetro)));
            }
        }

        public double Area=>Math.PI*Math.Pow(Radio,2);
        public double Perimetro=>2*Math.PI*Radio;

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
