using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für RegexCDName.xaml
    /// </summary>
    public partial class RegexCDName : UserControl
    {
        private string errorMsg = "invalid";
        private string regexString = "";

        public TextBox textBox;
        public RegexCDName()
        {
            InitializeComponent();
            this.textBox = inputTxt;
        }

        public void SetRegexString(string regex)
        {
            this.regexString = regex;
        }

        public void SetErrorMessage(string msg)
        {
            this.errorMsg = msg;
        }

        private void InputTxt_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Input_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Validate();
        }

        public void ShowErrorMessage(string msg)
        {
            this.lblError.Content = msg;
        }

        private bool Validate()
        {
            bool valid = false;
            if (Regex.IsMatch(this.textBox.Text, this.regexString))
            {
                this.ShowErrorMessage("");
                valid = true;
            }
            else
            {
                this.ShowErrorMessage(this.errorMsg);
                valid = false;
            }
            return valid;
        }
    }
}

