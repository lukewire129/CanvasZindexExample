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

namespace CanvasZindexExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent ();
        }

        private bool isZindex = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(isZindex)
            {
                Canvas.SetZIndex (front, 1);
                Canvas.SetZIndex (back, 0);
            }
            else
            {
                Canvas.SetZIndex (front, 0);
                Canvas.SetZIndex (back, 1);
            }

            isZindex = !isZindex;
        }
    }
}
