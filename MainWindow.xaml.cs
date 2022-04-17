using System;
using System.Data;
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

namespace kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AC_Click(object sender, RoutedEventArgs e)
        {
            maintb.Text = "0";
        }

        private void plusminus_Click(object sender, RoutedEventArgs e)
        {
            string math = maintb.Text;
            string result = new DataTable().Compute(math, null).ToString();
            if(result[0] == '-')
            {
                result = result.Substring(1);
            }
            else
            {
                result = "-" + result;
            }
            maintb.Text = result;
        }

        private void modulo_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + "%";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + "/";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 7;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 8;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 9;
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + "*";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 4;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 5;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 6;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + "-";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 1;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 2;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 3;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + "+";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + 0;
        }

        private void coma_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + ".";
        }
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            string math = maintb.Text;
            string result = new DataTable().Compute(math, null).ToString();
            maintb.Text = result;
        }
    }
}
