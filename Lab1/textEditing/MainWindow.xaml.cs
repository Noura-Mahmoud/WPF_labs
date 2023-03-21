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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace textEditing
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

        private void align(object sender, RoutedEventArgs e)
        {

                switch (((RadioButton)sender).Content.ToString())
                {
                    case "Left":
                    txt.TextAlignment = TextAlignment.Left;
                        break;

                    case "Center":
                        txt.TextAlignment = TextAlignment.Center;
                        break;

                    case "Right":
                        txt.TextAlignment = TextAlignment.Right;
                        break;
                }
            
        }

        private void readWrite(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Read Only":
                    txt.IsReadOnly = true;

                    break;

                case "Editable":
                    txt.IsReadOnly = false;
                    break;
            }
        }

        private void SetText_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "Replace default text with initial text value";
        }

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            txt.Focus();
            txt.SelectAll();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (txt.SelectedText.Length > 0)
            {
                txt.Text = txt.Text.Replace(txt.Text.Substring(txt.SelectionStart, txt.SelectionLength), "");
            }
            else
                txt.Clear();
        }

        private void prepend_Click(object sender, RoutedEventArgs e)
        {
            //StringBuilder t = new StringBuilder();
            //t.Append( "***Prepended text ***" + txt.Text);
            //txt.Text = t.ToString();
            txt.Text = "***Prepended text *** " + txt.Text ;
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text.Insert(txt.CaretIndex, " *** inserted text *** ");

        }

        private void Append_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = txt.Text + " ***appended text *** ";
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            if (txt.SelectedText != "")
                txt.Cut();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (txt.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                        // Move selection to the point after the current selection and paste.
                        txt.SelectionStart = txt.SelectionStart + txt.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                txt.Paste();
            }
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            // Determine if last operation can be undone in text box.   
            if (txt.CanUndo == true)
            {
                // Undo the last operation.
                txt.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                
            }
        }
    }
}
