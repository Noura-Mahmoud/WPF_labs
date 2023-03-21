using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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
        private void Change_Color(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Red;
                    break;

                case "Green":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Green;
                    break;

                case "Blue":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }
        }

        private void Change_Mode(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ink":

                    InkCan.EditingMode = InkCanvasEditingMode.Ink;
                    break;

                case "Select":

                    InkCan.EditingMode = InkCanvasEditingMode.Select;
                    break;

                case "Erase":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;

                case "Erase by strock":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
            }
        }

        private void Change_Shape(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ellipse":

                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;

                case "Rectangle":

                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
                    break;
            }
        }

        private void Change_Brush(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Small":
                    InkCan.DefaultDrawingAttributes.Height = 2;
                    InkCan.DefaultDrawingAttributes.Width = 2;
                    break;

                case "Medium":
                    InkCan.DefaultDrawingAttributes.Height = 5;
                    InkCan.DefaultDrawingAttributes.Width = 5;
                    break;

                case "Large":
                    InkCan.DefaultDrawingAttributes.Height = 10;
                    InkCan.DefaultDrawingAttributes.Width = 10;
                    break;
            }
        }

        private void Button_new(object sender, RoutedEventArgs e)
        {
            InkCan.Strokes.Clear();
        }

        private void Button_copy(object sender, RoutedEventArgs e)
        {
            if (InkCan.GetSelectedStrokes().Count > 0)
                InkCan.CopySelection();
        }

        private void Button_cut(object sender, RoutedEventArgs e)
        {
            if (InkCan.GetSelectedStrokes().Count > 0)
                InkCan.CutSelection();
        }

        private void Button_paste(object sender, RoutedEventArgs e)
        {
            InkCan.Paste();
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {
            //InkCan.Strokes.Save();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (saveFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName,
                                               FileMode.Create);
                InkCan.Strokes.Save(fs);
                fs.Close();
            }
        }

        private void Button_load(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                               FileMode.Open);
                InkCan.Strokes = new StrokeCollection(fs);
                fs.Close();
            }
        }
    }
}
