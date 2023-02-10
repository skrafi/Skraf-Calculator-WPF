using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

namespace SkrafToolCalc
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
        private void Dragmee(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch
            {
                //bruh
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
            App.Current.Shutdown();
        }
        
        string output;

        float temp = 0;
        
        string operation = "";

        private void Minus_OnClick(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Minus";
            }
        }
        
        private void Plus_OnClick(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Plus";
            }
        }
        
        private void Multiply_OnClick(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Multiply";
            }
        }
        
        private void Division_OnClick(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Division";
            }
        }



        private void Squared_OnClick(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Squared";
            }
        }

        private void Percent_OnClick(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = float.Parse(output);

                output = "";

                operation = "Percent";
            }
        }

        private void Dot_OnClick(object sender, RoutedEventArgs e)
        {
            if (math.Text.Count(c => c == '.') != 1)
            {
                math.Text += ".";
                output += ".";

            }
        }

        private void NumCLick(object sender, RoutedEventArgs e)
        {
            string liczba = ((Button)sender).Name;

            switch (liczba)
            {
                case "One":
                    output += "1";
                    math.Text = output;
                    break;

                case "Two":
                    output += "2";
                    math.Text = output;
                    break;

                case "Three":
                    output += "3";
                    math.Text = output;
                    break;

                case "Four":
                    output += "4";
                    math.Text = output;
                    break;

                case "Five":
                    output += "5";
                    math.Text = output;
                    break;

                case "Six":
                    output += "6";
                    math.Text = output;
                    break;

                case "Seven":
                    output += "7";
                    math.Text = output;
                    break;

                case "Eight":
                    output += "8";
                    math.Text = output;
                    break;

                case "Nine":
                    output += "9";
                    math.Text = output;
                    break;

                case "Zero":
                    output += "0";
                    math.Text = output;
                    break;

                case "Dot":
                    output += ".";
                    math.Text = output;
                    break;
            }
        }

        private void Equal_OnClick(object sender, RoutedEventArgs e)
        {
            switch (operation)   // double.Parse(output) = how much you subtract, temp = what you are subtracting from
            {
                case "Minus":
                    Counting.Content = $"{temp} - {output}";
                    double outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    math.Text = output;
                    break;
                
                case "Plus":
                    Counting.Content = $"{temp} + {output}";
                    double outputTemp1 = temp + double.Parse(output);
                    output = outputTemp1.ToString();
                    math.Text = output;
                    break;
                
                case "Multiply":
                    Counting.Content = $"{temp} * {output}";
                    double outputTemp2 = temp * double.Parse(output);
                    output = outputTemp2.ToString();
                    math.Text = output;
                    break;
                
                case "Division":
                    Counting.Content = $"{temp} / {output}";
                    double outputTemp3 = temp / double.Parse(output);
                    output = outputTemp3.ToString();
                    math.Text = output;
                    break;
                
                case "Percent":
                    Counting.Content = $"{temp} % {output}";
                    float outputTemp4 = float.Parse(output) / 100f * temp;
                    output = outputTemp4.ToString();
                    math.Text = output;
                    break;
                
                case "Squared":
                    Counting.Content = $"{temp} ** {output}";
                    double outputTemp5 = Math.Pow(temp, double.Parse(output));
                    output = outputTemp5.ToString();
                    math.Text = output;
                    break;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (math.Text.Length < 2)
            {
                math.Text = math.Text.Substring(0, math.Text.Length - 1);
                math.Text = "0";
            }
            else
            {
                output = output.Substring(0, math.Text.Length - 1);
                math.Text = math.Text.Substring(0, math.Text.Length - 1);
            }
        }
        private void Reset_OnClick(object sender, RoutedEventArgs e)
        {
            math.Text = "0";
            output = "";
        }
    }
}