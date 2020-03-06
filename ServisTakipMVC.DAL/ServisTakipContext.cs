namespace ServisTakipMVC.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using ServisTakipMVC.MODEL;

    public class ServisTakipContext : DbContext
    {
        // Your context has been configured to use a 'ServisTakipContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ServisTakipMVC.DAL.ServisTakipContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ServisTakipContext' 
        // connection string in the application configuration file.
        public ServisTakipContext()
            : base("name=ServisTakipContext")
        {
            Database.SetInitializer<ServisTakipContext>(new MigrateDatabaseToLatestVersion<ServisTakipContext, ServisTakipMVC.DAL.Migrations.Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<BakimAnlasma> BakimAnlasma { get; set; }
        public virtual DbSet<BakimAnlasmaTip> BakimAnlasmaTip { get; set; }
        public virtual DbSet<Bayi> Bayi { get; set; }
        public virtual DbSet<Cihaz> Cihaz { get; set; }
        public virtual DbSet<CihazForm> CihazForm { get; set; }
        public virtual DbSet<CihazMarka> CihazMarka { get; set; }
        public virtual DbSet<CihazModel> CihazModel { get; set; }
        public virtual DbSet<CihazTip> CihazTip { get; set; }
        public virtual DbSet<Hosting> Hosting { get; set; }
        public virtual DbSet<HostingTip> HostingTip { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<ServisForm> ServisForm { get; set; }
        public virtual DbSet<ServisIcerik> ServisIcerik { get; set; }
        public virtual DbSet<ServisSekli> ServisSekli { get; set; }
        public virtual DbSet<ServisTip> ServisTip { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<BakimAnlasma>()
            .Property(b => b.AnlasilanFiyat)
            .HasPrecision(12, 2);

            modelBuilder.Entity<BakimAnlasmaTip>()
            .HasIndex(b => b.Adi)
            .IsUnique();

            modelBuilder.Entity<BakimAnlasmaTip>()
            .Property(b => b.Fiyat)
            .HasPrecision(12, 2);

            modelBuilder.Entity<Bayi>()
            .HasIndex(b => b.Adi)
            .IsUnique();

            modelBuilder.Entity<Cihaz>()
            .HasIndex(b => b.SeriNo)
            .IsUnique();

            modelBuilder.Entity<CihazForm>()
            .HasIndex(b => b.BelgeNo)
            .IsUnique();

            modelBuilder.Entity<CihazForm>()
            .Property(b => b.Fiyat)
            .HasPrecision(12, 2);

            modelBuilder.Entity<CihazMarka>()
            .HasIndex(b => b.Adi)    
            .IsUnique();            

            modelBuilder.Entity<CihazTip>()
            .HasIndex(b => b.Adi)
            .IsUnique();

            modelBuilder.Entity<Hosting>()
            .Property(b => b.Fiyat)
            .HasPrecision(12, 2);

            modelBuilder.Entity<HostingTip>()
            .HasIndex(b => b.Adi)
            .IsUnique();

            modelBuilder.Entity<Kullanici>()
            .HasIndex(b => b.KullaniciAdi)
            .IsUnique();

            modelBuilder.Entity<Musteri>()
            .HasIndex(b => b.FirmaAdi)
            .IsUnique();

            modelBuilder.Entity<ServisIcerik>()
            .HasIndex(b => b.Adi)
            .IsUnique();

            modelBuilder.Entity<ServisSekli>()
            .HasIndex(b => b.Adi)
            .IsUnique();

            modelBuilder.Entity<ServisTip>()
            .HasIndex(b => b.Adi)
            .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }

}