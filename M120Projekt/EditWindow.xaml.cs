using M120Projekt.Data;
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

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private int id;
        public EditWindow(int id)
        {
            this.id = id;
            CD cd = CD.LesenID(id);
            InitializeComponent();
            this.usName.textBox.Text = cd.CDName;
            editWindowComboBoxAdI.Text = cd.ArtDesInhalts;
            txtBoxstueckFilm.Text = cd.StueckFilm;
            txtBoxKuenstlerProduzent.Text = cd.KuenstlerProduzent;
            txtBoxDauerStunden.Text = cd.Dauer.Hours.ToString();
            txtBoxDauerMin.Text = cd.Dauer.Minutes.ToString();
            txtBoxDauerSec.Text = cd.Dauer.Seconds.ToString();
            erstellung.Text = cd.Erstellung.ToString();
            veröffentlichung.Text = cd.Veroeffentlichung.ToString();
            editWindowComboBoxZustand.Text = cd.IstIntakt;
        }

        private void btnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Speichern_Click(object sender, RoutedEventArgs e)
        {
            Data.CD klasseD1 = new Data.CD();

            klasseD1.CDName = this.usName.textBox.Text;
            klasseD1.ArtDesInhalts = editWindowComboBoxAdI.Text;
            klasseD1.StueckFilm = txtBoxstueckFilm.Text;
            klasseD1.KuenstlerProduzent = txtBoxKuenstlerProduzent.Text;
            klasseD1.Dauer = new TimeSpan(short.Parse(txtBoxDauerStunden.Text), short.Parse(txtBoxDauerMin.Text), short.Parse(txtBoxDauerSec.Text));
            klasseD1.Erstellung = erstellung.SelectedDate.Value;
            klasseD1.Veroeffentlichung = veröffentlichung.SelectedDate;
            klasseD1.IstIntakt = editWindowComboBoxZustand.Text;
            klasseD1.Aktualisieren();
        }
    }
}
