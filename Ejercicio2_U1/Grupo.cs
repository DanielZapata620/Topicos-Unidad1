using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejercicio2_U1
{
    public class Grupo : INotifyPropertyChanged
    {
        public ObservableCollection<Alumno> Alumnos { get; set; } = new();
        public event PropertyChangedEventHandler? PropertyChanged;
        public Alumno Alumno { get; set; }= new();
        public ICommand AgregarCommand {  get; set; }
        public ICommand EliminarCommand { get; set; }

        public Grupo()
        {
            Cargar();
            AgregarCommand = new RelayCommand<Alumno>(Agregar);
            EliminarCommand=new RelayCommand(Eliminar);
        }

        public void Agregar(Alumno? alumno)
        {
            if(alumno != null)
            {
                //var otro = new Alumno
                //{
                //    Carrera=alumno.Carrera,
                //    Nombre=alumno.Nombre,
                //    NumControl=alumno.NumControl,
                //};
            Alumnos.Add(alumno);
                Alumno = new();
                PropertyChanged?.Invoke(this, new(nameof(Alumno)));
            Guardar();
            }
        }

        public void Eliminar()
        {
            if(Alumno != null)
            {
                Alumnos.Remove(Alumno);
                Guardar();
            }
        }

        public void Guardar()
        {
            var json =JsonSerializer.Serialize(Alumnos);
            File.WriteAllText("alumnos.json", json);
        }
        public void Cargar()
        {
            if (File.Exists("alumnos.json"))
            {
                var json = File.ReadAllText("alumnos.json");
                var datos=JsonSerializer.Deserialize<ObservableCollection<Alumno>>(json);

                //Alumnos=datos<
                if (datos != null)
                {
                    foreach (var a in datos)
                    {
                        Alumnos.Add(a);
                    }
                }
            }
        }
    }
}
