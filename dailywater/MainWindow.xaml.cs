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
        int goalOZ, amountDrunk, drinkOZ;
        double completionPercent, graphStep, graphTop;

        public MainWindow()
        {
            InitializeComponent();

            setDefaults();

        }

        private void setDefaults()
        {
            goalOZ = 120;
            drinkOZ = 20;
            amountDrunk = 0;
            completionPercent = 0;
            graphTop = 317;
            double step = graphTop / (goalOZ / drinkOZ);
            graphStep = Math.Round(step+1, 1);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void DrinkButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (graphTop > 0)
            {
                graphTop -= graphStep;
                Canvas.SetTop(completionGraph, graphTop);
            }

            if (graphTop <= 0)
            {
                TextBlock x = new TextBlock();
                x.Text = "You Did It!";
                x.Width = 200; ;
                x.FontSize = 50;
                page.Children.Add(x);
                Canvas.SetLeft(x, 20);
                Canvas.SetTop(x, 20);
                Canvas.SetZIndex(x, 5);
                success.Opacity = 1;
            }
        }

        private void Button_Drink(object sender, RoutedEventArgs e)
        {
            if (graphTop > 0)
            {
                graphTop -= graphStep;
                Canvas.SetTop(completionGraph, graphTop);
            }

            if (graphTop <=0)
            {
                TextBlock x = new TextBlock();
                x.Text = "You Did It!";
                x.Width = 200;;
                x.FontSize = 50;
                page.Children.Add(x);
                Canvas.SetLeft(x, 20);
                Canvas.SetTop(x, 20);
                Canvas.SetZIndex(x, 5);
            }

        }

        private void Button_Close(object sender, RoutedEventArgs e)
        { 
            this.Close();
        }

    }
}
