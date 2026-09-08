using LibraryManagementSystem.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryManagementSystem;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private LibraryManager libraryManager = new LibraryManager();

    public MainWindow()
    {
        InitializeComponent();
    }

   
    private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
       // MessageBox.Show("Event fired!");
        ComboBox comboBox = (ComboBox)sender;
        var selectedItem = comboBox.SelectedItem;
       // MessageBox.Show($"{selectedItem}");
        if (selectedItem is ComboBoxItem item)
        {
            if(item.Content.ToString() == "Book")
            {
                detailsLabel.Content = "Author";

            }
            else if (item.Content.ToString() == "Magazine")
            {
                detailsLabel.Content = "Issue Number";
            }
            else if (item.Content.ToString() == "DVD")
            {
                detailsLabel.Content = "Duration";
            }

        }
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        string title = titleTextBox.Text;
        string details = detailsTextBox.Text;
        var selectedItem = itemTypeComboBox.SelectedItem;

        if (selectedItem is ComboBoxItem item)
        {
            string type = item.Content.ToString();
            if (type == "Book")
            {
                libraryManager.AddBook(details, title);
            }

            else if (type == "Magazine")
            {
                if (int.TryParse(details, out int issueNumber))
                {
                    libraryManager.AddMagazine(issueNumber, title);
                }
                else
                {
                    MessageBox.Show("Issue Number must be a number.");
                }
            }

            else if (type == "DVD")
            {
                if (int.TryParse(details, out int duration))
                {
                    libraryManager.AddDVD(duration, title);
                }
                else
                {
                    MessageBox.Show("Duration must be a number.");
                }
            }
           
        }

        itemsListBox.Items.Clear();

        foreach (var libraryItem in libraryManager.GetItems())
        {
            itemsListBox.Items.Add(libraryItem);
        }


    }
}
