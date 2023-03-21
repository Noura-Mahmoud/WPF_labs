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

namespace formApplication
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

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"You have entered:\nName = {fname.Text+lname.Text}\nGender = {gender.Text}\nAddress = {address.Text}\nJob Title = {job.Text}\nPhone = {phone.Text}\nMobile = {mobile.Text}\nEmail = {email.Text}", "Personal Info", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            var result = MessageBox.Show($"You have entered:\nName = {fname.Text + lname.Text}\nGender = {gender.Text}\nAddress = {address.Text}\nJob Title = {job.Text}\nPhone = {phone.Text}\nMobile = {mobile.Text}\nEmail = {email.Text}", "Personal Info", MessageBoxButton.OKCancel, MessageBoxImage.Information);

            switch (result)
            {
                case MessageBoxResult.Cancel:
                    cancel_Click(sender, e);
                    break;
                case MessageBoxResult.OK:
                    MessageBox.Show("Data saved successfully");
                    break;  
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            fname.Clear();
            lname.Clear();
            gender.Clear();
            address.Clear();
            job.Clear();
            phone.Clear();
            mobile.Clear();
            email.Clear();
        }
    }
}
