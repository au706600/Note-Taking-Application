using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace Note_Taking_Application
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        // Use this counter to help naming the note sections. 
        int counter = 0;
        public Window1()
        {
            InitializeComponent();
            

        }

        // Function for displaying a list of note sections. 
        private void Lists_of_Notes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Access the Item that is the note section by making it navigating to the notes of the specified noteitem. 
            string Note = (string)Lists_of_Notes.SelectedItem;
            // This section is for navigation. The this is used for current instance. 
            MainWindow main = new MainWindow(Note + ".txt", this); 
            main.Show();
            Hide();
        }

        // Function for adding a section note. 
        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            counter++; // Each time the user clicks on the Add button, the note-suffix increments. 
            string noteName = $"Note{counter}";
            // Add the note to the listview. 
            Lists_of_Notes.Items.Add(noteName);
            // When we click on the new note-section, the notebox text string is initialized to empty.
            MainWindow mainWindow = new MainWindow(noteName + ".txt", this);
            mainWindow.notebox.Text = "";
            mainWindow.Show();
            Hide();
        }
    }
}
