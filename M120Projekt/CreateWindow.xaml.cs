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
            this.usName.SetErrorMessage("Der Name muss mind. 3 Zeichen enthalten.");
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtMin_Input(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"\D"); // mit Lukas anschauen Regex: ^[0-5]?[\d]{1}$
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
        }

        private void Btn_CreateSpeichern_Click(object sender, RoutedEventArgs e)
        {
            // Save Data on Database
            Data.CD klasseD1 = new Data.CD();

            klasseD1.CDName = "CD Name2"; // usName.TextInput? --> mit Mateusz anschauen
            klasseD1.ArtDesInhalts = "Lied"; // Dropdown, wie?
            klasseD1.StueckFilm = txtBoxstueckFilm.Text;
            klasseD1.KuenstlerProduzent = txtBoxKuenstlerProduzent.Text;
            klasseD1.Dauer = new TimeSpan(0, 5, 14);
            klasseD1.Erstellung = erstellung.DisplayDate;
            klasseD1.Veroeffentlichung = DateTime.Today;
            klasseD1.IstIntakt = true;

            Int64 klasseD1Id = klasseD1.Erstellen();
        }
    }
}
