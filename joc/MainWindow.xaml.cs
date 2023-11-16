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

namespace joc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Carta carta = new Carta();
        Ma ma = new Ma();
        Baralla baralla = new Baralla();

        public MainWindow()
        {
            InitializeComponent();
            baralla.Remena(); // !!!
        }

        private void Roba_Click(object sender, RoutedEventArgs e)
        {
            Image imatge = new Image();
            Carta c = baralla.Roba();
            imatge.Source = (ImageSource)FindResource(c.ClauImatge);


            stkBaralla.Children.Add(imatge);
        }
    }
}
