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

namespace кальк
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        int gg = 0;
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            switch (fff.SelectedIndex)
            {
                case 0:
                    C.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(A.Text);
                        double b = Convert.ToDouble(B.Text);
                        C.Text = Convert.ToString(a + b);
                    }
                    catch
                    {
                        l1.Content = ("Введено неверное значение");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 1:
                    C.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(A.Text);
                        double b = Convert.ToDouble(B.Text);
                        C.Text = Convert.ToString(a - b);
                    }
                    catch
                    {
                        l1.Content = ("Введено неверное значение");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 2:
                    C.Text = "";
                    try
                    {
                        double a = Convert.ToDouble(A.Text);
                        double b = Convert.ToDouble(B.Text);
                        C.Text = Convert.ToString(Math.Round(a * b,4));
                    }
                    catch
                    {
                        l1.Content = ("Введено неверное значение");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 3:
                    C.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(A.Text);
                        double b = Convert.ToDouble(B.Text);
                        if (b == 0)
                        {
                            l1.Content = "На 0 делить нельзя";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                            C.Text = Convert.ToString(Math.Round(a / b,4));
                    }
                    catch
                    {
                        l1.Content = ("Введено неверное значение");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 4:
                    C.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(A.Text);
                        if (gg % 2 == 0)
                        {
                            l1.Content = "Невозможно работать с двумя числами";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                        {
                            a = Math.Sin(a);
                            C.Text = Convert.ToString(Math.Round(a, 1));
                        }
                    }
                    catch
                    {
                        l1.Content = ("Введено неверное значение");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 5:
                    C.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(A.Text);
                        if (gg % 2 == 0)
                        {
                            l1.Content = "Невозможно работать с двумя числами";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                        {
                            a = Math.Cos(a);
                            C.Text = Convert.ToString(Math.Round(a, 1));
                            l1.Content = "";
                        }
                    }
                    catch
                    {
                        l1.Content = ("Введено неверное значение");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 6:
                    C.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(A.Text);
                        if (gg % 2 == 0)
                        {
                            l1.Content = "Невозможно работать с двумя числами";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                        {
                            a = Math.Tan(a);
                            C.Text = Convert.ToString(Math.Round(a, 1));
                            l1.Content = "";
                        }
                    }
                    catch
                    {
                        l1.Content = ("Введено неверное значение");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
                case 7:
                    C.Text = "";
                    l1.Content = "";
                    try
                    {
                        double a = Convert.ToDouble(A.Text);
                        if (gg % 2 == 0)
                        {
                            l1.Content = "Невозможно работать с двумя числами";
                            l1.Foreground = Brushes.Red;
                        }
                        else
                        {
                            a = Math.Cos(a) / Math.Sin(a);
                            C.Text = Convert.ToString(Math.Round(a, 1));
                            l1.Content = "";
                        }
                    }
                    catch
                    {
                        l1.Content = ("Введено неверное значение");
                        l1.Foreground = Brushes.Red;
                    }
                    break;
            }
            
        }

        private void Prim_Click(object sender, RoutedEventArgs e)
        {
            if (gg % 2 == 0)
            {
                B.Visibility = Visibility.Hidden;
                B.Clear();
                gg += 1;
            }
               
            else
            { 
                B.Visibility = Visibility.Visible;
                gg += 1;
            }

        }

    }
}
