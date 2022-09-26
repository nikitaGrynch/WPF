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
    /// Interaction logic for DatePickerWindow.xaml
    /// </summary>
    public partial class DatePickerWindow : Window
    {
        public DatePickerWindow()
        {
            InitializeComponent();
        }

        private void datePicker1_CalendarClosed(object sender, RoutedEventArgs e)
        {
            if(datePicker1.SelectedDate != null && datePicker2.SelectedDate != null)
            {
                var res = datePicker2.SelectedDate - datePicker1.SelectedDate;
                label.Content = (res.Value.Days >= 0 ? $"{res.Value.Days} day(s) left" : $"{-res.Value.Days} day(s) have passed");
            }
        }

        private void datePicker2_CalendarClosed(object sender, RoutedEventArgs e)
        {

        }
    }
}
