using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NCL.Entity
{
    public partial class advanced7Context : DbContext
    {
        public advanced7Context()
        {
        }

        public advanced7Context(DbContextOptions<advanced7Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<JdCommodity001> JdCommodity001 { get; set; }
        public virtual DbSet<JdCommodity002> JdCommodity002 { get; set; }
        public virtual DbSet<JdCommodity003> JdCommodity003 { get; set; }
        public virtual DbSet<JdCommodity004> JdCommodity004 { get; set; }
        public virtual DbSet<JdCommodity005> JdCommodity005 { get; set; }
        public virtual DbSet<JdCommodity006> JdCommodity006 { get; set; }
        public virtual DbSet<JdCommodity007> JdCommodity007 { get; set; }
        public virtual DbSet<JdCommodity008> JdCommodity008 { get; set; }
        public virtual DbSet<JdCommodity009> JdCommodity009 { get; set; }
        public virtual DbSet<JdCommodity010> JdCommodity010 { get; set; }
        public virtual DbSet<JdCommodity011> JdCommodity011 { get; set; }
        public virtual DbSet<JdCommodity012> JdCommodity012 { get; set; }
        public virtual DbSet<JdCommodity013> JdCommodity013 { get; set; }
        public virtual DbSet<JdCommodity014> JdCommodity014 { get; set; }
        public virtual DbSet<JdCommodity015> JdCommodity015 { get; set; }
        public virtual DbSet<JdCommodity016> JdCommodity016 { get; set; }
        public virtual DbSet<JdCommodity017> JdCommodity017 { get; set; }
        public virtual DbSet<JdCommodity018> JdCommodity018 { get; set; }
        public virtual DbSet<JdCommodity019> JdCommodity019 { get; set; }
        public virtual DbSet<JdCommodity020> JdCommodity020 { get; set; }
        public virtual DbSet<JdCommodity021> JdCommodity021 { get; set; }
        public virtual DbSet<JdCommodity022> JdCommodity022 { get; set; }
        public virtual DbSet<JdCommodity023> JdCommodity023 { get; set; }
        public virtual DbSet<JdCommodity024> JdCommodity024 { get; set; }
        public virtual DbSet<JdCommodity025> JdCommodity025 { get; set; }
        public virtual DbSet<JdCommodity026> JdCommodity026 { get; set; }
        public virtual DbSet<JdCommodity027> JdCommodity027 { get; set; }
        public virtual DbSet<JdCommodity028> JdCommodity028 { get; set; }
        public virtual DbSet<JdCommodity029> JdCommodity029 { get; set; }
        public virtual DbSet<JdCommodity030> JdCommodity030 { get; set; }
        public virtual DbSet<UucEmployee> UucEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;database=advanced7;uid=sa;Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "3.0.0-preview3.19153.1");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity001>(entity =>
            {
                entity.ToTable("JD_Commodity_001");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity002>(entity =>
            {
                entity.ToTable("JD_Commodity_002");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity003>(entity =>
            {
                entity.ToTable("JD_Commodity_003");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity004>(entity =>
            {
                entity.ToTable("JD_Commodity_004");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity005>(entity =>
            {
                entity.ToTable("JD_Commodity_005");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity006>(entity =>
            {
                entity.ToTable("JD_Commodity_006");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity007>(entity =>
            {
                entity.ToTable("JD_Commodity_007");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity008>(entity =>
            {
                entity.ToTable("JD_Commodity_008");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity009>(entity =>
            {
                entity.ToTable("JD_Commodity_009");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity010>(entity =>
            {
                entity.ToTable("JD_Commodity_010");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity011>(entity =>
            {
                entity.ToTable("JD_Commodity_011");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity012>(entity =>
            {
                entity.ToTable("JD_Commodity_012");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity013>(entity =>
            {
                entity.ToTable("JD_Commodity_013");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity014>(entity =>
            {
                entity.ToTable("JD_Commodity_014");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity015>(entity =>
            {
                entity.ToTable("JD_Commodity_015");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity016>(entity =>
            {
                entity.ToTable("JD_Commodity_016");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity017>(entity =>
            {
                entity.ToTable("JD_Commodity_017");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity018>(entity =>
            {
                entity.ToTable("JD_Commodity_018");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity019>(entity =>
            {
                entity.ToTable("JD_Commodity_019");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity020>(entity =>
            {
                entity.ToTable("JD_Commodity_020");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity021>(entity =>
            {
                entity.ToTable("JD_Commodity_021");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity022>(entity =>
            {
                entity.ToTable("JD_Commodity_022");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity023>(entity =>
            {
                entity.ToTable("JD_Commodity_023");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity024>(entity =>
            {
                entity.ToTable("JD_Commodity_024");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity025>(entity =>
            {
                entity.ToTable("JD_Commodity_025");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity026>(entity =>
            {
                entity.ToTable("JD_Commodity_026");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity027>(entity =>
            {
                entity.ToTable("JD_Commodity_027");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity028>(entity =>
            {
                entity.ToTable("JD_Commodity_028");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity029>(entity =>
            {
                entity.ToTable("JD_Commodity_029");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JdCommodity030>(entity =>
            {
                entity.ToTable("JD_Commodity_030");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UucEmployee>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK_UUC_Employee_1");

                entity.ToTable("UUC_Employee");

                entity.Property(e => e.Oid).HasColumnName("OID");

                entity.Property(e => e.AccountOverdue).HasColumnType("datetime");

                entity.Property(e => e.Addomain).HasColumnName("ADDomain");

                entity.Property(e => e.AdsyncId)
                    .HasColumnName("ADSyncID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cn)
                    .IsRequired()
                    .HasColumnName("CN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dn)
                    .HasColumnName("DN")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .IsRequired()
                    .HasColumnName("EmployeeNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ErpId)
                    .HasColumnName("ErpID")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Function)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdcardNumberCn)
                    .HasColumnName("IDCardNumber_CN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Index1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Index2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LevelName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.O)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutterMail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderServiceTimelimit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SmapDisplayOrder)
                    .HasColumnName("Smap_DisplayOrder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmapEmail)
                    .HasColumnName("Smap_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmapEmployeeType)
                    .HasColumnName("Smap_employeeType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmapO)
                    .HasColumnName("Smap_O")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SmapPasswordModifiedDate)
                    .HasColumnName("Smap_PasswordModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SmapUserPassword)
                    .HasColumnName("Smap_UserPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Vcode)
                    .HasColumnName("VCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
