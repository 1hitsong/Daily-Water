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
        System.Windows.Shapes.Rectangle waterGraphBorder;
        System.Windows.Shapes.Rectangle waterGraph;

        public MainWindow()
        {
            InitializeComponent();

            
            waterGraphBorder = new System.Windows.Shapes.Rectangle();
            waterGraphBorder.Stroke = new SolidColorBrush(Colors.Gray);
            waterGraphBorder.Fill = new SolidColorBrush(Colors.White);
            waterGraphBorder.Width = 120;
            waterGraphBorder.Height = 240;
            Canvas.SetLeft(waterGraphBorder, 0);
            Canvas.SetTop(waterGraphBorder, 0);
            canvas.Children.Add(waterGraphBorder);

            
            waterGraph = new System.Windows.Shapes.Rectangle();
            waterGraph.Fill = new SolidColorBrush(Colors.CornflowerBlue);
            waterGraph.Width = 120;
            waterGraph.Height = 0;
            Canvas.SetLeft(waterGraph, 0);

            Canvas.SetTop(waterGraph, waterGraphBorder.Height - waterGraph.Height);
            canvas.Children.Add(waterGraph);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (waterGraph.Height < waterGraphBorder.Height)
            {
                waterGraph.Height += 40;
                Canvas.SetTop(waterGraph, waterGraphBorder.Height - waterGraph.Height);
            }

            if (waterGraph.Height == waterGraphBorder.Height)
            {
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
    }
}
