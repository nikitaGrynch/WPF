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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for FlowDocumentFromFile.xaml
    /// </summary>
    public partial class FlowDocumentFromFile : Window
    {
        string path = @"mushrooms2.txt";
        public FlowDocumentFromFile()
        {
            InitializeComponent();
            FlowDocument document = new FlowDocument();
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var range = new TextRange(flowDocument.ContentStart, flowDocument.ContentEnd);
                range.Load(fs, DataFormats.Text);
            }
            flowDocumentReader.Document = flowDocument;
        }
    }
}
