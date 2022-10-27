using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HandsOnEFDBFirst.Entities
{
    public partial class TrainingDBContext : DbContext
    {
        public TrainingDBContext()
        {
        }

        public TrainingDBContext(DbContextOptions<TrainingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AuditSalary> AuditSalaries { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Emp> Emps { get; set; } = null!;
        public virtual DbSet<EmpView> EmpViews { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<First> Firsts { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<ParticipantList> ParticipantLists { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Second> Seconds { get; set; } = null!;
        public virtual DbSet<Table1> Table1s { get; set; } = null!;
        public virtual DbSet<Table2> Table2s { get; set; } = null!;
        public virtual DbSet<ViewEmpDept> ViewEmpDepts { get; set; } = null!;
        public virtual DbSet<ViewEmpHr> ViewEmpHrs { get; set; } = null!;
        public virtual DbSet<ViewEmpIt> ViewEmpIts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SANTU\\MSSQLSERVER2019;Database=TrainingDB;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Acno)
                    .HasName("PK__accounts__57FB58BB204985C0");

                entity.ToTable("accounts");

                entity.Property(e => e.Acno)
                    .ValueGeneratedNever()
                    .HasColumnName("acno");

                entity.Property(e => e.Bal)
                    .HasColumnType("money")
                    .HasColumnName("bal");
            });

            modelBuilder.Entity<AuditSalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AuditSalary");

                entity.Property(e => e.AuditId).ValueGeneratedOnAdd();

                entity.Property(e => e.NewSalary)
                    .HasColumnType("money")
                    .HasColumnName("New_Salary");

                entity.Property(e => e.OldSalary)
                    .HasColumnType("money")
                    .HasColumnName("Old_Salary");

                entity.HasOne(d => d.EidNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Eid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__AuditSalary__Eid__787EE5A0");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__Departme__C031221870820A56");

                entity.ToTable("Department");

                entity.HasIndex(e => e.Dname, "UQ__Departme__83BFD8490994325D")
                    .IsUnique();

                entity.Property(e => e.Did)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("emp");

                entity.Property(e => e.Empid).HasColumnName("empid");

                entity.Property(e => e.Empname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("empname");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmpView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("emp_view");

                entity.Property(e => e.Ename)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Employee__C1971B53BC0A9775");

                entity.ToTable("Employee");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Did)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ename)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.HasOne(d => d.DidNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Did)
                    .HasConstraintName("FK__Employee__Did__403A8C7D");
            });

            modelBuilder.Entity<First>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("First");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Gender");

                entity.Property(e => e.Gender1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Login");

                entity.Property(e => e.Pwd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany()
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Login__EmpId__75A278F5");
            });

            modelBuilder.Entity<ParticipantList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ParticipantList");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OfficialEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipantId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ParticipantID");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("person");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.PersonName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("person_name");

                entity.Property(e => e.Pid).HasColumnName("pid");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("pid_pk");

                entity.ToTable("product");

                entity.HasIndex(e => e.Pname, "UQ__product__1FC9734CE61B20A3")
                    .IsUnique();

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__project__C5705938949E24DD");

                entity.ToTable("project");

                entity.Property(e => e.Pid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Second>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Second");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table1");

                entity.Property(e => e.Col1).HasColumnName("col1");
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("table2");

                entity.Property(e => e.Col1).HasColumnName("col1");
            });

            modelBuilder.Entity<ViewEmpDept>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_Emp_Dept");

                entity.Property(e => e.Dname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEmpHr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Emp_HR");

                entity.Property(e => e.Did)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ename)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<ViewEmpIt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Emp_IT");

                entity.Property(e => e.Did)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ename)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
