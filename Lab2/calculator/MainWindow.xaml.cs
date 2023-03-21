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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string scr = string.Empty; // last num
        float result; // previous calc
        float num1 =0;
        float num2 =0;
        char? operation = null;
        bool flag = true; // if first operator -> true
        bool lastOp = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char val;
            char.TryParse( ((Button)sender).Content.ToString(), out val);
            //screen.Content = val.ToString();
            char last= ' ';
            char l =' ';
            if (scr.Length != 0 ) { last = scr[scr.Length - 1]; }
            if (val == '+' || val == '-' || val == '/' || val == '.'|| val == '*')
            {
                if (lastOp == true)
                {
                    screen.Content = "please make sure of what you write\n";
                    initialize();
                }
                else
                {

                
                if (last != '+' && last != '-' && last != '/' && last != '*' && last != '.')
                {
                    if (val != '.')
                    {
                        operation = val;
                    }

                    Calc(val);
                    screen.Content += val.ToString();
                    #region switch
                    //switch (val)
                    //{
                    //    case "+":
                    //        //result += int.Parse(scr);

                    //        break;
                    //    case "-":
                    //        //result -= int.Parse(scr);
                    //        break;
                    //    case "/":
                    //        //if (result!= 0)
                    //        //{
                    //        //    result /= int.Parse(scr);
                    //        //}
                    //        break;
                    //    case "*":
                    //        //result *= int.Parse(scr);
                    //        break;
                    //    case ".":
                    //        //scr += val;
                    //        break;
                    //} 
                    #endregion
                }
                //else if (l == '+' && l == '-' && l == '/' && l == '*' && l == '.')
                //{
                //    screen.Content = "please make sure of what you write\n";
                //    initialize();
                //}
                else
                {
                    screen.Content = "please make sure of what you write\n";
                    initialize();
                }
                }

                lastOp = true;
            }
            else if(val == '=')
            {
                if (last != '+' && last != '-' && last != '/' && last != '*' && last != '.')
                {
                    Calc(operation);
                    num1 = result;
                    //screen.Content = result + "\n";
                    screen.Content = result + "\n";
                    flag = true;
                    //operation = null;
                    //num1 = result;
                    //num1 = num2  = 0;
                    //result = 0;
                    //scr = string.Empty;
                }
                else
                {
                    screen.Content = "please make sure of what you write\n";
                    initialize();
                }
            }
            else
            {
                lastOp = false;
                scr += val.ToString();
                screen.Content += val.ToString();
            }
        }

        void initialize() {
            scr = string.Empty; // last num
            result = num1 = num2 = 0;
            operation = null;
            flag = true;
        }

        //void Calc (char op, int n1, int n2, int result, string current)
        void Calc (char? oper)
        {
            if (oper != null)
            {
                switch (oper)
                {
                    case '+':
                        if(float.TryParse(scr, out num2))
                        {
                            result = num1 + num2;
                            flag = false;
                        }
                        scr = string.Empty;
                        break;
                    case '-':
                        if(float.TryParse(scr, out num2))
                        {
                            //result = num1 - num2;
                            //flag = false;
                            if (flag == true)
                            {
                                result = num2;
                                flag = false;
                            }
                            else
                            {
                                result = num1 - num2;
                                scr = string.Empty;
                            }
                        }
                        scr = string.Empty;
                        break;
                    case '/':
                        if(float.TryParse(scr, out num2))
                        {
                            result = num1 / num2;
                            flag = false;
                            //if (flag == true)
                            //{
                            //    if (num2 != 0)
                            //    {
                            //        result = num2;
                            //    }
                            //    flag = false;
                            //}
                            //else
                            //{
                            //    result = num1 / num2;
                            //    //if (num2 == 0)
                            //    //{
                            //    //    screen.Content = "You can't divide by zero";
                            //    //}
                            //    //else
                            //        //result = result / num2;
                            //}
                            //scr = string.Empty;
                        }
                        scr = string.Empty;
                        break;

                    case '*':
                        if(float.TryParse(scr, out num2))
                        {
                            //result = num1 * num2;
                            //flag = false;

                            if (flag == true)
                            {
                                flag = false;
                                result = num2;
                            }
                            else
                            {
                                result = num1 * num2;
                            }
                        }
                        scr = string.Empty;
                        break;
                    case '.':
                        scr += '.';
                        break;
                }
                num1 = result;
            }
            else
                num2 = float.Parse(scr);
        }
    }
}
