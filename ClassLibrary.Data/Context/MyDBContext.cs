using System;
using System.Collections.Generic;
using ClassLibrary.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data.Context;

public partial class MyDBContext : DbContext
{
    public MyDBContext()
    {
    }

    public MyDBContext(DbContextOptions<MyDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contacts> Contacts { get; set; }

    public virtual DbSet<MyTable> MyTable { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-AU7DKKHQ\\SQLEXPRESS;Database=MyDatabase;User Id=sadmin;Password=abcd1234abcd1234;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contacts>(entity =>
        {
            entity.HasKey(e => e.ContactsId).HasName("PK__Contacts__912F37AB66145B66");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.MyTable).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.MyTableId)
                .HasConstraintName("MyTableId_cm_key");
        });

        modelBuilder.Entity<MyTable>(entity =>
        {
            entity.HasKey(e => e.MyTableId).HasName("PK__MyTable__1A983D61CEE191A5");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
