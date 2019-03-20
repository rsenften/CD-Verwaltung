using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace M120Projekt.Data
{
    public class CD
    {
        #region Datenbankschicht
        [Key]
        public Int64 CDId { get; set; }
        [Required]
        public String CDName { get; set; }
        [Required]
        public String ArtDesInhalts { get; set; }
        [Required]
        public String StueckFilm { get; set; }
        [Required]
        public String KuenstlerProduzent { get; set; }
        [Required]
        public TimeSpan Dauer { get; set; }
        [Required]
        public DateTime Erstellung { get; set; }
        [Required]
        public DateTime Veroeffentlichung { get; set; }
        public Boolean IstIntakt { get; set; }
        #endregion
        #region Applikationsschicht
        public CD() { }
        [NotMapped]
        public String BerechnetesAttribut
        {
            get
            {
                return "Im Getter kann Code eingefügt werden für berechnete Attribute";
            }
        }
        public static IEnumerable<Data.CD> LesenAlle()
        {
            return (from record in Data.Global.context.CD select record);
        }
        public static Data.CD LesenID(Int64 klasseAId)
        {
            return (from record in Data.Global.context.CD where record.CDId == klasseAId select record).FirstOrDefault();
        }
        public static IEnumerable<Data.CD> LesenAttributGleich(String suchbegriff)
        {
            return (from record in Data.Global.context.CD where record.CDName == suchbegriff select record);
        }
        public static IEnumerable<Data.CD> LesenAttributWie(String suchbegriff)
        {
            return (from record in Data.Global.context.CD where record.CDName.Contains(suchbegriff) select record);
        }
        public Int64 Erstellen()
        {
            if (this.CDName == null || this.CDName == "") this.CDName = "leer";
            if (this.Erstellung == null) this.Erstellung = DateTime.MinValue;
            Data.Global.context.CD.Add(this);
            Data.Global.context.SaveChanges();
            return this.CDId;
        }
        public Int64 Aktualisieren()
        {
            Data.Global.context.Entry(this).State = System.Data.Entity.EntityState.Modified;
            Data.Global.context.SaveChanges();
            return this.CDId;
        }
        public void Loeschen()
        {
            Data.Global.context.Entry(this).State = System.Data.Entity.EntityState.Deleted;
            Data.Global.context.SaveChanges();
        }
        public override string ToString()
        {
            return CDId.ToString(); // Für bessere Coded UI Test Erkennung
        }
        #endregion
    }
}
