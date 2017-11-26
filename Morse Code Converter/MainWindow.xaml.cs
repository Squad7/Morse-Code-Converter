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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Morse_Code_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<char, string> _codes;

        public MainWindow()
        {
            InitializeComponent();
            MorseConverter();

            
           
        }        

        //Morse Code conversion array
        public void MorseConverter()
        {
            _codes = new Dictionary<char, string>();
            _codes.Add('A', ".-");
            _codes.Add('B', "-...");
            _codes.Add('C', "-.-.");
            _codes.Add('D', "-..");
            _codes.Add('E', ".");
            _codes.Add('F', "..-.");
            _codes.Add('G', "--.");
            _codes.Add('H', "....");
            _codes.Add('I', "..");
            _codes.Add('J', ".---");
            _codes.Add('K', "-.-");
            _codes.Add('L', ".-..");
            _codes.Add('M', "--");
            _codes.Add('N', "-.");
            _codes.Add('O', "---");
            _codes.Add('P', ".--.");
            _codes.Add('Q', "--.-");
            _codes.Add('R', ".-.");
            _codes.Add('S', "...");
            _codes.Add('T', "-");
            _codes.Add('U', "..-");
            _codes.Add('V', "...-");
            _codes.Add('W', ".--");
            _codes.Add('X', "-..-");
            _codes.Add('Y', "-.--");
            _codes.Add('Z', "--..");
            _codes.Add('1', ".----");
            _codes.Add('2', "..---");
            _codes.Add('3', "...--");
            _codes.Add('4', "....-");
            _codes.Add('5', ".....");
            _codes.Add('6', "-....");
            _codes.Add('7', "--...");
            _codes.Add('8', "---..");
            _codes.Add('9', "----.");
            _codes.Add('0', "-----");
            _codes.Add(' ', "/");
        }

        //When convert button is clicked all the conversion functions are called
        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {

            //Changes all letters in array to uppercase so it can communicate with array
            string name = InputBox.Text.ToUpper();

            //Goes through each character in the name (InputBox)
            foreach (char character in name)
            {
                //Searches for character in the _codes (Conversion) array and displays the morse code conversion in OutputBox
                OutputBox.Text += _codes[character];
                //Puts a gap inbetween each morse code line
                OutputBox.Text += " ";
            }

        }

        //When audio button is clicked all the morse code conversion is played over audio 
        private void AudioButton_Click(object sender, RoutedEventArgs e)
        {
            //Changes all letters in array to uppercase so it can communicate with array
            string name = InputBox.Text.ToUpper();

            //Creates a new array of characters from output textblock of morse code conversion
            char[] morsechararray = OutputBox.Text.ToCharArray();

            //Goes through each character in the new char array
            foreach (char element in morsechararray)
            {
                //Plays audio depending on morse code characters in the new array

                if (element == '.')
                {
                    Console.Beep(800, 500);
                }
                else if (element == '-')
                {
                    Console.Beep(800, 1500);
                }
                else if (element  == '/')
                {
                    System.Threading.Thread.Sleep(3500);
                }
                else
                {
                    System.Threading.Thread.Sleep(1500);
                }
            }
        }


        //When the program starts, the outputbox disables ability for users to input data
        private void Page1_Loaded(object sender, RoutedEventArgs e)
        {
            OutputBox.IsEnabled = false;

        }

        //When there is no input into the inputbox, the outputbox clears
        private void InputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (InputBox.Text == "")
            {
                OutputBox.Clear();

            }

            
        }

    }

}
