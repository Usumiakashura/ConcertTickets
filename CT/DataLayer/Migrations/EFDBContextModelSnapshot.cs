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

            modelBuilder.Entity("DataLayer.Entityes.DeletedTicket", b =>
                {
                    b.Property<int>("DelTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateConcert")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SingerDeletedConcert")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DelTicketId");

                    b.ToTable("DeletedTickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.InfoAboutDeleteTicket", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("DeletedTicketId")
                        .HasColumnType("int");

                    b.Property<int>("StatusTicketId")
                        .HasColumnType("int");

                    b.Property<int>("NumTicket")
                        .HasColumnType("int");

                    b.HasKey("UserId", "DeletedTicketId", "StatusTicketId");

                    b.HasIndex("DeletedTicketId");

                    b.HasIndex("StatusTicketId");

                    b.ToTable("InfoAboutDeleteTickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.InfoAboutTicket", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("StatusTicketId")
                        .HasColumnType("int");

                    b.Property<int>("NumTicket")
                        .HasColumnType("int");

                    b.HasKey("UserId", "TicketId", "StatusTicketId");

                    b.HasIndex("StatusTicketId");

                    b.HasIndex("TicketId");

                    b.ToTable("InfoAboutTickets");
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

            modelBuilder.Entity("DataLayer.Entityes.StatusTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StatusTickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConcertId")
                        .HasColumnType("int");

                    b.Property<long>("NumOfTickets")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketID");

                    b.HasIndex("ConcertId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
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

                    b.Property<long>("Age")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("Party");
                });

            modelBuilder.Entity("DataLayer.Entityes.InfoAboutDeleteTicket", b =>
                {
                    b.HasOne("DataLayer.Entityes.DeletedTicket", "DeletedTicket")
                        .WithMany("InfoAboutDeleteTickets")
                        .HasForeignKey("DeletedTicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entityes.StatusTicket", "StatusTicket")
                        .WithMany("InfoAboutDeleteTickets")
                        .HasForeignKey("StatusTicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entityes.User", "User")
                        .WithMany("InfoAboutDeleteTickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeletedTicket");

                    b.Navigation("StatusTicket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataLayer.Entityes.InfoAboutTicket", b =>
                {
                    b.HasOne("DataLayer.Entityes.StatusTicket", "StatusTicket")
                        .WithMany("InfoAboutTickets")
                        .HasForeignKey("StatusTicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entityes.Ticket", "Ticket")
                        .WithMany("InfoAboutTickets")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entityes.User", "User")
                        .WithMany("InfoAboutTickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StatusTicket");

                    b.Navigation("Ticket");

                    b.Navigation("User");
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

            modelBuilder.Entity("DataLayer.Entityes.Ticket", b =>
                {
                    b.HasOne("DataLayer.Entityes.Concert", "Concert")
                        .WithMany("Tickets")
                        .HasForeignKey("ConcertId");

                    b.Navigation("Concert");
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

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.ConcertType", b =>
                {
                    b.Navigation("InfoAboutTypesConcerts");
                });

            modelBuilder.Entity("DataLayer.Entityes.DeletedTicket", b =>
                {
                    b.Navigation("InfoAboutDeleteTickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.StatusTicket", b =>
                {
                    b.Navigation("InfoAboutDeleteTickets");

                    b.Navigation("InfoAboutTickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.Ticket", b =>
                {
                    b.Navigation("InfoAboutTickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.User", b =>
                {
                    b.Navigation("InfoAboutDeleteTickets");

                    b.Navigation("InfoAboutTickets");
                });

            modelBuilder.Entity("DataLayer.Entityes.VoiceType", b =>
                {
                    b.Navigation("ClassicMusics");
                });
#pragma warning restore 612, 618
        }
    }
}
