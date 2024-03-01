using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_U1
{
    public enum Carreras { Sistemas,Mecatronica,Industrial}
    public class Alumno
    {
        public string NumControl { get; set; } = "";
        public string Nombre { get; set; } = "";

        public Carreras Carrera { get; set; }
    }
}
