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
using System.Windows.Shapes;

namespace Note_Taking_Application
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        // Function for displaying a list of note sections. 
        private void Lists_of_Notes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //this.dfdf.Background = new SolidColorBrush(Colors.Blue);
        }

        // Function for adding a section note. 
        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
