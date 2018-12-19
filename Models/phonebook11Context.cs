using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace phonebook.Models
{
    public partial class phonebook11Context : DbContext
    {
        public phonebook11Context()
        {
        }

        public phonebook11Context(DbContextOptions<phonebook11Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Contacts> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=den1.mysql5.gear.host;database=port=3306;database=phonebook11;userid=phonebook11;password=An6I?7zu-j31");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("contacts");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(20);
            });
        }
    }
}
