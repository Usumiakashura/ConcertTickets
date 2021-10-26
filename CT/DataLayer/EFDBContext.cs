using DataLayer.Entityes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class EFDBContext : DbContext
    {
        public DbSet<ClassicMusic> ClassicMusics { get; set; }
        public DbSet<OpenAir> OpenAirs { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<VoiceType> VoiceTypes { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<ConcertType> ConcertTypes { get; set; }
        public DbSet<InfoAboutTypeConcert> InfoAboutTypeConcerts { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservedTicket>().HasKey(u => new { u.UserId, u.TicketId });
            modelBuilder.Entity<BuyTicket>().HasKey(u => new { u.UserId, u.TicketId });
        }

        
    }

    //
    // For Migrations
    //

    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebConcertTickets;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataLayer"));

            return new EFDBContext(optionsBuilder.Options);
        }
    }

}
