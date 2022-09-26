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
    /// Interaction logic for Slider.xaml
    /// </summary>
    public partial class Slider : Window
    {
        private int R;
        private int G;
        private int B;
        public Slider()
        {
            InitializeComponent();
            R = (int)RedSlider.Value;
            G = (int)GreenSlider.Value;
            B = (int)BlueSlider.Value;
            this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(R), Convert.ToByte(G), Convert.ToByte(B)));
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            R = (int)RedSlider.Value;
            this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(R), Convert.ToByte(G), Convert.ToByte(B)));

        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            G = (int)GreenSlider.Value;
            this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(R), Convert.ToByte(G), Convert.ToByte(B)));

        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            B = (int)BlueSlider.Value;
            this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(R), Convert.ToByte(G), Convert.ToByte(B)));

        }
    }
}
