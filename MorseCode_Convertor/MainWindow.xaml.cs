using System.Threading.Tasks;
using System;
using System.Windows;

namespace MorseCode_Convertor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, RoutedEventArgs e)
        { 
             OutputTextBox.Text = Conversion.FromTextToMorseCode(InputTextBox.Text);
        }

        private void Decode_Click(object sender, RoutedEventArgs e)
        {
                OutputTextBox.Text = Conversion.FromMorseCodeToText(InputTextBox.Text);
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = "";
            OutputTextBox.Text = "";
        }

        private async void Play_Click(object sender, RoutedEventArgs e)
        {
            string morse = OutputTextBox.Text;

            foreach (char c in morse)
            {
                if (c == '.')
                {
                    Console.Beep(800, 150);
                    await Task.Delay(100);
                }
                else if (c == '-')
                {
                    Console.Beep(800, 600);
                    await Task.Delay(100);
                }
                else if (c == ' ')
                {
                    await Task.Delay(300);
                }
                else if (c == '/')
                {
                    await Task.Delay(700);
                }
            }
        }
    }
}
