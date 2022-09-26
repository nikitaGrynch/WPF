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

namespace WPF
{
    /// <summary>
    /// Interaction logic for ColorRadioButton.xaml
    /// </summary>
    public partial class ColorRadioButton : Window
    {
        public ColorRadioButton()
        {
            InitializeComponent();
            RedRadioButton.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton? radioButton = sender as RadioButton;
            if (radioButton == null)
                return;
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(radioButton.Content.ToString()));
        }
    }
}
