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

namespace Calculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1;
        double number2;
        string operation = "";
        int iter = 0;
        bool dot = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "1";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "1";
                    iter += 1;
                }
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "2";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "2";
                    iter += 1;
                }
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "3";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "3";
                    iter += 1;
                }
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "4";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "4";
                    iter += 1;
                }
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "5";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "5";
                    iter += 1;
                }
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "6";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "6";
                    iter += 1;
                }
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "7";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "7";
                    iter += 1;
                }
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "8";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "8";
                    iter += 1;
                }
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "9";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "9";
                    iter += 1;
                }
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (iter < 15)
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "0";
                    iter += 1;
                }
                else
                {
                    txtDisplay.Text += "0";
                    iter += 1;
                }
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            number1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            iter = 0;
            dot = false;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            number1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            iter = 0;
            dot = false;
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            number1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            iter = 0;
            dot = false;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            number1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            iter = 0;
            dot = false;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            number2 = Convert.ToDouble(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    number1 = (number1 + number2);
                    number2 = 0;
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    number1 = (number1 - number2);
                    number2 = 0;
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    number1 = (number1 * number2);
                    number2 = 0;
                    break;
                case "/":
                    if(number2 == 0)
                    {
                        txtDisplay.Text = "0";
                        number1 = 0;
                        number2 = 0;
                        operation = "";
                        iter = 0;
                        break;
                    } else
                    {
                        txtDisplay.Text = (number1 / number2).ToString();
                        number1 = (number1 / number2);
                        number2 = 0;
                        break;
                    }                    
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = 0;
            } else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";
            iter = 0;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
            iter = 0;

        }

        private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            double tmp = Convert.ToDouble(txtDisplay.Text);
            tmp *= -1;
            txtDisplay.Text = tmp.ToString();
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if(dot == false)
            {
                txtDisplay.Text += ",";
                dot = true;
            }
        }
    }
}
