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
        private CD cd;
        public EditWindow(int id)
        {
            this.id = id;
            cd = CD.LesenID(id);
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
            cd.CDName = this.usName.textBox.Text;
            cd.ArtDesInhalts = editWindowComboBoxAdI.Text;
            cd.StueckFilm = txtBoxstueckFilm.Text;
            cd.KuenstlerProduzent = txtBoxKuenstlerProduzent.Text;
            cd.Dauer = new TimeSpan(short.Parse(txtBoxDauerStunden.Text), short.Parse(txtBoxDauerMin.Text), short.Parse(txtBoxDauerSec.Text));
            cd.Erstellung = erstellung.SelectedDate.Value;
            cd.Veroeffentlichung = veröffentlichung.SelectedDate;
            cd.IstIntakt = editWindowComboBoxZustand.Text;
            cd.Aktualisieren();
            Close();
        }

        private void btnLoeschen_Click(object sender, RoutedEventArgs e)
        {
            CD.LesenID(id).Loeschen();
            Close();
        }
    }
}
