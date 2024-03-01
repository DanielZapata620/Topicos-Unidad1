using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Area_Perimetro_U1
{
    public class Rectangulo:INotifyPropertyChanged
    {
        private double b;

        public double Base
        {
            get { return b; }
            set { b = value;

                PropertyChanged?.Invoke(this, new("Area"));
                PropertyChanged?.Invoke(this, new("Perimetro"));
            }
        }

        private double h;

        public double Altura
        {
            get { return h; }
            set { h = value; 
            
                PropertyChanged?.Invoke(this,new(null));
            }

            
        }


        public double Area => Base * Altura;
        public double Perimetro=>(Base*2)+Altura*2;

        public event PropertyChangedEventHandler? PropertyChanged;
    }
        
}
