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

namespace neco
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a;
        int b;
        int[] pole = new int[100];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            a = random.Next(1, 100);
            b = random.Next(1, 100);
            txt1.Text = a.ToString() + ";" + b.ToString();

            pole[0] = 25;
            pole[50] = 75;
            for(int i = 0; i < pole.Length; i++)
            {
                pole[i] = random.Next(1, 100);
            }

            for (int i = 0; i < pole.Length; i++) 
            {
                txt1.Text += pole[i].ToString() + ";";
            }

            txt1.Text = string.Join(";", pole);
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
