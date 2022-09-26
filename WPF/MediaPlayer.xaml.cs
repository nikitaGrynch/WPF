using Microsoft.Win32;
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
    /// Interaction logic for MediaPlayer.xaml
    /// </summary>
    public partial class MediaPlayer : Window
    {
        TimeSpan mediaTime;
        DispatcherTimer timer;
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            mediaSlider.Value = mediaPlayer.Position.TotalSeconds;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.LoadedBehavior = MediaState.Manual;
                mediaPlayer.Source = new Uri(openFileDialog.FileName);
                mediaPlayer.Play();
            }
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.IsLoaded)
            {
                mediaPlayer.Play();
            }
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.IsLoaded)
            {
                mediaPlayer.Pause();
            }
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.IsLoaded)
            {
                mediaPlayer.Stop();
            }
        }




        private void mediaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaPlayer.Position = TimeSpan.FromSeconds(mediaSlider.Value);
        }

        private void mediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            mediaSlider.Minimum = 0;
            mediaSlider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
            timer.Start();
        }
    }
}
