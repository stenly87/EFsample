using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfApp19;

public partial class _1125StudentsContext : DbContext
{
    public _1125StudentsContext()
    {
    }

    public _1125StudentsContext(DbContextOptions<_1125StudentsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CrossPrepodDiscipline> CrossPrepodDisciplines { get; set; }

    public virtual DbSet<Curator> Curators { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Special> Specials { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<TblDiscipline> TblDisciplines { get; set; }

    public virtual DbSet<TblJournal> TblJournals { get; set; }

    public virtual DbSet<TblPosition> TblPositions { get; set; }

    public virtual DbSet<TblPrepod> TblPrepods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.200.13;user=student;password=student;database=1125_students", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.38-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<CrossPrepodDiscipline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("crossPrepodDiscipline");

            entity.HasIndex(e => e.IdDiscipline, "FK_crossPrepodDiscipline_tbl_discipline_id");

            entity.HasIndex(e => e.IdPrepod, "FK_crossPrepodDiscipline_tbl_prepods_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DayOfWeek)
                .HasColumnType("int(11)")
                .HasColumnName("dayOfWeek");
            entity.Property(e => e.IdDiscipline)
                .HasColumnType("int(11)")
                .HasColumnName("idDiscipline");
            entity.Property(e => e.IdPrepod)
                .HasColumnType("int(11)")
                .HasColumnName("idPrepod");

            entity.HasOne(d => d.IdDisciplineNavigation).WithMany(p => p.CrossPrepodDisciplines)
                .HasForeignKey(d => d.IdDiscipline)
                .HasConstraintName("FK_crossPrepodDiscipline_tbl_discipline_id");

            entity.HasOne(d => d.IdPrepodNavigation).WithMany(p => p.CrossPrepodDisciplines)
                .HasForeignKey(d => d.IdPrepod)
                .HasConstraintName("FK_crossPrepodDiscipline_tbl_prepods_id");
        });

        modelBuilder.Entity<Curator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("curator");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Birthday)
                .HasMaxLength(255)
                .HasColumnName("birthday");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("lastName");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("group");

            entity.HasIndex(e => e.CuratorId, "FK_group_curator_id");

            entity.HasIndex(e => e.SpecialId, "FK_group_specials_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CuratorId)
                .HasColumnType("int(11)")
                .HasColumnName("curator_id");
            entity.Property(e => e.SpecialId)
                .HasColumnType("int(11)")
                .HasColumnName("special_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Year)
                .HasColumnType("int(11)")
                .HasColumnName("year");

            entity.HasOne(d => d.Curator).WithMany(p => p.Groups)
                .HasForeignKey(d => d.CuratorId)
                .HasConstraintName("FK_group_curator_id");

            entity.HasOne(d => d.Special).WithMany(p => p.Groups)
                .HasForeignKey(d => d.SpecialId)
                .HasConstraintName("FK_group_specials_id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Product");

            entity.Property(e => e.Column1).HasMaxLength(50);
            entity.Property(e => e.Column10).HasMaxLength(50);
            entity.Property(e => e.Column11).HasMaxLength(100);
            entity.Property(e => e.Column12).HasMaxLength(50);
            entity.Property(e => e.Column2).HasMaxLength(50);
            entity.Property(e => e.Column3).HasMaxLength(50);
            entity.Property(e => e.Column4).HasMaxLength(50);
            entity.Property(e => e.Column5).HasMaxLength(50);
            entity.Property(e => e.Column6).HasMaxLength(50);
            entity.Property(e => e.Column7).HasMaxLength(50);
            entity.Property(e => e.Column8).HasMaxLength(50);
            entity.Property(e => e.Column9).HasMaxLength(50);
        });

        modelBuilder.Entity<Special>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("specials");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("student");

            entity.HasIndex(e => e.GroupId, "FK_student_group_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("firstName");
            entity.Property(e => e.GroupId)
                .HasColumnType("int(11)")
                .HasColumnName("group_id");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("lastName");
            entity.Property(e => e.PatronymicName)
                .HasMaxLength(255)
                .HasColumnName("patronymicName");

            entity.HasOne(d => d.Group).WithMany(p => p.Students)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_student_group_id");
        });

        modelBuilder.Entity<TblDiscipline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_discipline");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<TblJournal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_journal");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.DisciplineId)
                .HasColumnType("int(11)")
                .HasColumnName("discipline_id");
            entity.Property(e => e.StudentId)
                .HasColumnType("int(11)")
                .HasColumnName("student_id");
            entity.Property(e => e.Value)
                .HasMaxLength(20)
                .HasColumnName("value");
        });

        modelBuilder.Entity<TblPosition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_position");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<TblPrepod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_prepods");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("lastName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
