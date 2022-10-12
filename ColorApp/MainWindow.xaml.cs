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

namespace ColorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ColorViewModel dataContext;
        public MainWindow()
        {
            InitializeComponent();
            dataContext = new ColorViewModel();
            DataContext = dataContext;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            dataContext.colorsList.Add(new ListBoxItem { Background = colorLabel.Background, Height = 20 }) ;
        }
    }
}
