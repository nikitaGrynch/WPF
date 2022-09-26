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
    /// Interaction logic for GridProgrammaticallyWindow.xaml
    /// </summary>
    public partial class GridProgrammaticallyWindow : Window
    {
        public GridProgrammaticallyWindow()
        {
            InitializeComponent();
            CreateGrid(10, 10);
        }

        private void CreateGrid(int x, int y)
        {
            var grid = new Grid();

            // Row Definition
            for(int i = 0; i < x; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            // Column Definition
            for (int i = 0; i < y; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            // Add buttons
            int n = 1;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var button = new Button();
                    button.Content = n.ToString();
                    button.Name = "Button" + n.ToString();
                    button.Click += Button_Click;


                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);

                    grid.Children.Add(button);
                    n++;
                }
            }
            this.Content = grid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var b = sender as Button;
            if(b == null)
            {
                return;
            }
            MessageBox.Show(b.Content.ToString());
        }
    }
}
