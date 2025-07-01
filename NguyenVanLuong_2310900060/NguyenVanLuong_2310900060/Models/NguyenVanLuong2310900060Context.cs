using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NguyenVanLuong_2310900060.Models;

public partial class NguyenVanLuong2310900060Context : DbContext
{
    public NguyenVanLuong2310900060Context()
    {
    }

    public NguyenVanLuong2310900060Context(DbContextOptions<NguyenVanLuong2310900060Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NvlEmployee> NvlEmployees { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=ADMIN-PC;Database=NguyenVanLuong_2310900060;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NvlEmployee>(entity =>
        {
            entity.HasKey(e => e.NvlEmpId);

            entity.ToTable("NvlEmployee");

            entity.Property(e => e.NvlEmpId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("nvlEmpId");
            entity.Property(e => e.NvlEmpLevel)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("nvlEmpLevel");
            entity.Property(e => e.NvlEmpName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("nvlEmpName");
            entity.Property(e => e.NvlEmpStartDate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nvlEmpStartDate");
            entity.Property(e => e.NvlEmpStatus).HasColumnName("nvlEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
