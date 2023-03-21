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

namespace emloyeeList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Employee> Employees { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Employees = new List<Employee>()
            {
                new Employee(){Name="Itachi", Grade=100,Id=1,Salary=10000,Image="./wpf_t3/i.jpeg"},
                new Employee(){Name="Hinata", Grade = 80,Id=2,Salary=6000,Image="/wpf_t3/h.jpeg"},
                new Employee(){Name="Naruto", Grade = 40,Id=3,Salary=9000,Image="wpf_t3/n.jpeg"},
                new Employee(){Name="Armen", Grade= 110,Id=4,Salary=5000,Image="wpf_t3/a.jpeg"},
                new Employee(){Name="Mikasa", Grade = 98,Id=5,Salary=8000,Image="wpf_t3/m.jpeg"},
                new Employee(){Name="Eren", Grade = 83.5f,Id=6,Salary=7000,Image="wpf_t3/e.jpeg"},
            };
            lst.ItemsSource = Employees;
        }
    }
}
