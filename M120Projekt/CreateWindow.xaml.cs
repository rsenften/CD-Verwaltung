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
using System.Data.Sql;

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
            this.usName.SetRegexString(@"^([\w]{3,})$");
            this.usName.SetErrorMessage("Min. 3 Zeichen, keine Leerzeichen");
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtHrs_Input(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"\D");
            e.Handled = regex.IsMatch(e.Text);
            if (regex.IsMatch(txtBoxDauerStunden.Text))
            {
                Console.WriteLine("Korrekt");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        private void txtMin_Input(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"\D");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtSec_Input(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"\D");
            e.Handled = regex.IsMatch(e.Text);
            if (regex.IsMatch(txtBoxDauerSec.Text))
            {
                Console.WriteLine("Korrekt");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        private void txtCDName_Input(object sender, TextCompositionEventArgs e)
        {
        }

        private void Btn_CreateSpeichern_Click(object sender, RoutedEventArgs e)
        {
            // Save Data on Database
            Data.CD klasseD1 = new Data.CD();

            klasseD1.CDName = this.usName.textBox.Text;
            klasseD1.ArtDesInhalts = DDArtDInhalt.Text;
            klasseD1.StueckFilm = txtBoxstueckFilm.Text;
            klasseD1.KuenstlerProduzent = txtBoxKuenstlerProduzent.Text;
            klasseD1.Dauer = new TimeSpan(short.Parse(txtBoxDauerStunden.Text), short.Parse(txtBoxDauerMin.Text), short.Parse(txtBoxDauerSec.Text));
            klasseD1.Erstellung = erstellung.SelectedDate.Value;
            klasseD1.Veroeffentlichung = veröffentlichung.SelectedDate;
            klasseD1.IstIntakt = DDZustand.Text;
            
            Int64 klasseD1Id = klasseD1.Erstellen();

            Close();
        }
    }
}
