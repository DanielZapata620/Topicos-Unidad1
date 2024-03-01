using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PV_Panaderia
{
    public class PuntoVenta : INotifyPropertyChanged
    { 
    
        public event PropertyChangedEventHandler? PropertyChanged;
    

    public ObservableCollection<Pan> Panes { get; set; } = new();

        public string PanSeleccionado { get; set; }
        
        public decimal Total => (decimal)Panes.Sum(x => x.CantidadComprar * x.Precio);
        
        public string mensaje { get; set; }
        public List<Pan> ListaPanes { get; set; } = new()
        {
            new Pan
            {
                NombrePan="Concha",
                Precio=18.0m,
                Imagen="https://th.bing.com/th/id/R.bf70faf352cf9fe3000b90a366221ab2?rik=GZXUfheZwdEYBQ&pid=ImgRaw&r=0"
            },
              new Pan()
            {
                NombrePan="Dona",
                Precio=11.0m,
                Imagen="https://th.bing.com/th/id/OIP.0UQTM_GzQWdWS1iOKFbu-AAAAA?rs=1&pid=ImgDetMain"

            },
              new Pan()
              {
                  NombrePan="Cuernito",
                  Precio=10m,
                  Imagen="https://th.bing.com/th/id/OIP.-8Qko8b6VI6CDFG48x91iAHaEc?rs=1&pid=ImgDetMain"
              }
        };
        public ICommand AgregarCommand { get; set; }
        public ICommand EliminarCommand { get; set; }
        public ICommand PagarCommand { get; set; }

        public byte Cantidad { get; set; } =1;


        public PuntoVenta()
        {
            AgregarCommand = new RelayCommand<Pan>(Agregar);
            EliminarCommand = new RelayCommand<Pan>(Eliminar);
            PagarCommand=new RelayCommand(Pagar);
        }

       

        public void Agregar(Pan pan)
        {
            if (Cantidad <= pan.CantidadDisponible)
            {


                if (pan != null)
                {
                    
                    if (Panes.Contains(pan))
                    {
                        pan.CantidadDisponible -= Cantidad;
                        pan.CantidadComprar += Cantidad;
                        mensaje = "";

                    }
                    else
                    {
                        Panes.Add(pan);
                        pan.CantidadDisponible -= Cantidad;
                        pan.CantidadComprar += Cantidad;
                        mensaje = "";
                    }
                    PropertyChanged?.Invoke(this, new(nameof(Total)));
                    PropertyChanged?.Invoke(Panes, new(nameof(pan.CantidadComprar)));
                    PropertyChanged?.Invoke(this, new(nameof(mensaje)));

                }
               

            }
            else
                {
                    mensaje = "Lo sentimos pero no hay esa cantidad de tipo de pan disponible";
                    PropertyChanged?.Invoke(this, new(nameof(mensaje)));
                
                }
        }
        public void Pagar()
        {
            Panes.Clear();
            ListaPanes.Select(x => x.CantidadComprar = 0).ToList();
            ListaPanes.Select(x => x.CantidadDisponible = 20).ToList();
            PropertyChanged?.Invoke(this,new(nameof(Total)));


        }
        public void Eliminar(Pan pan)
        {
            if (pan != null)
            {
                pan.CantidadComprar=0;
                
                
                Panes.Remove(pan);
                PropertyChanged?.Invoke(this, new(nameof(Total)));
            }
        }
    }
}
