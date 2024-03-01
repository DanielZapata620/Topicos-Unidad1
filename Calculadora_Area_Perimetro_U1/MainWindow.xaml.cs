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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora_Area_Perimetro_U1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CuadradoWindow1 cw = new();
            cw.ShowDialog();
        }
        private void BtnRectangulo_Click(object sender, RoutedEventArgs e)
        {
            RectanguloWindow rw = new();
            rw.ShowDialog();
        }
        private void BtnCirculo_Click(object sender, RoutedEventArgs e)
        {
            CirculoWindow cw = new();
            cw.ShowDialog();
        }
        private void BtnTriangulo_Click(object sender, RoutedEventArgs e)
        {
            TriabguloWindow tw = new();
            tw.ShowDialog();
        }
    }
}
