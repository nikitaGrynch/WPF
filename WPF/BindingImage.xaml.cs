using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for BindingImage.xaml
    /// </summary>
    public partial class BindingImage : Window
    {
        public BindingImage()
        {
            InitializeComponent();
            var imgs = Directory.GetFiles(@"C:\img");
            foreach (var img in imgs)
            {
                imgNames.Items.Add(System.IO.Path.GetFullPath(img));
            }
        }
    }

    struct Img
    {
        String Name;
        String FullPath;

        public Img(String name, String fullPath)
        { 
            this.FullPath = fullPath;
            this.Name = name;
        }

        public override string ToString()
        {
            return this.FullPath;
        }
    }
}
