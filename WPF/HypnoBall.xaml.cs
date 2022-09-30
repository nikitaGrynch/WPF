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
using System.Windows.Threading;

namespace WPF
{
    /// <summary>
    /// Interaction logic for HypnoBall.xaml
    /// </summary>
    public partial class HypnoBall : Window
    {
        private DispatcherTimer timer;
        private int a = 0;
        public HypnoBall()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            angle.Angle = a;
            a++;

        }
    }
}
