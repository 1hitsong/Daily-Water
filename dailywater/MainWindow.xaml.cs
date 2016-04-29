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

namespace dailywater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Shapes.Rectangle waterGraph;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Drink(object sender, RoutedEventArgs e)
        {

            Thickness m = completionGraph.Margin;
            m.Top -= 10;
            completionGraph.Margin = m;
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        { 
            this.Close();
        }
    }
}
