using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace axosnet.Models
{
    public partial class axosnet_dbContext : DbContext
    {
        public axosnet_dbContext()
        {
        }

        public axosnet_dbContext(DbContextOptions<axosnet_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RecibosTbl> RecibosTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=axosnet_db;Trusted_Connection=True;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecibosTbl>(entity =>
            {
                entity.HasKey(e => e.ReciboId)
                    .HasName("PK__RecibosT__ACE0C6E695E5BC5C");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
