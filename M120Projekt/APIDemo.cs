using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120Projekt
{
    static class APIDemo
    {
        #region KlasseA
        // Create
        public static void DemoACreate()
        {
            Debug.Print("--- DemoACreate ---");
            // KlasseA
            Data.CD klasseA1 = new Data.CD();
            klasseA1.CDName = "Artikel 1";
            klasseA1.ArtDesInhalts = "Lied";
            klasseA1.StueckFilm = "Lied 1";
            klasseA1.KuenstlerProduzent = "Künstler 1";
            klasseA1.Dauer = new TimeSpan(0, 3, 25);
            klasseA1.Erstellung = DateTime.Today;
            klasseA1.Veroeffentlichung = DateTime.Today.AddMonths(-1);
            klasseA1.IstIntakt = "Intakt";
            Int64 klasseA1Id = klasseA1.Erstellen();
            Debug.Print("Artikel erstellt mit Id:" + klasseA1Id);
        }
        public static void DemoACreateKurz()
        {
            Data.CD klasseA2 = new Data.CD { CDName = "Artikel 2", IstIntakt = "Intakt", Erstellung = DateTime.Today, ArtDesInhalts = "Lied", StueckFilm = "Lied 2", KuenstlerProduzent = "Künstler 2", Dauer = new TimeSpan(0, 4, 15), Veroeffentlichung = DateTime.Today.AddYears(-1).AddMonths(-5) };
            Int64 klasseA2Id = klasseA2.Erstellen();
            Debug.Print("Artikel erstellt mit Id:" + klasseA2Id);
        }

        // Read
        public static void DemoARead()
        {
            Debug.Print("--- DemoARead ---");
            // Demo liest alle
            foreach (Data.CD klasseA in Data.CD.LesenAlle())
            {
                Debug.Print("Artikel Id:" + klasseA.CDId + " Name:" + klasseA.CDName);
            }
        }
        // Update
        public static void DemoAUpdate()
        {
            Debug.Print("--- DemoAUpdate ---");
            // KlasseA ändert Attribute
            Data.CD klasseA1 = Data.CD.LesenID(1);
            klasseA1.CDName = "Artikel 1 nach Update";
            klasseA1.Aktualisieren();
        }
        // Delete
        public static void DemoADelete()
        {
            Debug.Print("--- DemoADelete ---");
            Data.CD.LesenID(1).Loeschen();
            Debug.Print("Artikel mit Id 1 gelöscht");
        }
        #endregion
    }
}
