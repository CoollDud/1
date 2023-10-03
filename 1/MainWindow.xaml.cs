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

namespace _1
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

        private void Calc_B_Click(object sender, RoutedEventArgs e)
        {
            int number11 = int.Parse(Number1_TB.Text);
            int number2 = int.Parse(Number2_TB.Text);
            int number3 = int.Parse(Number3_TB.Text);
            int poloz=0;
            int otriz=0;
            if (number11>0)
            {
                poloz++;
            }
            else if(number11<0)
            {
                otriz++;
            }
            if (number2 > 0)
            {
                poloz++;
            }
            else if (number2<0)
            {
                otriz++;
            }
            if (number3 > 0)
            {
                poloz++;
            }
            else if (number3<0)
            {
                otriz++;
            }

            Polozh1.Text=poloz.ToString();
            Otriz1.Text=otriz.ToString();
        }
    }
}
