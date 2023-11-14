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

namespace Convert_to_Binary
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

        private void Convert_f(object sender, RoutedEventArgs e)
        {
            int val = Int32.Parse(ToConvert.Text);
            int bitMask = 1 << 7;
            StringBuilder bitBuffer = new StringBuilder(10);
            for (int i = 1; i <= 8; i++)
            {
                if ((val & bitMask) == 0)
                    bitBuffer.Append("0");
                else
                    bitBuffer.Append("1");
                val <<= 1;
                if ((i % 8) == 0)
                    bitBuffer.Append(" ");
            }
          
            Show_Convert.Content = "Binary version: "+bitBuffer.ToString();

        }

        private void Clear_f(object sender, RoutedEventArgs e)
        {
            ToConvert.Clear();
        }

        private void Clear_f2(object sender, RoutedEventArgs e)
        {
            ToConvert2.Clear();
        }

        private void Convert_f2(object sender, RoutedEventArgs e)
        {
            int val = Int32.Parse(ToConvert2.Text);
            int bitMask = 1 << 7;
            StringBuilder bitBuffer = new StringBuilder(10);
            for (int i = 1; i <= 8; i++)
            {
                if ((val & bitMask) == 0)
                    bitBuffer.Append("0");
                else
                    bitBuffer.Append("1");
                val <<= 1;
                if ((i % 8) == 0)
                    bitBuffer.Append(" ");
            }

            Show_Convert2.Content = "Binary version: " + bitBuffer.ToString();
        }

        private void Show_sum_f(object sender, RoutedEventArgs e)
        {
            int val = Int32.Parse(ToConvert.Text) + Int32.Parse(ToConvert2.Text);
            int bitMask = 1 << 7;
            StringBuilder bitBuffer = new StringBuilder(10);
            for (int i = 1; i <= 8; i++)
            {
                if ((val & bitMask) == 0)
                    bitBuffer.Append("0");
                else
                    bitBuffer.Append("1");
                val <<= 1;
                if ((i % 8) == 0)
                    bitBuffer.Append(" ");
            }

            Sum.Content = "Sum binary versions: " + bitBuffer.ToString();

        }

        private void Show_mult_f(object sender, RoutedEventArgs e)
        {
            int val = Int32.Parse(ToConvert.Text) * Int32.Parse(ToConvert2.Text);
            int bitMask = 1 << 7;
            StringBuilder bitBuffer = new StringBuilder(10);
            for (int i = 1; i <= 8; i++)
            {
                if ((val & bitMask) == 0)
                    bitBuffer.Append("0");
                else
                    bitBuffer.Append("1");
                val <<= 1;
                if ((i % 8) == 0)
                    bitBuffer.Append(" ");
            }

            Mult.Content = "Multiplication of binary versions: " + bitBuffer.ToString();
        }
    }
}
