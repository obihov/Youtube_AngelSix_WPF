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

namespace WpfBasics
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

        static Brush OldBackgroundColor;

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            var resetButtonControl = ((Button)sender); //can do this.ResetButton as well.            
            TextBox lengthTextboxControl = this.LengthTextbox;

            if (resetButtonControl != null)
            {
                lengthTextboxControl.Text = string.Empty;
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void paintedCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox paintedComboboxControl = sender as ComboBox;
            TextBox lengthTextboxControl = this.LengthTextbox;

            //get selected combobox item when combobox changes
            var selectedPaint = paintedCombobox.SelectedValue as ComboBoxItem;
            lengthTextboxControl.Text = selectedPaint?.Content?.ToString();
        }
    }
}
