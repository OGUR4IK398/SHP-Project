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

namespace TimeManagement
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Рисование осей Эффективности и времени
            int X0 = 10;
            int Y0 = 290;

            // OX
            Line line = new Line();
            line.Stroke = new SolidColorBrush(Colors.Black);
            line.X1 = X0;
            line.Y1 = Y0;
            line.X2 = 490;
            line.Y2 = Y0;
            line.StrokeThickness = 1;
            CNV.Children.Add(line);

            // OY
            Line line1 = new Line();
            line1.Stroke = new SolidColorBrush(Colors.Black);
            line1.X1 = X0;
            line1.Y1 = Y0;
            line1.X2 = X0;
            line1.Y2 = 10;
            line1.StrokeThickness = 1;
            CNV.Children.Add(line1);
            
            // Отметки на осях
            for (int i = 40; i <= 480; i += 40)
            {
                Line line2 = new Line();
                line2.Stroke = new SolidColorBrush(Colors.Black);
                line2.StrokeThickness = 1;
                line2.X1 = X0 + i;
                line2.Y1 = Y0 - 5;
                line2.X2 = X0 + i;
                line2.Y2 = Y0 + 5;
                CNV.Children.Add(line2);
            }
            for (int i = 40; i <= 280; i += 40)
            {
                Line line2 = new Line();
                line2.Stroke = new SolidColorBrush(Colors.Black);
                line2.StrokeThickness = 1;
                line2.X1 = X0 + 5;
                line2.Y1 = Y0 - i;
                line2.X2 = X0 - 5;
                line2.Y2 = Y0 - i;
                CNV.Children.Add(line2);
            }

            // Разметки оси эффективности
            for (int i = 15, dl = 40; i <= 105; i += 15, dl+=40)
            {
                Label s = new Label();
                s.Content = i.ToString() + "%";
                s.Margin = new Thickness(255, 280 - (dl - 5), 0, 0);
                grid.Children.Add(s);
            }

            //for (int i = )
        }

        private void Date_Click(object sender, RoutedEventArgs e)
        {
            int SD = Convert.ToInt32(StartDate.Text);
            int ED = Convert.ToInt32(EndDate.Text);
            for (int i = SD;i <= ED; i++)
            {
                Label s = new Label();
                if (i >= 10) { s.Content = i.ToString() + ".05"; }
                else { s.Content = "0" + i.ToString() + ".05"; }
                s.Margin = new Thickness(275 + 40 * (i - SD +  1), 300, 0, 0);
                grid.Children.Add(s);
            }
        }
    }
}
