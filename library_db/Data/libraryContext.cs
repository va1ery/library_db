using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using library_db.Models;

namespace library_db.Data
{
    public partial class libraryContext : DbContext
    {
        public libraryContext()
        {
        }

        public libraryContext(DbContextOptions<libraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }
        public virtual DbSet<ReturnedBooks> ReturnedBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //    optionsBuilder.UseSqlite("Data Source=C:\\Users\\leo\\Documents\\library.db");
                optionsBuilder.UseSqlServer("Data Source=LEO-ПК\\SQLEXPRESS;Initial Catalog=library_db;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BkId);

                entity.Property(e => e.BkId)
                    .HasColumnName("Bk_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.BkAuthor)
                    .HasColumnName("Bk_Author")
                    .HasColumnType("INT");

                entity.Property(e => e.BkName)
                    .HasColumnName("Bk_Name")
                    .HasColumnType("INT");

                entity.Property(e => e.BkRealiseDate)
                    .HasColumnName("Bk_Realise_Date")
                    .HasColumnType("INT");

                entity.Property(e => e.GenId)
                    .HasColumnName("Gen_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.PubId)
                    .HasColumnName("Pub_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Gen)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.GenId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pub)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PubId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpAddress)
                    .HasColumnName("Emp_Address")
                    .HasColumnType("INT");

                entity.Property(e => e.EmpAge)
                    .HasColumnName("Emp_Age")
                    .HasColumnType("INT");

                entity.Property(e => e.EmpFullName)
                    .HasColumnName("Emp_Full_Name")
                    .HasColumnType("INT");

                entity.Property(e => e.EmpPassportData)
                    .HasColumnName("Emp_Passport_Data")
                    .HasColumnType("INT");

                entity.Property(e => e.EmpPhoneNumber)
                    .HasColumnName("Emp_Phone_Number")
                    .HasColumnType("INT");

                entity.Property(e => e.EmpSex)
                    .HasColumnName("Emp_Sex")
                    .HasColumnType("INT");

                entity.Property(e => e.PosId)
                    .HasColumnName("Pos_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PosId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenId);

                entity.Property(e => e.GenId)
                    .HasColumnName("Gen_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenDescription)
                    .HasColumnName("Gen_Description")
                    .HasColumnType("INT");

                entity.Property(e => e.GenName)
                    .HasColumnName("Gen_Name")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.Property(e => e.PosId)
                    .HasColumnName("Pos_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosDuties)
                    .HasColumnName("Pos_Duties")
                    .HasColumnType("INT");

                entity.Property(e => e.PosName)
                    .HasColumnName("Pos_Name")
                    .HasColumnType("INT");

                entity.Property(e => e.PosRequirements)
                    .HasColumnName("Pos_Requirements")
                    .HasColumnType("INT");

                entity.Property(e => e.PosSalary)
                    .HasColumnName("Pos_Salary")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PubId);

                entity.Property(e => e.PubId)
                    .HasColumnName("Pub_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.PubAddress)
                    .HasColumnName("Pub_Address")
                    .HasColumnType("INT");

                entity.Property(e => e.PubCity)
                    .HasColumnName("Pub_City")
                    .HasColumnType("INT");

                entity.Property(e => e.PubName)
                    .HasColumnName("Pub_Name")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Reader>(entity =>
            {
                entity.HasKey(e => e.RdId);

                entity.Property(e => e.RdId)
                    .HasColumnName("Rd_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.RdAddress)
                    .HasColumnName("Rd_Address")
                    .HasColumnType("INT");

                entity.Property(e => e.RdBdDate)
                    .HasColumnName("Rd_BD_Date")
                    .HasColumnType("INT");

                entity.Property(e => e.RdFullName)
                    .HasColumnName("Rd_Full_Name")
                    .HasColumnType("INT");

                entity.Property(e => e.RdPassportData)
                    .HasColumnName("Rd_Passport_Data")
                    .HasColumnType("INT");

                entity.Property(e => e.RdPhoneNumber)
                    .HasColumnName("Rd_Phone_Number")
                    .HasColumnType("INT");

                entity.Property(e => e.RdSex)
                    .HasColumnName("Rd_Sex")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<ReturnedBooks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Returned_Books");

                entity.Property(e => e.BkId)
                    .HasColumnName("Bk_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.RbGiveOutDate)
                    .HasColumnName("Rb_GiveOut_Date")
                    .HasColumnType("INT");

                entity.Property(e => e.RbReturnDate)
                    .HasColumnName("Rb_Return_Date")
                    .HasColumnType("INT");

                entity.Property(e => e.RbReturnFlag)
                    .HasColumnName("Rb_Return_Flag")
                    .HasColumnType("INT");

                entity.Property(e => e.RdId)
                    .HasColumnName("Rd_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Bk)
                    .WithMany()
                    .HasForeignKey(d => d.BkId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Emp)
                    .WithMany()
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Rd)
                    .WithMany()
                    .HasForeignKey(d => d.RdId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
