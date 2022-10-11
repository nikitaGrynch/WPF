using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for LocalizationWindow.xaml
    /// </summary>
    public partial class LocalizationWindow : Window
    {
        public LocalizationWindow()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk");
            Text1.Content = Localization.Text1;
            Text2.Content = Localization.Text2;
            Text3.Content = Localization.Text3;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if(button != null)
            {
                switch (button.Name)
                {
                    case "uaButton":
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk");
                        Text1.Content = Localization.Text1;
                        Text2.Content = Localization.Text2;
                        Text3.Content = Localization.Text3;
                        break;
                    case "ukButton":
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                        Text1.Content = Localization.Text1;
                        Text2.Content = Localization.Text2;
                        Text3.Content = Localization.Text3;
                        break;
                    case "esButton":
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                        Text1.Content = Localization.Text1;
                        Text2.Content = Localization.Text2;
                        Text3.Content = Localization.Text3;
                        break;
                }
            }
        }
    }
}
