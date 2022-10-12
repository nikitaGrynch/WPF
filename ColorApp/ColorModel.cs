using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;


namespace ColorApp
{
    internal class ColorModel : INotifyPropertyChanged
    {
        private int _alpha;
        private int _red;
        private int _green;
        private int _blue;
        private SolidColorBrush _myColor;


        public SolidColorBrush myColor
        {
            get { return _myColor; }
            set
            {
                _myColor = value;
                OnPropertyChanged("myColor");
            }
        }

        public int Alpha
        {
            get { return _alpha; }
            set
            {
                _alpha = value;
                ChangeColor();
                OnPropertyChanged("Alpha");
            }
        }
        public int Red
        {
            get { return _red; }
            set { 
                _red = value;
                ChangeColor();
                OnPropertyChanged("Red");
            }
        }

        public int Green
        {
            get { return _green; }
            set
            {
                _green = value;
                ChangeColor();
                OnPropertyChanged("Green");
            }
        }

        public int Blue
        {
            get { return _blue; }
            set
            {
                _blue = value;
                ChangeColor();
                OnPropertyChanged("Blue");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void ChangeColor()
        {
            myColor = new SolidColorBrush(Color.FromArgb((byte)Alpha, (byte)Red, (byte)Green, (byte)Blue));
        }
    }
}
