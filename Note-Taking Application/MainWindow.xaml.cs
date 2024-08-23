using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Note_Taking_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    /// The following features to be added as bare minimum:
    /// 1) Add notes 
    /// 2) Save notes (temporary or permanent) through a button of sort.
    /// 3) Delete notes 
    
    /// Optional features: 
    /// 1) Add photos
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        // Button for navigating back
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        // Button for saving notes. 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        // Textbox for writing notes
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            notebox.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            notebox.SpellCheck.IsEnabled = true;
            // Set it as default background color
            this.grid.Background = new SolidColorBrush(Colors.RosyBrown);
            // multiline of notes, if written in C#
            // notebox.AcceptsReturn= true;
            // Causes entered text to wrap to a new line when the edge of the textbox control is reached, if in C#
            // notebox.TextWrapping= TextWrapping.Wrap; 
        }
    }
}
