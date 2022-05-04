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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Enable()
        {
            divide.IsEnabled = true;
            multiply.IsEnabled = true;
            coma.IsEnabled = true;
            plus.IsEnabled = true;
            minus.IsEnabled = true;
            modulo.IsEnabled = true;
            equals.IsEnabled = true;
            plusminus.IsEnabled = true;
        }
        private void Disable()
        {
            coma.IsEnabled = false;
            multiply.IsEnabled = false;
            divide.IsEnabled = false;
            modulo.IsEnabled = false;
            plus.IsEnabled = false;
            minus.IsEnabled = false;
            equals.IsEnabled = false;
            plusminus.IsEnabled = false;
        }
        private void Default_Click(object sender, RoutedEventArgs e)
        {
            //font size by text length
            if(maintb.Text.Length > 4)
            {
                maintb.FontSize = 55;
            } 
            if(maintb.Text.Length > 6)
            {
                maintb.FontSize = 50;
            } 
            if(maintb.Text.Length > 8)
            {
                maintb.FontSize = 45;
            }
            if (maintb.Text.Length > 10)
            {
                maintb.FontSize = 40;
            }
            if (maintb.Text.Length > 11)
            {
                maintb.FontSize = 25;
            }
            if(maintb.Text.Length > 18)
            {
                maintb.FontSize = 15;
            }
            

            if (maintb.Text == "0" || maintb.Text == "∞")
            {
                maintb.Clear();
            }

            maintb.Text += ((Button)sender).Content.ToString();
            Enable();
            if (maintb.Text[maintb.Text.Length - 1] == '-' || maintb.Text[maintb.Text.Length - 1] == '+' || maintb.Text[maintb.Text.Length - 1] == '%')
            {
                Disable();
            }
        }
        private void AC_Click(object sender, RoutedEventArgs e)
        {
            maintb.Text = "0";
            Enable();
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
        private void divide_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + "/";
            Disable();
        }
        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (maintb.Text == "0")
            {
                maintb.Clear();
            }
            maintb.Text = maintb.Text + "*";
            Disable();
        }
        private void coma_Click(object sender, RoutedEventArgs e)
        {
            maintb.Text = maintb.Text + ".";
            Disable();
        }
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            string math = maintb.Text;
            if (math[math.Length - 1] != '/')
            {
                maintb.Text = maintb.Text + 0;
            }
            else
            {
                maintb.Text = "div/zero";
            }
            if (maintb.Text != "div/zero")
            {
                if (maintb.Text.Contains('%') & maintb.Text.Contains('.'))
                {
                    maintb.Text = "error";
                }
                else
                {
                    string result = new DataTable().Compute(math, null).ToString();
                    maintb.Text = result;
                }
            }
            else
            {
                maintb.Text = "0";
            }
            Enable();
            maintb.FontSize = 60;
        }
    }
}
