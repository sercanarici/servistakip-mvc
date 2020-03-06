namespace ServisTakipMVC.DAL.Migrations
{
    using ServisTakipMVC.MODEL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ServisTakipMVC.DAL.ServisTakipContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ServisTakipContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.ServisTip.AddOrUpdate(new ServisTip { Id = 3, Adi = "Diðer", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisTip.AddOrUpdate(new ServisTip { Id = 2, Adi = "Sözleþmeli", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisTip.AddOrUpdate(new ServisTip { Id = 1, Adi = "Ücretli", KayitTarihi = DateTime.Now, Silindi = false });

            context.ServisIcerik.AddOrUpdate(new ServisIcerik { Id = 1, Adi = "Program Kurulumu", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisIcerik.AddOrUpdate(new ServisIcerik { Id = 2, Adi = "Teknik Kurulum", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisIcerik.AddOrUpdate(new ServisIcerik { Id = 3, Adi = "Install", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisIcerik.AddOrUpdate(new ServisIcerik { Id = 4, Adi = "Diðer", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisIcerik.AddOrUpdate(new ServisIcerik { Id = 5, Adi = "Devir", KayitTarihi = DateTime.Now, Silindi = false });

            context.ServisSekli.AddOrUpdate(new ServisSekli { Id = 1, Adi = "Odak - SistemR", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisSekli.AddOrUpdate(new ServisSekli { Id = 2, Adi = "Müþteri Yerinde", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisSekli.AddOrUpdate(new ServisSekli { Id = 3, Adi = "Uzak Baðlantý", KayitTarihi = DateTime.Now, Silindi = false });
            context.ServisSekli.AddOrUpdate(new ServisSekli { Id = 4, Adi = "Telefon", KayitTarihi = DateTime.Now, Silindi = false });

            context.CihazMarka.AddOrUpdate(new CihazMarka { Id = 1, Adi = "Motorola", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazMarka.AddOrUpdate(new CihazMarka { Id = 2, Adi = "Newland", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazMarka.AddOrUpdate(new CihazMarka { Id = 3, Adi = "Argox", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazMarka.AddOrUpdate(new CihazMarka { Id = 4, Adi = "Tysso", KayitTarihi = DateTime.Now, Silindi = false });

            context.CihazModel.AddOrUpdate(new CihazModel { Id = 1, MarkaId = 1, Model = "mc3090", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazModel.AddOrUpdate(new CihazModel { Id = 2, MarkaId = 2, Model = "nq1000", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazModel.AddOrUpdate(new CihazModel { Id = 3, MarkaId = 3, Model = "os214", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazModel.AddOrUpdate(new CihazModel { Id = 4, MarkaId = 4, Model = "pop950", KayitTarihi = DateTime.Now, Silindi = false });

            context.CihazTip.AddOrUpdate(new CihazTip { Id = 1, Adi = "El Terminali", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazTip.AddOrUpdate(new CihazTip { Id = 2, Adi = "Fiyatgör", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazTip.AddOrUpdate(new CihazTip { Id = 3, Adi = "Termal Yazýcý", KayitTarihi = DateTime.Now, Silindi = false });
            context.CihazTip.AddOrUpdate(new CihazTip { Id = 4, Adi = "Dokunmatik PC", KayitTarihi = DateTime.Now, Silindi = false });

            context.Bayi.AddOrUpdate(new Bayi { Id = 1, Adi = "Odak Bilgisayar", KayitTarihi = DateTime.Now, Silindi = false });

            context.Musteri.AddOrUpdate(new Musteri
            {
                Id=1,
                FirmaAdi = "Alisa Baby",
                Adres = "Laleli",
                BayiId = 1,
                Telefon = "0212 556 98 52",
                Silindi = false,
                KayitTarihi = DateTime.Now,
                Yetkili = "Emin nergiz"
            });

            context.BakimAnlasmaTip.AddOrUpdate(new BakimAnlasmaTip
            {
                Id = 1,
                Adi = "Devir",
                Devir = true,
                UzakBaglanti = false,
                TelefonDestek = false,
                YerindeServis = false,
                Install = false,
                VersiyonGecis = false,
                EgitimDestek = false,
                BulutYedekleme = false,
                RaporDestek = false,
                Fiyat = 120,
                ParaBirimi = "$",
                KayitTarihi = DateTime.Now,
                Silindi = false,
            });

            context.BakimAnlasmaTip.AddOrUpdate(new BakimAnlasmaTip
            {
                Id = 2,
                Adi = "uzak Destek",
                Devir = false,
                UzakBaglanti = true,
                TelefonDestek = true,
                YerindeServis = false,
                Install = false,
                VersiyonGecis = false,
                EgitimDestek = false,
                BulutYedekleme = false,
                RaporDestek = false,
                Fiyat = 200,
                ParaBirimi = "$",
                KayitTarihi = DateTime.Now,
                Silindi = false,
            });

            context.HostingTip.AddOrUpdate(new HostingTip { Id = 1, Adi = "Linux", KayitTarihi = DateTime.Now, Silindi = false });
            context.HostingTip.AddOrUpdate(new HostingTip { Id = 2, Adi = "Windows", KayitTarihi = DateTime.Now, Silindi = false });

            context.SaveChanges();
        }
    }
}
