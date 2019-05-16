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
using System.Windows.Shapes;

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public CreateWindow()
        {
            InitializeComponent();
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtMin_Input(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^[0-5]?[\d]{1}$"); // mit Lukas anschauen
            e.Handled = regex.IsMatch(e.Text);
            if (regex.IsMatch(txtBoxDauerMin.Text))
            {
                Console.WriteLine("Korrekt");
            } else
            {
                Console.WriteLine("Invalid");
            }
        }

        private void txtCDName_Input(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"^([\w]{3,})$");
            e.Handled = regex.IsMatch(e.Text);
            if (regex.IsMatch(txtBoxCDName.Text))
            {
                Console.WriteLine("Korrekt");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    }
}
