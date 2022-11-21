﻿// <auto-generated />
using System;
using CashRegister.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CashRegister_DAL.Migrations
{
    [DbContext(typeof(CashRegisterContextDB))]
    partial class CashRegisterContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CashRegister.Models.Beleg", b =>
                {
                    b.Property<int>("Belegnummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Belegnummer"), 1L, 1);

                    b.Property<decimal>("Gesamtpreis")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Kaufdatum")
                        .HasColumnType("datetime2");

                    b.HasKey("Belegnummer");

                    b.ToTable("Beleg");
                });

            modelBuilder.Entity("CashRegister.Models.EinkaufsPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Anzahl")
                        .HasColumnType("int");

                    b.Property<int>("Belegnummer")
                        .HasColumnType("int");

                    b.Property<int?>("ProduktId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Belegnummer");

                    b.HasIndex("ProduktId");

                    b.ToTable("EinkaufsPosition");
                });

            modelBuilder.Entity("CashRegister.Models.Kategorie", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("KategorieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MandantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MandantId");

                    b.ToTable("Kategorie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KategorieName = "Käse",
                            MandantId = 2
                        },
                        new
                        {
                            Id = 2,
                            KategorieName = "Joghurt",
                            MandantId = 2
                        },
                        new
                        {
                            Id = 3,
                            KategorieName = "Butter",
                            MandantId = 2
                        },
                        new
                        {
                            Id = 4,
                            KategorieName = "Sonstiges",
                            MandantId = 2
                        },
                        new
                        {
                            Id = 5,
                            KategorieName = "Alc.Getränke",
                            MandantId = 1
                        },
                        new
                        {
                            Id = 6,
                            KategorieName = "Non.Alc.Getränke",
                            MandantId = 1
                        },
                        new
                        {
                            Id = 7,
                            KategorieName = "Speisen",
                            MandantId = 1
                        });
                });

            modelBuilder.Entity("CashRegister.Models.Mandant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MandantName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mandant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MandantName = "Gastro"
                        },
                        new
                        {
                            Id = 2,
                            MandantName = "Sennerei"
                        });
                });

            modelBuilder.Entity("CashRegister.Models.Produkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Deaktiviert")
                        .HasColumnType("bit");

                    b.Property<int>("KategorieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preis")
                        .HasColumnType("numeric(6,3)");

                    b.Property<bool>("Preisart")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KategorieId");

                    b.ToTable("Produkt");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deaktiviert = false,
                            KategorieId = 1,
                            Name = "Mutschli",
                            Preis = 0.022m,
                            Preisart = true
                        },
                        new
                        {
                            Id = 2,
                            Deaktiviert = false,
                            KategorieId = 1,
                            Name = "Alpkäs",
                            Preis = 0.0205m,
                            Preisart = true
                        },
                        new
                        {
                            Id = 3,
                            Deaktiviert = false,
                            KategorieId = 1,
                            Name = "Ziger/Ricotta",
                            Preis = 0.022m,
                            Preisart = true
                        },
                        new
                        {
                            Id = 4,
                            Deaktiviert = false,
                            KategorieId = 2,
                            Name = "Fruchtjoghurt",
                            Preis = 2.60m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 5,
                            Deaktiviert = false,
                            KategorieId = 2,
                            Name = "Naturjoghurt",
                            Preis = 2.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 6,
                            Deaktiviert = false,
                            KategorieId = 3,
                            Name = "Modelbutter",
                            Preis = 6.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 7,
                            Deaktiviert = false,
                            KategorieId = 4,
                            Name = "Molke",
                            Preis = 2.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 9,
                            Deaktiviert = false,
                            KategorieId = 5,
                            Name = "Bier Gr.",
                            Preis = 5.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 10,
                            Deaktiviert = false,
                            KategorieId = 5,
                            Name = "Bier Kl.",
                            Preis = 4.50m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 11,
                            Deaktiviert = false,
                            KategorieId = 5,
                            Name = "Most 5cl",
                            Preis = 5.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 12,
                            Deaktiviert = false,
                            KategorieId = 5,
                            Name = "Most 3cl",
                            Preis = 3.50m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 13,
                            Deaktiviert = false,
                            KategorieId = 6,
                            Name = "Limo 33cl",
                            Preis = 4.50m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 14,
                            Deaktiviert = false,
                            KategorieId = 6,
                            Name = "Mineral 33cl",
                            Preis = 4.50m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 15,
                            Deaktiviert = false,
                            KategorieId = 6,
                            Name = "Kaffee",
                            Preis = 4.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 16,
                            Deaktiviert = false,
                            KategorieId = 6,
                            Name = "Kafi Lutz",
                            Preis = 6.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 17,
                            Deaktiviert = false,
                            KategorieId = 7,
                            Name = "Portion Käse",
                            Preis = 8.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 18,
                            Deaktiviert = false,
                            KategorieId = 7,
                            Name = "Wurst-Käsesalat",
                            Preis = 12.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 19,
                            Deaktiviert = false,
                            KategorieId = 7,
                            Name = "Salsiz",
                            Preis = 8.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 20,
                            Deaktiviert = false,
                            KategorieId = 7,
                            Name = "Salsiz mit Käse",
                            Preis = 12.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 21,
                            Deaktiviert = false,
                            KategorieId = 7,
                            Name = "Buurawurst",
                            Preis = 7.00m,
                            Preisart = false
                        },
                        new
                        {
                            Id = 22,
                            Deaktiviert = false,
                            KategorieId = 7,
                            Name = "Käseschnitte",
                            Preis = 7.00m,
                            Preisart = false
                        });
                });

            modelBuilder.Entity("CashRegister.Models.EinkaufsPosition", b =>
                {
                    b.HasOne("CashRegister.Models.Beleg", "Beleg")
                        .WithMany("EinkaufsPosition")
                        .HasForeignKey("Belegnummer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CashRegister.Models.Produkt", "Produkt")
                        .WithMany("EinkaufsPositionen")
                        .HasForeignKey("ProduktId");

                    b.Navigation("Beleg");

                    b.Navigation("Produkt");
                });

            modelBuilder.Entity("CashRegister.Models.Kategorie", b =>
                {
                    b.HasOne("CashRegister.Models.Mandant", "Mandant")
                        .WithMany("Kategorien")
                        .HasForeignKey("MandantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mandant");
                });

            modelBuilder.Entity("CashRegister.Models.Produkt", b =>
                {
                    b.HasOne("CashRegister.Models.Kategorie", "Kategorie")
                        .WithMany("Produkte")
                        .HasForeignKey("KategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategorie");
                });

            modelBuilder.Entity("CashRegister.Models.Beleg", b =>
                {
                    b.Navigation("EinkaufsPosition");
                });

            modelBuilder.Entity("CashRegister.Models.Kategorie", b =>
                {
                    b.Navigation("Produkte");
                });

            modelBuilder.Entity("CashRegister.Models.Mandant", b =>
                {
                    b.Navigation("Kategorien");
                });

            modelBuilder.Entity("CashRegister.Models.Produkt", b =>
                {
                    b.Navigation("EinkaufsPositionen");
                });
#pragma warning restore 612, 618
        }
    }
}
