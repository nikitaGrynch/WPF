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
    /// Interaction logic for Calc2.xaml
    /// </summary>
    public partial class Calc2 : Window
    {
        public Calc2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            if (button == null)
                return;
            textBlock.Text += button.Content.ToString();
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
        }
    }
}
