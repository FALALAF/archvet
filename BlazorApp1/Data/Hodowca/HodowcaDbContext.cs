using System;
using System.Collections.Generic;
using BlazorApp1.Data.Hodowca.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.Hodowca;

public partial class HodowcaDbContext : DbContext
{
    public HodowcaDbContext()
    {
    }

    public HodowcaDbContext(DbContextOptions<HodowcaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ArkuszOceny> ArkuszOcenies { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<HodAdre> HodAdres { get; set; }

    public virtual DbSet<HodAdresOrganizacja> HodAdresOrganizacjas { get; set; }

    public virtual DbSet<HodAdresOsoby> HodAdresOsobies { get; set; }

    public virtual DbSet<HodAlergie> HodAlergies { get; set; }

    public virtual DbSet<HodBadanium> HodBadania { get; set; }

    public virtual DbSet<HodChoroby> HodChorobies { get; set; }

    public virtual DbSet<HodHodowla> HodHodowlas { get; set; }

    public virtual DbSet<HodHodowlaAdre> HodHodowlaAdres { get; set; }

    public virtual DbSet<HodKatalogWystawy> HodKatalogWystawies { get; set; }

    public virtual DbSet<HodKategoriaUslugi> HodKategoriaUslugis { get; set; }

    public virtual DbSet<HodKlasa> HodKlasas { get; set; }

    public virtual DbSet<HodKlub> HodKlubs { get; set; }

    public virtual DbSet<HodKrycie> HodKrycies { get; set; }

    public virtual DbSet<HodMiot> HodMiots { get; set; }

    public virtual DbSet<HodOcena> HodOcenas { get; set; }

    public virtual DbSet<HodOddzial> HodOddzials { get; set; }

    public virtual DbSet<HodOraganOrganizacji> HodOraganOrganizacjis { get; set; }

    public virtual DbSet<HodOrganizacje> HodOrganizacjes { get; set; }

    public virtual DbSet<HodOsoby> HodOsobies { get; set; }

    public virtual DbSet<HodOtrzymaneTytuly> HodOtrzymaneTytulies { get; set; }

    public virtual DbSet<HodPiesWhodowliView> HodPiesWhodowliViews { get; set; }

    public virtual DbSet<HodPlec> HodPlecs { get; set; }

    public virtual DbSet<HodPy> HodPies { get; set; }

    public virtual DbSet<HodRasy> HodRasies { get; set; }

    public virtual DbSet<HodRing> HodRings { get; set; }

    public virtual DbSet<HodRole> HodRoles { get; set; }

    public virtual DbSet<HodRozrod> HodRozrods { get; set; }

    public virtual DbSet<HodSedziowie> HodSedziowies { get; set; }

    public virtual DbSet<HodSekretarzDostawca> HodSekretarzDostawcas { get; set; }

    public virtual DbSet<HodSpecjalizacja> HodSpecjalizacjas { get; set; }

    public virtual DbSet<HodSpotkanie> HodSpotkanies { get; set; }

    public virtual DbSet<HodStowarzyszenium> HodStowarzyszenia { get; set; }

    public virtual DbSet<HodTytuly> HodTytulies { get; set; }

    public virtual DbSet<HodUprawnienium> HodUprawnienia { get; set; }

    public virtual DbSet<HodUser> HodUsers { get; set; }

    public virtual DbSet<HodUsluga> HodUslugas { get; set; }

    public virtual DbSet<HodUstawieniaUzytkownika> HodUstawieniaUzytkownikas { get; set; }

    public virtual DbSet<HodUstawienium> HodUstawienia { get; set; }

    public virtual DbSet<HodUzytkownik> HodUzytkowniks { get; set; }

    public virtual DbSet<HodWersja> HodWersjas { get; set; }

    public virtual DbSet<HodWeterynarz> HodWeterynarzs { get; set; }

    public virtual DbSet<HodWlasciciel> HodWlasciciels { get; set; }

    public virtual DbSet<HodWlascicielPy> HodWlascicielPies { get; set; }

    public virtual DbSet<HodWystwa> HodWystwas { get; set; }

    public virtual DbSet<HodZabiegi> HodZabiegis { get; set; }

    public virtual DbSet<HodZapobieganieCiazy> HodZapobieganieCiazies { get; set; }

    public virtual DbSet<HodZgody> HodZgodies { get; set; }

    public virtual DbSet<ImpPrzydomki> ImpPrzydomkis { get; set; }

    public virtual DbSet<ImpRasy3> ImpRasy3s { get; set; }

    public virtual DbSet<KlasaLookup> KlasaLookups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-DJ1VFEN\\SQLEXPRESS;Database=Hodowca;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ArkuszOceny>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("arkusz_oceny");

            entity.Property(e => e.DataDo).HasColumnName("data_do");
            entity.Property(e => e.DataOd).HasColumnName("data_od");
            entity.Property(e => e.DataUrodzeniaPsa).HasColumnName("data_urodzenia_psa");
            entity.Property(e => e.Imie)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("imie");
            entity.Property(e => e.Klasa)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("klasa");
            entity.Property(e => e.Lokata)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("LOKATA");
            entity.Property(e => e.MascPsa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("masc_psa");
            entity.Property(e => e.MiastoWywy)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("miasto_wywy");
            entity.Property(e => e.NazwaHodowli)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nazwa_hodowli");
            entity.Property(e => e.NazwaPsa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nazwa_psa");
            entity.Property(e => e.NazwaRasy)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nazwa_rasy");
            entity.Property(e => e.NazwaWystawy)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nazwa_wystawy");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwisko");
            entity.Property(e => e.NrKatalogowy)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("NR_KATALOGOWY");
            entity.Property(e => e.NrRodowodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_rodowodu");
            entity.Property(e => e.NumerMikroczipu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numer_mikroczipu");
            entity.Property(e => e.Ocena)
                .HasMaxLength(120)
                .HasColumnName("ocena");
            entity.Property(e => e.Plec)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("plec");
            entity.Property(e => e.RangaWystawy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ranga_wystawy");
            entity.Property(e => e.RejOddzialowa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rej_oddzialowa");
            entity.Property(e => e.Ring)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("ring");
            entity.Property(e => e.Udzial)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("udzial");
            entity.Property(e => e.Uzasadnienie)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("uzasadnienie");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<HodAdre>(entity =>
        {
            entity.HasKey(e => e.IdAdres).HasName("hod_adres_pk");

            entity.ToTable("hod_adres");

            entity.Property(e => e.IdAdres)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_adres");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.EMail)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("e_mail");
            entity.Property(e => e.HodOsobyIdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_osoby_id_osoba");
            entity.Property(e => e.IdOrganizacji)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_organizacji");
            entity.Property(e => e.Miejscowosc)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("miejscowosc");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Panstwo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("panstwo");
            entity.Property(e => e.Tabela)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("tabela");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefon");
            entity.Property(e => e.TypAdresu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("typ_adresu");
            entity.Property(e => e.Www)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("www");
        });

        modelBuilder.Entity<HodAdresOrganizacja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hod_adres_organizacja");

            entity.HasIndex(e => new { e.HodOrganizacjeIdOrganizacji, e.HodAdresIdAdres }, "hod_adres_organizacja_hod_organizacje_id_organizacji_hod_adres_id_adres_un").IsUnique();

            entity.Property(e => e.HodAdresIdAdres)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_adres_id_adres");
            entity.Property(e => e.HodOrganizacjeIdOrganizacji)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_organizacje_id_organizacji");

            entity.HasOne(d => d.HodAdresIdAdresNavigation).WithMany()
                .HasForeignKey(d => d.HodAdresIdAdres)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_adres_organizacja_hod_adres_fk");

            entity.HasOne(d => d.HodOrganizacjeIdOrganizacjiNavigation).WithMany()
                .HasForeignKey(d => d.HodOrganizacjeIdOrganizacji)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_adres_organizacja_hod_organizacje_fk");
        });

        modelBuilder.Entity<HodAdresOsoby>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hod_adres_osoby");

            entity.Property(e => e.HodAdresIdAdres)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_adres_id_adres");
            entity.Property(e => e.HodOsobyIdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_osoby_id_osoba");

            entity.HasOne(d => d.HodAdresIdAdresNavigation).WithMany()
                .HasForeignKey(d => d.HodAdresIdAdres)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_adres_osoby_hod_adres_fk");

            entity.HasOne(d => d.HodOsobyIdOsobaNavigation).WithMany()
                .HasForeignKey(d => d.HodOsobyIdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_adres_osoby_hod_osoby_fk");
        });

        modelBuilder.Entity<HodAlergie>(entity =>
        {
            entity.HasKey(e => e.IdAlergie).HasName("hod_alergie_pk");

            entity.ToTable("hod_alergie");

            entity.Property(e => e.IdAlergie)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_alergie");
            entity.Property(e => e.DataWykrycia).HasColumnName("data_wykrycia");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("HOD_PIES_ID_PSA");
            entity.Property(e => e.HodWeterynarzIdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("HOD_WETERYNARZ_Id_osoba");
            entity.Property(e => e.Leczenie)
                .IsUnicode(false)
                .HasColumnName("leczenie");
            entity.Property(e => e.Substancja)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("substancja");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodAlergies)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_alergie_hod_pies_fk");

            entity.HasOne(d => d.HodWeterynarzIdOsobaNavigation).WithMany(p => p.HodAlergies)
                .HasForeignKey(d => d.HodWeterynarzIdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_alergie_hod_weterynarz_fk");
        });

        modelBuilder.Entity<HodBadanium>(entity =>
        {
            entity.HasKey(e => new { e.IdBadania, e.HodWeterynarzIdOsoba }).HasName("hod_badania_pk");

            entity.ToTable("hod_badania");

            entity.Property(e => e.IdBadania)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_badania");
            entity.Property(e => e.HodWeterynarzIdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("HOD_WETERYNARZ_Id_osoba");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa");
            entity.Property(e => e.Wyniki)
                .HasColumnType("image")
                .HasColumnName("wyniki");
            entity.Property(e => e.WynikiXml)
                .IsUnicode(false)
                .HasColumnName("wyniki_xml");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodBadania)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_badania_hod_pies_fk");

            entity.HasOne(d => d.HodWeterynarzIdOsobaNavigation).WithMany(p => p.HodBadania)
                .HasForeignKey(d => d.HodWeterynarzIdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_badania_hod_weterynarz_fk");
        });

        modelBuilder.Entity<HodChoroby>(entity =>
        {
            entity.HasKey(e => new { e.IdChoroby, e.HodWeterynarzIdOsoba }).HasName("hod_choroby_pk");

            entity.ToTable("hod_choroby");

            entity.Property(e => e.IdChoroby)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_choroby");
            entity.Property(e => e.HodWeterynarzIdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("HOD_WETERYNARZ_Id_osoba");
            entity.Property(e => e.DataRozpoznania).HasColumnName("data_rozpoznania");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("HOD_PIES_ID_PSA");
            entity.Property(e => e.Leczenie)
                .IsUnicode(false)
                .HasColumnName("LECZENIE");
            entity.Property(e => e.Rozpoznanie)
                .IsUnicode(false)
                .HasColumnName("rozpoznanie");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodChorobies)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_choroby_hod_pies_fk");

            entity.HasOne(d => d.HodWeterynarzIdOsobaNavigation).WithMany(p => p.HodChorobies)
                .HasForeignKey(d => d.HodWeterynarzIdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_choroby_hod_weterynarz_fk");
        });

        modelBuilder.Entity<HodHodowla>(entity =>
        {
            entity.HasKey(e => e.IdHodowli).HasName("hod_hodowla_pk");

            entity.ToTable("hod_hodowla");

            entity.Property(e => e.IdHodowli)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_hodowli");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nazwa");
        });

        modelBuilder.Entity<HodHodowlaAdre>(entity =>
        {
            entity.HasKey(e => e.IdZlaczenieAdres).HasName("hod_hodowla_adres_pk");

            entity.ToTable("hod_hodowla_adres");

            entity.Property(e => e.IdZlaczenieAdres)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_zlaczenie_adres");
            entity.Property(e => e.HodAdresIdAdres)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_adres_id_adres");
            entity.Property(e => e.HodHodowlaIdHodowli)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_hodowla_id_hodowli");

            entity.HasOne(d => d.HodAdresIdAdresNavigation).WithMany(p => p.HodHodowlaAdres)
                .HasForeignKey(d => d.HodAdresIdAdres)
                .HasConstraintName("hod_hodowla_adres_hod_adres_fk");

            entity.HasOne(d => d.HodHodowlaIdHodowliNavigation).WithMany(p => p.HodHodowlaAdres)
                .HasForeignKey(d => d.HodHodowlaIdHodowli)
                .HasConstraintName("hod_hodowla_adres_hod_hodowla_fk");
        });

        modelBuilder.Entity<HodKatalogWystawy>(entity =>
        {
            entity.HasKey(e => e.HodKatalogWystawyId).HasName("hod_katalog_wystawy_pk");

            entity.ToTable("hod_katalog_wystawy");

            entity.HasIndex(e => new { e.IdKatalog, e.HodRingIdRingu }, "hod_katalog_wystawy_id_katalog_hod_ring_id_ringu_un").IsUnique();

            entity.Property(e => e.HodKatalogWystawyId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_katalog_wystawy_id");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("HOD_PIES_ID_PSA");
            entity.Property(e => e.HodRingIdRingu)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_Ring_id_ringu");
            entity.Property(e => e.HodWystwaIdWystwa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("HOD_WYSTWA_ID_WYSTWA");
            entity.Property(e => e.IdKatalog)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("ID_KATALOG");
            entity.Property(e => e.KlasaId)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("klasa_id");
            entity.Property(e => e.Lokata)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("LOKATA");
            entity.Property(e => e.NrKatalogowy)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("NR_KATALOGOWY");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodKatalogWystawies)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_katalog_wystawy_hod_pies_fk");

            entity.HasOne(d => d.HodRingIdRinguNavigation).WithMany(p => p.HodKatalogWystawies)
                .HasForeignKey(d => d.HodRingIdRingu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_katalog_wystawy_hod_ring_fk");

            entity.HasOne(d => d.HodWystwaIdWystwaNavigation).WithMany(p => p.HodKatalogWystawies)
                .HasForeignKey(d => d.HodWystwaIdWystwa)
                .HasConstraintName("hod_katalog_wystawy_hod_wystwa_fk");

            entity.HasOne(d => d.Klasa).WithMany(p => p.HodKatalogWystawies)
                .HasForeignKey(d => d.KlasaId)
                .HasConstraintName("FK_hod_katalog_wystawy_hod_klasa");
        });

        modelBuilder.Entity<HodKategoriaUslugi>(entity =>
        {
            entity.HasKey(e => e.IdKatUslugi).HasName("hod_kategoria_uslugi_pk");

            entity.ToTable("hod_kategoria_uslugi");

            entity.Property(e => e.IdKatUslugi)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_kat_uslugi");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Opis)
                .IsUnicode(false)
                .HasColumnName("opis");
        });

        modelBuilder.Entity<HodKlasa>(entity =>
        {
            entity.HasKey(e => e.KlasaId).HasName("hod_klasa_id_pk");

            entity.ToTable("hod_klasa");

            entity.Property(e => e.KlasaId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("KLASA_ID");
            entity.Property(e => e.DoIleMiesiecy)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("DO_ILE_MIESIECY");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("NAZWA");
            entity.Property(e => e.OdIleMiesiecy)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("OD_ILE_MIESIECY");
            entity.Property(e => e.TypOceny)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("TYP_OCENY");
        });

        modelBuilder.Entity<HodKlub>(entity =>
        {
            entity.HasKey(e => e.IdOrganizacji).HasName("hod_klub_pk");

            entity.ToTable("hod_klub");

            entity.Property(e => e.IdOrganizacji)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_organizacji");
            entity.Property(e => e.HodOddzialIdOrganizacji)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_oddzial_id_organizacji");

            entity.HasOne(d => d.HodOddzialIdOrganizacjiNavigation).WithMany(p => p.HodKlubs)
                .HasForeignKey(d => d.HodOddzialIdOrganizacji)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_klub_hod_oddzial_fk");

            entity.HasOne(d => d.IdOrganizacjiNavigation).WithOne(p => p.HodKlub)
                .HasForeignKey<HodKlub>(d => d.IdOrganizacji)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_klub_hod_organizacje_fk");
        });

        modelBuilder.Entity<HodKrycie>(entity =>
        {
            entity.HasKey(e => e.IdKrycie).HasName("hod_krycie_pk");

            entity.ToTable("hod_krycie");

            entity.Property(e => e.IdKrycie)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_krycie");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa");
            entity.Property(e => e.HodPiesIdPsa1)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa1");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodKrycieHodPiesIdPsaNavigations)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_krycie_hod_pies_fk");

            entity.HasOne(d => d.HodPiesIdPsa1Navigation).WithMany(p => p.HodKrycieHodPiesIdPsa1Navigations)
                .HasForeignKey(d => d.HodPiesIdPsa1)
                .HasConstraintName("hod_krycie_hod_pies_fkv1");
        });

        modelBuilder.Entity<HodMiot>(entity =>
        {
            entity.HasKey(e => e.IdMiot).HasName("hod_miot_pk");

            entity.ToTable("hod_miot");

            entity.Property(e => e.IdMiot)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_miot");
            entity.Property(e => e.DataPorodu).HasColumnName("data_porodu");
            entity.Property(e => e.HodKrycieIdKrycie)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_krycie_id_krycie");
            entity.Property(e => e.HodWeterynarzIdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("HOD_WETERYNARZ_Id_osoba");
            entity.Property(e => e.Uwagi)
                .IsUnicode(false)
                .HasColumnName("uwagi");
            entity.Property(e => e.WielkoscMiotuPsy)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("wielkosc_miotu_psy");
            entity.Property(e => e.WielkoscMiotuSuki)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("wielkosc_miotu_suki");

            entity.HasOne(d => d.HodKrycieIdKrycieNavigation).WithMany(p => p.HodMiots)
                .HasForeignKey(d => d.HodKrycieIdKrycie)
                .HasConstraintName("hod_miot_hod_krycie_fk");

            entity.HasOne(d => d.HodWeterynarzIdOsobaNavigation).WithMany(p => p.HodMiots)
                .HasForeignKey(d => d.HodWeterynarzIdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_miot_hod_weterynarz_fk");
        });

        modelBuilder.Entity<HodOcena>(entity =>
        {
            entity.HasKey(e => e.IdOceny).HasName("hod_ocena_pk");

            entity.ToTable("hod_ocena");

            entity.Property(e => e.IdOceny)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_oceny");
            entity.Property(e => e.CoOceniamy)
                .HasMaxLength(30)
                .HasColumnName("co_oceniamy");
            entity.Property(e => e.IdKatalog)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_katalog");
            entity.Property(e => e.IdSedziego)
                .HasComment("Jesli jest to oficjalna ocena to id jest przepisane z katalogu")
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_sedziego");
            entity.Property(e => e.KatKatWystawyId)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("KAT_KAT_WYSTAWY_ID");
            entity.Property(e => e.Ocena)
                .HasMaxLength(120)
                .HasColumnName("ocena");
            entity.Property(e => e.OcenaPunktowa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("ocena_punktowa");
            entity.Property(e => e.Oficjalna)
                .HasMaxLength(3)
                .HasComment("Cxy to jest oficjalna ocena czy jest zabawa widzów")
                .HasColumnName("oficjalna");
            entity.Property(e => e.Uzasadnienie)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("uzasadnienie");

            entity.HasOne(d => d.IdSedziegoNavigation).WithMany(p => p.HodOcenas)
                .HasForeignKey(d => d.IdSedziego)
                .HasConstraintName("FK_hod_ocena_hod_sedziowie");

            entity.HasOne(d => d.KatKatWystawy).WithMany(p => p.HodOcenas)
                .HasForeignKey(d => d.KatKatWystawyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_ocena_hod_katalog_wystawy_fk");
        });

        modelBuilder.Entity<HodOddzial>(entity =>
        {
            entity.HasKey(e => e.IdOrganizacji).HasName("hod_oddzial_pk");

            entity.ToTable("hod_oddzial");

            entity.Property(e => e.IdOrganizacji)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_organizacji");
            entity.Property(e => e.HodStowarzyszeniaIdOrganizacji)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_stowarzyszenia_id_organizacji");

            entity.HasOne(d => d.HodStowarzyszeniaIdOrganizacjiNavigation).WithMany(p => p.HodOddzialHodStowarzyszeniaIdOrganizacjiNavigations)
                .HasForeignKey(d => d.HodStowarzyszeniaIdOrganizacji)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_oddzial_hod_stowarzyszenia_fkv1");

            entity.HasOne(d => d.IdOrganizacjiNavigation).WithOne(p => p.HodOddzialIdOrganizacjiNavigation)
                .HasForeignKey<HodOddzial>(d => d.IdOrganizacji)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_oddzial_hod_stowarzyszenia_fk");
        });

        modelBuilder.Entity<HodOraganOrganizacji>(entity =>
        {
            entity.HasKey(e => e.HodOraganOrganizacjiId).HasName("hod_organ_organizacji_pk");

            entity.ToTable("hod_oragan_organizacji");

            entity.HasIndex(e => e.HodStowarzyszeniaIdOrganizacji, "hod_oragan_organizacji_hod_stowarzyszenia_id_organizacji_un").IsUnique();

            entity.Property(e => e.HodOraganOrganizacjiId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_oragan_organizacji_ID");
            entity.Property(e => e.DataDo).HasColumnName("data_do");
            entity.Property(e => e.DataOd).HasColumnName("data_od");
            entity.Property(e => e.Funkcja)
                .HasMaxLength(80)
                .HasColumnName("funkcja");
            entity.Property(e => e.HodOsobyIdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_Osoby_Id_osoba");
            entity.Property(e => e.HodStowarzyszeniaIdOrganizacji)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_stowarzyszenia_Id_organizacji");
            entity.Property(e => e.TypOrganu)
                .HasMaxLength(60)
                .HasColumnName("typ_organu");

            entity.HasOne(d => d.HodOsobyIdOsobaNavigation).WithMany(p => p.HodOraganOrganizacjis)
                .HasForeignKey(d => d.HodOsobyIdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_oragan_organizacji_hod_osoby_fk");

            entity.HasOne(d => d.HodStowarzyszeniaIdOrganizacjiNavigation).WithOne(p => p.HodOraganOrganizacji)
                .HasForeignKey<HodOraganOrganizacji>(d => d.HodStowarzyszeniaIdOrganizacji)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_oragan_organizacji_hod_stowarzyszenia_fk");
        });

        modelBuilder.Entity<HodOrganizacje>(entity =>
        {
            entity.HasKey(e => e.IdOrganizacji).HasName("hod_organizacje_pk");

            entity.ToTable("hod_organizacje");

            entity.Property(e => e.IdOrganizacji)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_organizacji");
            entity.Property(e => e.DataRejestracji).HasColumnName("data_rejestracji");
            entity.Property(e => e.MiejsceRejestracji)
                .HasMaxLength(120)
                .HasColumnName("miejsce_rejestracji");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Panstwowosc)
                .HasMaxLength(3)
                .HasColumnName("panstwowosc");
            entity.Property(e => e.Siedziba)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("siedziba");
            entity.Property(e => e.TypOrganizacji)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("typ_organizacji");
        });

        modelBuilder.Entity<HodOsoby>(entity =>
        {
            entity.HasKey(e => e.IdOsoba).HasName("hod_osoby_pk");

            entity.ToTable("hod_osoby");

            entity.Property(e => e.IdOsoba)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_osoba");
            entity.Property(e => e.Imie)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("imie");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwisko");
        });

        modelBuilder.Entity<HodOtrzymaneTytuly>(entity =>
        {
            entity.HasKey(e => e.IdOtrzymane).HasName("hod_otrzymane_tytuly_pk");

            entity.ToTable("hod_otrzymane_tytuly");

            entity.Property(e => e.IdOtrzymane)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_otrzymane");
            entity.Property(e => e.DataOtrzymania).HasColumnName("data_otrzymania");
            entity.Property(e => e.HodKatalogWystawyHodRingIdRingu)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_katalog_wystawy_hod_ring_id_ringu");
            entity.Property(e => e.HodKatalogWystawyIdKatalog)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_katalog_wystawy_id_katalog");
            entity.Property(e => e.HodTytulyIdTytulu)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_tytuly_id_tytulu");
            entity.Property(e => e.Sedzia)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("sedzia");

            entity.HasOne(d => d.HodKatalogWystawyIdKatalogNavigation).WithMany(p => p.HodOtrzymaneTytulies)
                .HasForeignKey(d => d.HodKatalogWystawyIdKatalog)
                .HasConstraintName("hod_otrzymane_tytuly_hod_katalog_wystawy_fk");

            entity.HasOne(d => d.HodTytulyIdTytuluNavigation).WithMany(p => p.HodOtrzymaneTytulies)
                .HasForeignKey(d => d.HodTytulyIdTytulu)
                .HasConstraintName("hod_otrzymane_tytuly_hod_tytuly_fk");
        });

        modelBuilder.Entity<HodPiesWhodowliView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("hod_piesWHodowli_view");

            entity.Property(e => e.DataUrodzenia).HasColumnName("data_urodzenia");
            entity.Property(e => e.Masc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("masc");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.NazwaPsa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nazwa_psa");
            entity.Property(e => e.NrRodowodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_rodowodu");
            entity.Property(e => e.Plec)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("plec");
            entity.Property(e => e.RejOddzialowa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rej_oddzialowa");
        });

        modelBuilder.Entity<HodPlec>(entity =>
        {
            entity.ToTable("hod_plec");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nazwa");
        });

        modelBuilder.Entity<HodPy>(entity =>
        {
            entity.HasKey(e => e.IdPsa).HasName("hod_pies_pk");

            entity.ToTable("hod_pies");

            entity.Property(e => e.IdPsa)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_psa");
            entity.Property(e => e.DataTatuazu).HasColumnName("data_tatuazu");
            entity.Property(e => e.DataUrodzenia).HasColumnName("data_urodzenia");
            entity.Property(e => e.DataWszczepienia).HasColumnName("data_wszczepienia");
            entity.Property(e => e.HodHodowlaIdHodowli)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_hodowla_id_hodowli");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa");
            entity.Property(e => e.HodPiesIdPsa2)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa2");
            entity.Property(e => e.HodRasyIdRasy)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_rasy_id_rasy");
            entity.Property(e => e.Masc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("masc");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.NrRodowodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nr_rodowodu");
            entity.Property(e => e.NumerMikroczipu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numer_mikroczipu");
            entity.Property(e => e.NumerTatuazu)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("numer_tatuazu");
            entity.Property(e => e.PlecDonotuse)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("plecDONOTUSE");
            entity.Property(e => e.RejOddzialowa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rej_oddzialowa");
            entity.Property(e => e.RodzajMikroczipu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rodzaj_mikroczipu");
            entity.Property(e => e.TypOkrywyWlosowej)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("typ_okrywy_wlosowej");
            entity.Property(e => e.Umiejscowienie)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("umiejscowienie");

            entity.HasOne(d => d.HodHodowlaIdHodowliNavigation).WithMany(p => p.HodPies)
                .HasForeignKey(d => d.HodHodowlaIdHodowli)
                .HasConstraintName("hod_pies_hod_hodowla_fk");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.InverseHodPiesIdPsaNavigation)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_pies_hod_pies_fk");

            entity.HasOne(d => d.HodPiesIdPsa2Navigation).WithMany(p => p.InverseHodPiesIdPsa2Navigation)
                .HasForeignKey(d => d.HodPiesIdPsa2)
                .HasConstraintName("hod_pies_hod_pies_fkv1");

            entity.HasOne(d => d.HodRasyIdRasyNavigation).WithMany(p => p.HodPies)
                .HasForeignKey(d => d.HodRasyIdRasy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_pies_hod_rasy_fk");
        });

        modelBuilder.Entity<HodRasy>(entity =>
        {
            entity.HasKey(e => e.IdRasy).HasName("hod_rasy_pk");

            entity.ToTable("hod_rasy");

            entity.HasIndex(e => e.IdRasy, "hod_rasy_id_rasy_un").IsUnique();

            entity.Property(e => e.IdRasy)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("ID_RASY");
            entity.Property(e => e.Grupa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("grupa");
            entity.Property(e => e.IsFci)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("is_fci");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.NrGrupy)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("nr_grupy");
        });

        modelBuilder.Entity<HodRing>(entity =>
        {
            entity.HasKey(e => e.IdRingu).HasName("hod_ring_pk");

            entity.ToTable("hod_ring");

            entity.Property(e => e.IdRingu)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_ringu");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nazwa");
        });

        modelBuilder.Entity<HodRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hod_role_pk");

            entity.ToTable("hod_role");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id");
            entity.Property(e => e.CzyAdmin)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("czy_admin");
            entity.Property(e => e.Klient)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("klient");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Slug)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("slug");
            entity.Property(e => e.Spotkanie)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("spotkanie");
            entity.Property(e => e.Usluga)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("usluga");
            entity.Property(e => e.UstawieniaSystemowe)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("ustawienia_systemowe");
            entity.Property(e => e.UstawieniaUzytkownika)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("ustawienia_uzytkownika");
            entity.Property(e => e.Uzytkownik)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("uzytkownik");
        });

        modelBuilder.Entity<HodRozrod>(entity =>
        {
            entity.HasKey(e => e.IdRozrod).HasName("hod_rozrod_pk");

            entity.ToTable("hod_rozrod");

            entity.Property(e => e.IdRozrod)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_rozrod");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa");
            entity.Property(e => e.PerwszaCieczka)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("perwsza_cieczka");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodRozrods)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_rozrod_hod_pies_fk");
        });

        modelBuilder.Entity<HodSedziowie>(entity =>
        {
            entity.HasKey(e => e.IdSedzia).HasName("hod_sedziowie_pk");

            entity.ToTable("hod_sedziowie");

            entity.Property(e => e.IdSedzia)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_sedzia");
            entity.Property(e => e.HodStowarzyszeniaIdOrganizacji)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_stowarzyszenia_id_organizacji");
            entity.Property(e => e.IdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_osoba");

            entity.HasOne(d => d.HodStowarzyszeniaIdOrganizacjiNavigation).WithMany(p => p.HodSedziowies)
                .HasForeignKey(d => d.HodStowarzyszeniaIdOrganizacji)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_sedziowie_hod_stowarzyszenia_fk");

            entity.HasOne(d => d.IdOsobaNavigation).WithMany(p => p.HodSedziowies)
                .HasForeignKey(d => d.IdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_sedziowie_hod_osoby_fk");
        });

        modelBuilder.Entity<HodSekretarzDostawca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hod_sekretarz_dostawca");

            entity.Property(e => e.HodUsersId)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_users_id");
            entity.Property(e => e.HodUsersId2)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_users_id2");

            entity.HasOne(d => d.HodUsers).WithMany()
                .HasForeignKey(d => d.HodUsersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_sekretarz_dostawca_hod_users_fk");

            entity.HasOne(d => d.HodUsersId2Navigation).WithMany()
                .HasForeignKey(d => d.HodUsersId2)
                .HasConstraintName("hod_sekretarz_dostawca_hod_users_fkv1");
        });

        modelBuilder.Entity<HodSpecjalizacja>(entity =>
        {
            entity.HasKey(e => e.IdSpecjalizacja).HasName("hod_specjalizacja_pk");

            entity.ToTable("hod_specjalizacja");

            entity.Property(e => e.IdSpecjalizacja)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_specjalizacja");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Typ)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("typ");
        });

        modelBuilder.Entity<HodSpotkanie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hod_spotkanie_pk");

            entity.ToTable("hod_spotkanie");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id");
            entity.Property(e => e.DataUmowienia)
                .HasColumnType("datetime")
                .HasColumnName("data_umowienia");
            entity.Property(e => e.Hash1)
                .IsUnicode(false)
                .HasColumnName("hash1");
            entity.Property(e => e.HodUsersId)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_users_id");
            entity.Property(e => e.HodUsersId2)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_users_id2");
            entity.Property(e => e.HodUslugaId)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_usluga_id");
            entity.Property(e => e.IdGoogleCalendar)
                .IsUnicode(false)
                .HasColumnName("id_google_calendar");
            entity.Property(e => e.JestNiedostepny)
                .HasDefaultValueSql("('0')")
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("jest_niedostepny");
            entity.Property(e => e.KoniecSpotkania)
                .HasColumnType("datetime")
                .HasColumnName("koniec_spotkania");
            entity.Property(e => e.PoczatekSpotkania)
                .HasColumnType("datetime")
                .HasColumnName("poczatek_spotkania");
            entity.Property(e => e.Uwagi)
                .IsUnicode(false)
                .HasColumnName("uwagi");

            entity.HasOne(d => d.HodUsers).WithMany(p => p.HodSpotkanieHodUsers)
                .HasForeignKey(d => d.HodUsersId)
                .HasConstraintName("hod_spotkanie_hod_users_fk");

            entity.HasOne(d => d.HodUsersId2Navigation).WithMany(p => p.HodSpotkanieHodUsersId2Navigations)
                .HasForeignKey(d => d.HodUsersId2)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hod_spotkanie_hod_users_fkv1");

            entity.HasOne(d => d.HodUsluga).WithMany(p => p.HodSpotkanies)
                .HasForeignKey(d => d.HodUslugaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("hod_spotkanie_hod_usluga_fk");
        });

        modelBuilder.Entity<HodStowarzyszenium>(entity =>
        {
            entity.HasKey(e => e.IdOrganizacji).HasName("hod_stowarzyszenia_pk");

            entity.ToTable("hod_stowarzyszenia");

            entity.Property(e => e.IdOrganizacji)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_organizacji");

            entity.HasOne(d => d.IdOrganizacjiNavigation).WithOne(p => p.HodStowarzyszenium)
                .HasForeignKey<HodStowarzyszenium>(d => d.IdOrganizacji)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_stowarzyszenia_hod_organizacje_fk");
        });

        modelBuilder.Entity<HodTytuly>(entity =>
        {
            entity.HasKey(e => e.IdTytulu).HasName("hod_tytuly_pk");

            entity.ToTable("hod_tytuly");

            entity.Property(e => e.IdTytulu)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_tytulu");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nazwa");
        });

        modelBuilder.Entity<HodUprawnienium>(entity =>
        {
            entity.HasKey(e => e.IdUprawnienia).HasName("hod_uprawnienia_pk");

            entity.ToTable("hod_uprawnienia");

            entity.Property(e => e.IdUprawnienia)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_uprawnienia");
            entity.Property(e => e.HodSedziowieIdSedzia)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_sedziowie_Id_sedzia");
            entity.Property(e => e.IdRasa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_rasa");
            entity.Property(e => e.Ranga)
                .HasMaxLength(20)
                .HasColumnName("ranga");

            entity.HasOne(d => d.HodSedziowieIdSedziaNavigation).WithMany(p => p.HodUprawnienia)
                .HasForeignKey(d => d.HodSedziowieIdSedzia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hod_uprawnienia_hod_sedziowie");
        });

        modelBuilder.Entity<HodUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hod_users_pk");

            entity.ToTable("hod_users");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Adres)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Email)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.HodRoleId)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_role_id");
            entity.Property(e => e.Id1)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id1");
            entity.Property(e => e.Imie)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("imie");
            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("kod_pocztowy");
            entity.Property(e => e.Komorka)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("komorka");
            entity.Property(e => e.Miasto)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("miasto");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("nazwisko");
            entity.Property(e => e.Telefon)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("telefon");
            entity.Property(e => e.Uwagi)
                .IsUnicode(false)
                .HasColumnName("uwagi");
            entity.Property(e => e.Wojewodztwo)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("wojewodztwo");

            entity.HasOne(d => d.HodRole).WithMany(p => p.HodUsers)
                .HasForeignKey(d => d.HodRoleId)
                .HasConstraintName("hod_users_hod_role_fk");

            entity.HasMany(d => d.HodUslugas).WithMany(p => p.HodUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "HodDostwcaUslug",
                    r => r.HasOne<HodUsluga>().WithMany()
                        .HasForeignKey("HodUslugaId")
                        .HasConstraintName("hod_dostwca_uslug_hod_usluga_fk"),
                    l => l.HasOne<HodUser>().WithMany()
                        .HasForeignKey("HodUsersId")
                        .HasConstraintName("hod_dostwca_uslug_hod_users_fk"),
                    j =>
                    {
                        j.HasKey("HodUsersId", "HodUslugaId").HasName("hod_dostwca_uslug_pk");
                        j.ToTable("hod_dostwca_uslug");
                        j.IndexerProperty<decimal>("HodUsersId")
                            .HasColumnType("numeric(28, 0)")
                            .HasColumnName("hod_users_id");
                        j.IndexerProperty<decimal>("HodUslugaId")
                            .HasColumnType("numeric(28, 0)")
                            .HasColumnName("hod_usluga_id");
                    });
        });

        modelBuilder.Entity<HodUsluga>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hod_usluga_pk");

            entity.ToTable("hod_usluga");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Cena)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("cena");
            entity.Property(e => e.CzasTrwania)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("czas_trwania");
            entity.Property(e => e.DostepnyTyp)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("flexible")
                .HasColumnName("dostepny_typ");
            entity.Property(e => e.HodKategoriaUslugiId)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_kategoria_uslugi_id");
            entity.Property(e => e.LiczbaPersonelu)
                .HasDefaultValueSql("('1')")
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("liczba_personelu");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Opis)
                .IsUnicode(false)
                .HasColumnName("opis");
            entity.Property(e => e.Waluta)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("waluta");

            entity.HasOne(d => d.HodKategoriaUslugi).WithMany(p => p.HodUslugas)
                .HasForeignKey(d => d.HodKategoriaUslugiId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hod_usluga_hod_kategoria_uslugi_fk");
        });

        modelBuilder.Entity<HodUstawieniaUzytkownika>(entity =>
        {
            entity.HasKey(e => e.HodUsersId).HasName("hod_ustawienia_uzytkownika_pk");

            entity.ToTable("hod_ustawienia_uzytkownika");

            entity.Property(e => e.HodUsersId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_users_id");
            entity.Property(e => e.CalendarView)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("default")
                .HasColumnName("calendar_view");
            entity.Property(e => e.GoogleCalendar)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("google_calendar");
            entity.Property(e => e.GoogleSync)
                .HasDefaultValueSql("('0')")
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("google_sync");
            entity.Property(e => e.GoogleToken)
                .IsUnicode(false)
                .HasColumnName("google_token");
            entity.Property(e => e.Haslo)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("haslo");
            entity.Property(e => e.Nazwauzytkownika)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("nazwauzytkownika");
            entity.Property(e => e.Notifications)
                .HasDefaultValueSql("('0')")
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("notifications");
            entity.Property(e => e.PlanPracy)
                .IsUnicode(false)
                .HasColumnName("plan_pracy");
            entity.Property(e => e.Salt)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("salt");
            entity.Property(e => e.SyncFutureDays)
                .HasDefaultValueSql("('5')")
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("sync_future_days");
            entity.Property(e => e.SyncPastDays)
                .HasDefaultValueSql("('5')")
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("sync_past_days");

            entity.HasOne(d => d.HodUsers).WithOne(p => p.HodUstawieniaUzytkownika)
                .HasForeignKey<HodUstawieniaUzytkownika>(d => d.HodUsersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_ustawienia_uzytkownika_hod_users_fk");
        });

        modelBuilder.Entity<HodUstawienium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hod_ustawienia_pk");

            entity.ToTable("hod_ustawienia");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Wartosc)
                .IsUnicode(false)
                .HasColumnName("wartosc");
        });

        modelBuilder.Entity<HodUzytkownik>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hod_uzytkownik");

            entity.HasIndex(e => e.IdOsoba, "hod_uzytkownik_id_osoba_un").IsUnique();

            entity.Property(e => e.IdOsoba)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_osoba");

            entity.HasOne(d => d.IdOsobaNavigation).WithOne()
                .HasForeignKey<HodUzytkownik>(d => d.IdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_uzytkownik_hod_osoby_fk");
        });

        modelBuilder.Entity<HodWersja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hod_wersja");

            entity.Property(e => e.Wersja)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("wersja");
        });

        modelBuilder.Entity<HodWeterynarz>(entity =>
        {
            entity.HasKey(e => e.IdOsoba).HasName("hod_weterynarz_pk");

            entity.ToTable("hod_weterynarz");

            entity.Property(e => e.IdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_osoba");
            entity.Property(e => e.NrPwz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nr_pwz");

            entity.HasOne(d => d.IdOsobaNavigation).WithOne(p => p.HodWeterynarz)
                .HasForeignKey<HodWeterynarz>(d => d.IdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_weterynarz_hod_osoby_fk");

            entity.HasMany(d => d.HodSpecjalizacjaIdSpecjalizacjas).WithMany(p => p.HodWeterynarzIdOsobas)
                .UsingEntity<Dictionary<string, object>>(
                    "HodWeterynarzmaspecjalizje",
                    r => r.HasOne<HodSpecjalizacja>().WithMany()
                        .HasForeignKey("HodSpecjalizacjaIdSpecjalizacja")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("weterynarzmaspecjalizje_hod_specjalizacja_fk"),
                    l => l.HasOne<HodWeterynarz>().WithMany()
                        .HasForeignKey("HodWeterynarzIdOsoba")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("weterynarzmaspecjalizje_hod_weterynarz_fk"),
                    j =>
                    {
                        j.HasKey("HodWeterynarzIdOsoba", "HodSpecjalizacjaIdSpecjalizacja").HasName("weterynarzmaspecjalizje_pk");
                        j.ToTable("hod_weterynarzmaspecjalizje");
                        j.IndexerProperty<decimal>("HodWeterynarzIdOsoba")
                            .HasColumnType("numeric(28, 0)")
                            .HasColumnName("hod_weterynarz_id_osoba");
                        j.IndexerProperty<decimal>("HodSpecjalizacjaIdSpecjalizacja")
                            .HasColumnType("numeric(28, 0)")
                            .HasColumnName("hod_specjalizacja_id_specjalizacja");
                    });
        });

        modelBuilder.Entity<HodWlasciciel>(entity =>
        {
            entity.HasKey(e => e.IdOsoba).HasName("hod_wlasciciel_pk");

            entity.ToTable("hod_wlasciciel");

            entity.Property(e => e.IdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_osoba");

            entity.HasOne(d => d.IdOsobaNavigation).WithOne(p => p.HodWlasciciel)
                .HasForeignKey<HodWlasciciel>(d => d.IdOsoba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hod_wlasciciel_hod_osoby_fk");
        });

        modelBuilder.Entity<HodWlascicielPy>(entity =>
        {
            entity.HasKey(e => e.IdWlascicielPies).HasName("hod_wlasciciel_pies_pk");

            entity.ToTable("hod_wlasciciel_pies");

            entity.Property(e => e.IdWlascicielPies)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_wlasciciel_pies");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa");
            entity.Property(e => e.HodWlascicielIdOsoba)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_wlasciciel_id_osoba");
            entity.Property(e => e.Udzial)
                .HasDefaultValue(50m)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("udzial");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodWlascicielPies)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_wlasciciel_pies_hod_pies_fk");

            entity.HasOne(d => d.HodWlascicielIdOsobaNavigation).WithMany(p => p.HodWlascicielPies)
                .HasForeignKey(d => d.HodWlascicielIdOsoba)
                .HasConstraintName("hod_wlasciciel_pies_hod_wlasciciel_fk");
        });

        modelBuilder.Entity<HodWystwa>(entity =>
        {
            entity.HasKey(e => e.IdWystwa).HasName("hod_wystwa_pk");

            entity.ToTable("hod_wystwa");

            entity.Property(e => e.IdWystwa)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_wystwa");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.DaneGps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dane_gps");
            entity.Property(e => e.DataDo).HasColumnName("data_do");
            entity.Property(e => e.DataOd).HasColumnName("data_od");
            entity.Property(e => e.Miasto)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("miasto");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Panstwo)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("panstwo");
            entity.Property(e => e.Ranga)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ranga");
        });

        modelBuilder.Entity<HodZabiegi>(entity =>
        {
            entity.HasKey(e => e.IdZabieg).HasName("hod_zabiegi_pk");

            entity.ToTable("hod_zabiegi");

            entity.Property(e => e.IdZabieg)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_zabieg");
            entity.Property(e => e.DataZabiegu).HasColumnName("data_zabiegu");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa");
            entity.Property(e => e.KodKreskowy)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("kod_kreskowy");
            entity.Property(e => e.RodzajZabiegu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Szczepienie")
                .HasColumnName("rodzaj_zabiegu");
            entity.Property(e => e.Uwagi)
                .IsUnicode(false)
                .HasColumnName("uwagi");
            entity.Property(e => e.WymaganaDataNastepnego).HasColumnName("wymagana_data_nastepnego");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodZabiegis)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_zabiegi_hod_pies_fk");
        });

        modelBuilder.Entity<HodZapobieganieCiazy>(entity =>
        {
            entity.HasKey(e => e.IdZapobieganie).HasName("hod_zapobieganie_ciazy_pk");

            entity.ToTable("hod_zapobieganie_ciazy");

            entity.Property(e => e.IdZapobieganie)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id_zapobieganie");
            entity.Property(e => e.DataWykonania)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("data_wykonania");
            entity.Property(e => e.HodPiesIdPsa)
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("hod_pies_id_psa");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Opis)
                .IsUnicode(false)
                .HasColumnName("opis");
            entity.Property(e => e.Rodzaj)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rodzaj");

            entity.HasOne(d => d.HodPiesIdPsaNavigation).WithMany(p => p.HodZapobieganieCiazies)
                .HasForeignKey(d => d.HodPiesIdPsa)
                .HasConstraintName("hod_zapobieganie_ciazy_hod_pies_fk");
        });

        modelBuilder.Entity<HodZgody>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hod_zgody_pk");

            entity.ToTable("hod_zgody");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(28, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Imie)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("imie");
            entity.Property(e => e.Ip)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("nazwisko");
            entity.Property(e => e.Typ)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.Utworzone)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("utworzone");
            entity.Property(e => e.Zmodyfikowany)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("zmodyfikowany");
        });

        modelBuilder.Entity<ImpPrzydomki>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("imp_przydomki");

            entity.Property(e => e.Hodowla)
                .HasMaxLength(1)
                .HasColumnName("HODOWLA");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Przydomek)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PRZYDOMEK");
            entity.Property(e => e.Przynaleznosc)
                .HasMaxLength(1)
                .HasColumnName("PRZYNALEZNOSC");
        });

        modelBuilder.Entity<ImpRasy3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMP_RASY3");

            entity.Property(e => e.Grupa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("GRUPA");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.IsFci)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("is_fci");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAZWA");
            entity.Property(e => e.NrGrupy).HasColumnName("nr_grupy");
        });

        modelBuilder.Entity<KlasaLookup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("klasa_lookup");

            entity.Property(e => e.DoIleMiesiecy).HasColumnName("DO_ILE_MIESIECY");
            entity.Property(e => e.KlasaId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("KLASA_ID");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .HasColumnName("NAZWA");
            entity.Property(e => e.OdIleMiesiecy).HasColumnName("OD_ILE_MIESIECY");
            entity.Property(e => e.TypOceny)
                .HasMaxLength(1)
                .HasColumnName("TYP_OCENY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
