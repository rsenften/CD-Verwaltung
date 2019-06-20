using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace M120Projekt.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=M120Connectionstring")
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Data.Context>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CD>().ToTable("CD"); // Damit kein "s" angehängt wird an Tabelle
        }
        public DbSet<CD> CD { get; set; }
    }
}
