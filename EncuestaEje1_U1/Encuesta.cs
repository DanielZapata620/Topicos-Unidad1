using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EncuestaEje1_U1
{
    public class Encuesta : INotifyPropertyChanged
    {
        public int VotosMarvel { get;private set; }
        public int VotosDC { get;private set; }
        public int VotosTotales => VotosDC + VotosMarvel;
        public double PorcentajeMarvel => VotosTotales==0?0:(double) VotosMarvel / VotosTotales * 100.0;
        public double PorcentajeDc=>VotosTotales==0?0:(double) VotosDC / VotosTotales * 100.0;

        public ICommand VotarCommmand{  get; set; }
        

        public Encuesta() 
        {
            VotarCommmand = new RelayCommand<string>(Votar);
        }
        public void Votar(string voto)
        {
            if (voto !=null)
            {
                if (voto == "Marvel")
                {
                    VotosMarvel++;
                    PropertyChanged?.Invoke(this, new(nameof(VotosMarvel)));
                }
                if (voto == "DC")
                {
                    VotosDC++;
                   
                    PropertyChanged?.Invoke(this, new(nameof(VotosMarvel)));
                }

               
                PropertyChanged?.Invoke(this, new(nameof(VotosTotales)));
                PropertyChanged?.Invoke(this, new(nameof(PorcentajeDc)));
                PropertyChanged?.Invoke(this, new(nameof(PorcentajeMarvel)));

                //ActuallizarTodo
                //PropetyChanged?.Invoke(this,new(null));
            }
        }

        
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
