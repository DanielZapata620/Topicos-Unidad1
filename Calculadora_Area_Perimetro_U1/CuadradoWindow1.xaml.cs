using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculadora_Area_Perimetro_U1
{
    /// <summary>
    /// Lógica de interacción para CuadradoWindow1.xaml
    /// </summary>
    public partial class CuadradoWindow1 : Window
    {
        public CuadradoWindow1()
        {
            InitializeComponent();
        }

        Cuadrado c = new();
        private void txtLado_TextChanged(object sender, TextChangedEventArgs e)
        {
            double.TryParse(txtLado.Text, out double lado);
            c.Lado = lado;
            txtArea.Text=c.Area.ToString("N2");
            txtPerimetro.Text = c.Perimetro.ToString("N2");
        }
    }
}
