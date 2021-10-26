﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(EFDBContext))]
    partial class EFDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Entityes.Concert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateConcert")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Singer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("DataLayer.Entityes.ConcertType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConcertTypes");
                });

            modelBuilder.Entity("DataLayer.Entityes.InfoAboutTypeConcert", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ConcertTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConcertTypeId");

                    b.ToTable("InfoAboutTypeConcerts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("InfoAboutTypeConcert");
                });

            modelBuilder.Entity("DataLayer.Entityes.VoiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameVoiceType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VoiceTypes");
                });

            modelBuilder.Entity("DataLayer.Entityes.ClassicMusic", b =>
                {
                    b.HasBaseType("DataLayer.Entityes.InfoAboutTypeConcert");

                    b.Property<string>("Composer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameConcert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VoiceTypeId")
                        .HasColumnType("int");

                    b.HasIndex("VoiceTypeId");

                    b.HasDiscriminator().HasValue("ClassicMusic");
                });

            modelBuilder.Entity("DataLayer.Entityes.OpenAir", b =>
                {
                    b.HasBaseType("DataLayer.Entityes.InfoAboutTypeConcert");

                    b.Property<string>("Headliner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowToGetThere")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("OpenAir");
                });

            modelBuilder.Entity("DataLayer.Entityes.Party", b =>
                {
                    b.HasBaseType("DataLayer.Entityes.InfoAboutTypeConcert");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Party");
                });

            modelBuilder.Entity("DataLayer.Entityes.InfoAboutTypeConcert", b =>
                {
                    b.HasOne("DataLayer.Entityes.ConcertType", "ConcertType")
                        .WithMany("InfoAboutTypesConcerts")
                        .HasForeignKey("ConcertTypeId");

                    b.HasOne("DataLayer.Entityes.Concert", "Concert")
                        .WithOne("InfoATC")
                        .HasForeignKey("DataLayer.Entityes.InfoAboutTypeConcert", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concert");

                    b.Navigation("ConcertType");
                });

            modelBuilder.Entity("DataLayer.Entityes.ClassicMusic", b =>
                {
                    b.HasOne("DataLayer.Entityes.VoiceType", "VoiceType")
                        .WithMany("ClassicMusics")
                        .HasForeignKey("VoiceTypeId");

                    b.Navigation("VoiceType");
                });

            modelBuilder.Entity("DataLayer.Entityes.Concert", b =>
                {
                    b.Navigation("InfoATC");
                });

            modelBuilder.Entity("DataLayer.Entityes.ConcertType", b =>
                {
                    b.Navigation("InfoAboutTypesConcerts");
                });

            modelBuilder.Entity("DataLayer.Entityes.VoiceType", b =>
                {
                    b.Navigation("ClassicMusics");
                });
#pragma warning restore 612, 618
        }
    }
}
