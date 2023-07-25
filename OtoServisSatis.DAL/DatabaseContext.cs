using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Arac> Arac { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Marka> Markalar { get; set; }

        public DbSet<Musteri> Musteriler { get; set; }
        
        public DbSet<Rol> Roller { get; set; }

        public DbSet<Satis> Satislar { get; set; }
        
        public DbSet<Servis> Servisler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
        {
            protected override void Seed(DatabaseContext context)
            {
                //if (!context.Kullanicilar.Any())
                //{
                //    context.Kullanicilar.Add(new Kullanici()
                //    {
                //        Adi = "Admin",
                //        Durum = true,
                //        KayitTarihi = DateTime.Now,
                //        EMail = "Admin@Otoservissatis.com",
                //        KullaniciAdi="Admin",
                //        Sifre="123456",
                //    });
                //    context.SaveChanges();
                //}
                //base.Seed(context);
            }
        }

        public DatabaseContext() : base("name=DatabaseContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}


/*
 *EF de migrationu aktif etme
 *1-App.config dosyalarına (DAL katmanı ve WindowsApp Katmanı ) Connection stringi oluşturuyorum.
 *2-PMC konsolunu wievden açtım.
 *3-PMC konsolunda aktif proje olarak sağ üst menüden projeadi.DAL katmanını seçip enable migrations yazıp seçtim.
 *4-Migration klasörü Dal katmanına geldikten sonra PMC konsolunda DAL projesine add-migration migrationismi komutu ile bir migration oluşturduk.
 *5-ismini verip oluşturduğumuz migration,migrations klasörüne eklendikten sonra PMC konsoluna update-database diyerek veritabanı kurdum.
 
 */