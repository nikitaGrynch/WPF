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

namespace CommandsWPF
{
    /// <summary>
    /// Interaction logic for CtrlRGBWindow.xaml
    /// </summary>
    public partial class CtrlRGBWindow : Window
    {
        public CtrlRGBWindow()
        {
            InitializeComponent();
        }

        private void RedCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);

        }
        private void GreenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Green);
        }
        private void BlueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);
        }

        private void BoldCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
        }

        private void ItalicCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
        }

        private void UnderlineCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
                selection.ApplyPropertyValue(TextBlock.TextDecorationsProperty, TextDecorations.Underline);
        }

        private void ClearCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                var textRange = new TextRange(selection.Start, selection.End);
                textRange.ApplyPropertyValue(TextElement.FontSizeProperty, (double)12);
                selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);
                selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
            }
        }

        private void Font15Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                var textRange = new TextRange(selection.Start, selection.End);
                textRange.ApplyPropertyValue(TextElement.FontSizeProperty, (double)15);
            }
                
        }

        private void Font30Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                var textRange = new TextRange(selection.Start, selection.End);
                textRange.ApplyPropertyValue(TextElement.FontSizeProperty, (double)30);
            }
        }
    }

    public class AllCommands
    {
        static AllCommands()
        {
            RedCommand = new RoutedCommand("RedCommand", typeof(AllCommands));
            GreenCommand = new RoutedCommand("GreenCommand", typeof(AllCommands));
            BlueCommand = new RoutedCommand("BlueCommand", typeof(AllCommands));
            BoldCommand = new RoutedCommand("BoldCommand", typeof(AllCommands));
            ItalicCommand = new RoutedCommand("ItalicCommand", typeof(AllCommands));
            UnderlineCommand = new RoutedCommand("UnderlineCommand", typeof(AllCommands));
            ClearCommand = new RoutedCommand("ClearCommand", typeof(AllCommands));
            Font15Command = new RoutedCommand("Font15Command", typeof(AllCommands));
            Font30Command = new RoutedCommand("Font30Command", typeof(AllCommands));
        }
        public static RoutedCommand RedCommand { get; set; }
        public static RoutedCommand GreenCommand { get; set; }
        public static RoutedCommand BlueCommand { get; set; }
        public static RoutedCommand BoldCommand { get; set; }
        public static RoutedCommand ItalicCommand { get; set; }
        public static RoutedCommand UnderlineCommand { get; set; }
        public static RoutedCommand ClearCommand { get; set; }
        public static RoutedCommand Font15Command { get; set; }
        public static RoutedCommand Font30Command { get; set; }
    }
}
