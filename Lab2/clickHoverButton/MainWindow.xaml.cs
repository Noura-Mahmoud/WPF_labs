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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace clickHoverButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Storyboard BlinkStoryboard;
        public MainWindow()
        {
            InitializeComponent();
            //BlinkStoryboard = new Storyboard();

            //ColorAnimation colorAnimation = new ColorAnimation();
            //colorAnimation.From = Colors.Transparent;
            //colorAnimation.To = Colors.Aqua;
            //colorAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
            //colorAnimation.AutoReverse = true;
            //colorAnimation.RepeatBehavior = RepeatBehavior.Forever;

            //Storyboard.SetTargetProperty(colorAnimation, new PropertyPath("(Button.Background).(SolidColorBrush.Color)"));
            //BlinkStoryboard.Children.Add(colorAnimation);

        }
            //private void Button_Loaded(object sender, RoutedEventArgs e)
            //{
            //    BlinkStoryboard.Begin((Button)sender);
            //}
    }
}
