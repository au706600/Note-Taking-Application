using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
   
    /// As bare minimum:
    /// 1) Add notes 
    /// 2) Save notes (temporary or permanent) through a button of sort.
    
    /// Optional features: 
    /// 1) Add photos
    /// 2) A list of note sections that are basically fetched or "displayed" on the start side. 
   
    public partial class MainWindow : Window
    {
        string file = "notes.txt";
        public MainWindow()
        {
            InitializeComponent();

            // Check if file exists. 
            if (File.Exists(file))
            {
                // If it exists, open the textfile, read all the text file and then close it again. 
                string noteContent = File.ReadAllText(file);
                // The textbox text should be displayed from the file. 
                notebox.Text = noteContent;
            }
        }


        // Button for navigating back
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        // Button for saving notes. 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Write the contents of the textbox text to the notes.txt file. If the target file already exists, 
            // it will be overwritten. 
            File.WriteAllText(file, notebox.Text);
            // As a confirmation, display this message to the user. 
            MessageBox.Show("Your notes are successfully saved :)");
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
