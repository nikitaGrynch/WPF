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
    /// Interaction logic for BubbledWindow.xaml
    /// </summary>
    public partial class BubbledWindow : Window
    {
        public BubbledWindow()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender as BubbledWindow != null)
            {
                this.Title = textBox.Text;
            }

            else if (sender as TextBox != null && isBubbled.IsChecked == true)
            {
                (sender as TextBox)!.Text += e.Key.ToString();
            }
            e.Handled = (bool)isBubbled.IsChecked!;
        }
    }
}
