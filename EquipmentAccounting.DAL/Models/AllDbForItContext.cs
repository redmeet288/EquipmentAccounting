using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EA_DAL.Models;

public partial class AllDbForItContext : DbContext
{
    public AllDbForItContext()
    {
    }

    public AllDbForItContext(DbContextOptions<AllDbForItContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<InstalledSoftware> InstalledSoftwares { get; set; }

    public virtual DbSet<SoftwareLicense> SoftwareLicenses { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<TransferHistory> TransferHistories { get; set; }

    public virtual DbSet<TypesOfEquipment> TypesOfEquipments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=All_db_for_IT;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC074BEA7385");

            entity.Property(e => e.Director).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC070FC12B11");

            entity.HasIndex(e => e.InventoryNumber, "UQ__tmp_ms_x__D6D65CC874B52BB1").IsUnique();

            entity.Property(e => e.InventoryNumber).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.RegistrationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SerialNumber).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(20);

            entity.HasOne(d => d.ResponsibleStaff).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.ResponsibleStaffId)
                .HasConstraintName("FK_Equipment_Staff");

            entity.HasOne(d => d.Type).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_Type");
        });

        modelBuilder.Entity<InstalledSoftware>(entity =>
        {
            entity.HasKey(e => new { e.EquipmentId, e.LicenseId });

            entity.ToTable("InstalledSoftware");

            entity.Property(e => e.InstallationDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Equipment).WithMany(p => p.InstalledSoftwares)
                .HasForeignKey(d => d.EquipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InstalledSoftware_Equipment");

            entity.HasOne(d => d.License).WithMany(p => p.InstalledSoftwares)
                .HasForeignKey(d => d.LicenseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InstalledSoftware_License");
        });

        modelBuilder.Entity<SoftwareLicense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Software__3214EC07AFC0C6DB");

            entity.HasIndex(e => e.LicenseKey, "UQ__Software__45E1DD6F69BD9C3E").IsUnique();

            entity.Property(e => e.LicenseKey).HasMaxLength(100);
            entity.Property(e => e.SoftwareName).HasMaxLength(200);
            entity.Property(e => e.Vendor).HasMaxLength(100);
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Staff__3214EC0728DFAA6F");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fio).HasColumnName("FIO");
            entity.Property(e => e.IdDivision).HasColumnName("ID_Division");
            entity.Property(e => e.Post).HasMaxLength(50);

            entity.HasOne(d => d.IdDivisionNavigation).WithMany(p => p.Staff)
                .HasForeignKey(d => d.IdDivision)
                .HasConstraintName("FK_Staff_Division");
        });

        modelBuilder.Entity<TransferHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transfer__3214EC071259282F");

            entity.ToTable("TransferHistory");

            entity.Property(e => e.TransferDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Equipment).WithMany(p => p.TransferHistories)
                .HasForeignKey(d => d.EquipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferHistory_Equipment");

            entity.HasOne(d => d.NewEmployee).WithMany(p => p.TransferHistoryNewEmployees)
                .HasForeignKey(d => d.NewEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransferHistory_NewEmployee");

            entity.HasOne(d => d.OldEmployee).WithMany(p => p.TransferHistoryOldEmployees)
                .HasForeignKey(d => d.OldEmployeeId)
                .HasConstraintName("FK_TransferHistory_OldEmployee");
        });

        modelBuilder.Entity<TypesOfEquipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Types of__3214EC073F51D003");

            entity.ToTable("Types of equipment");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
