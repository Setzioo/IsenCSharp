using System;
using System.Collections.Generic;
using System.Text;
using Isen.DotNet.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Isen.DotNet.Library.Context
{
    public class ApplicationDbContext : DbContext
    {
        // Collection des objets du modèle
        public DbSet<Club> ClubCollection { get; set; }
        public DbSet<Player> PlayerCollection { get; set; }

        public DbSet<Contract> ContractCollection { get; set; }

        // Constructeur avec signature obligatoire
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Préciser les tables et relations du modèle
            modelBuilder.Entity<Club>()
                .ToTable(nameof(Club));
            modelBuilder.Entity<Player>()
                .ToTable(nameof(Player));

            modelBuilder.Entity<Contract>()
                .ToTable(nameof(Contract))
                .HasOne(p => p.Club)
                .WithMany(c => c.ContractCollection)
                .HasForeignKey(p => p.ClubId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Contract>()
                .ToTable(nameof(Contract))
                .HasOne(p => p.Player)
                .WithMany(c => c.ContractCollection)
                .HasForeignKey(p => p.PlayerId)
                .OnDelete(DeleteBehavior.SetNull);

            
        }
    }
}
