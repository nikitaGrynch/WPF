using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace ColorApp
{
    internal class ColorViewModel : INotifyPropertyChanged
    {
        private ColorModel? _color;
        public ObservableCollection<ListBoxItem> colorsList { get; set; }

        public ColorModel? Color
        {
            get { return _color; }
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }

        public ColorViewModel()
        {
            Color = new ColorModel { Alpha = 255, Red = 255, Green = 0, Blue = 0 };
            colorsList = new();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
