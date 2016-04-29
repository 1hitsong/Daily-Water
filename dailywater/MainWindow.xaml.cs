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
         
            waterGraph = new System.Windows.Shapes.Rectangle();
            waterGraph.Fill = new SolidColorBrush(Colors.CornflowerBlue);
            waterGraph.Width = 200;
            waterGraph.Height = 0;
            Canvas.SetLeft(waterGraph, 0);

            Canvas.SetTop(waterGraph, canvas.Height - waterGraph.Height);
            canvas.Children.Add(waterGraph);

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Drink(object sender, RoutedEventArgs e)
        {
            if (waterGraph.Height < canvas.Height)
            {
                waterGraph.Height += 20;
                Canvas.SetTop(waterGraph,canvas.Height - waterGraph.Height);
            }

            if (waterGraph.Height >= canvas.Height)
            {
                waterGraph.Height = canvas.Height;
                Canvas.SetTop(waterGraph, 0);

                TextBlock textBlock = new TextBlock();
                textBlock.Text = "You Did It!";
                textBlock.Width = 120;
                textBlock.Height = 240;
                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Foreground = new SolidColorBrush(Colors.Black);
                Canvas.SetLeft(textBlock, 0);
                Canvas.SetTop(textBlock, 0);
                canvas.Children.Add(textBlock);
            }
        }

        private void Button_Close(object sender, RoutedEventArgs e)
        { 
            this.Close();
        }
    }
}
