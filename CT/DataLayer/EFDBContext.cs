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
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<InfoAboutTicket> InfoAboutTickets { get; set; }
        public DbSet<InfoAboutDeleteTicket> InfoAboutDeleteTickets { get; set; }
        public DbSet<StatusTicket> StatusTickets { get; set; }
        public DbSet<DeletedTicket> DeletedTickets { get; set; }
        public DbSet<User> Users { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InfoAboutTicket>().HasKey(u => new { u.UserId, u.TicketId, u.StatusTicketId });
            modelBuilder.Entity<InfoAboutDeleteTicket>().HasKey(u => new { u.UserId, u.DeletedTicketId, u.StatusTicketId });
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
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Web_ConcertTickets;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataLayer"));

            return new EFDBContext(optionsBuilder.Options);
        }
    }

}
