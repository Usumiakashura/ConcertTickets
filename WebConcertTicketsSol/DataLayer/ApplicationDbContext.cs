using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entityes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataLayer
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
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
        public DbSet<User> UsersAll { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<InfoAboutTicket>().HasKey(u => new { u.UserId, u.TicketId, u.StatusTicketId });
            modelBuilder.Entity<InfoAboutDeleteTicket>().HasKey(u => new { u.UserId, u.DeletedTicketId, u.StatusTicketId });
        }

    }

    //
    // For Migrations
    //

    public class EFDBContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Web_ConcertTickets;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataLayer"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }

}
