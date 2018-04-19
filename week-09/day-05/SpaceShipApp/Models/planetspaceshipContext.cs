using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpaceShipApp.Models
{
    public partial class planetspaceshipContext : DbContext
    {
        public planetspaceshipContext(DbContextOptions<planetspaceshipContext> options) : base(options)
        {
        }

        public virtual DbSet<Planet> Planet { get; set; }
        public virtual DbSet<Spaceship> Spaceship { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>(entity =>
            {
                entity.ToTable("planet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Population).HasColumnName("population");
            });

            modelBuilder.Entity<Spaceship>(entity =>
            {
                entity.ToTable("spaceship");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaxCapacity).HasColumnName("max_capacity");

                entity.Property(e => e.Planet)
                    .HasColumnName("planet")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Utilization).HasColumnName("utilization");
            });
        }
    }
}
