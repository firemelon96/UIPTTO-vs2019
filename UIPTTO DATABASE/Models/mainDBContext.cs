using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UIPTTO_DATABASE.Models
{
    public partial class mainDBContext : DbContext
    {
        public mainDBContext()
        {
        }

        public mainDBContext(DbContextOptions<mainDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CopyrightTable> CopyrightTables { get; set; } = null!;
        public virtual DbSet<IsbnTable> IsbnTables { get; set; } = null!;
        public virtual DbSet<IssnTable> IssnTables { get; set; } = null!;
        public virtual DbSet<PatentTable> PatentTables { get; set; } = null!;
        public virtual DbSet<ProfileTable> ProfileTables { get; set; } = null!;
        public virtual DbSet<TrademarkTable> TrademarkTables { get; set; } = null!;
        public virtual DbSet<UserTable> UserTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=DESKTOP-7549PRF\\SQLEXPRESS;initial catalog=mainDb;integrated security=True;ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CopyrightTable>(entity =>
            {
                entity.HasOne(d => d.PIdNavigation)
                    .WithMany(p => p.CopyrightTables)
                    .HasForeignKey(d => d.PId)
                    .HasConstraintName("FK_copyright_Table_profile_Table");
            });

            modelBuilder.Entity<IsbnTable>(entity =>
            {
                entity.HasOne(d => d.PIdNavigation)
                    .WithMany(p => p.IsbnTables)
                    .HasForeignKey(d => d.PId)
                    .HasConstraintName("FK_isbn_Table_profile_Table");
            });

            modelBuilder.Entity<IssnTable>(entity =>
            {
                entity.HasOne(d => d.PIdNavigation)
                    .WithMany(p => p.IssnTables)
                    .HasForeignKey(d => d.PId)
                    .HasConstraintName("FK_issn_Table_profile_Table");
            });

            modelBuilder.Entity<PatentTable>(entity =>
            {
                entity.HasOne(d => d.PIdNavigation)
                    .WithMany(p => p.PatentTables)
                    .HasForeignKey(d => d.PId)
                    .HasConstraintName("FK_patent_Table_profile_Table");
            });

            modelBuilder.Entity<ProfileTable>(entity =>
            {
                entity.Property(e => e.PGender).IsFixedLength();
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.Property(e => e.UGender).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
