using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Service.Models
{
    public partial class ConvenienceStoreContext : DbContext
    {
        public ConvenienceStoreContext()
        {
        }

        public ConvenienceStoreContext(DbContextOptions<ConvenienceStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ExportBill> ExportBills { get; set; }
        public virtual DbSet<ImportBill> ImportBills { get; set; }
        public virtual DbSet<Merchandise> Merchandises { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =localhost; database = ConvenienceStore;uid=sa;pwd=12345;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__Account__A471AFDA63272109");

                entity.ToTable("Account");

                entity.Property(e => e.AccId).HasColumnName("accId");

                entity.Property(e => e.AccAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("accAddress");

                entity.Property(e => e.AccCreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("accCreatedTime");

                entity.Property(e => e.AccDob)
                    .HasColumnType("date")
                    .HasColumnName("accDOB");

                entity.Property(e => e.AccName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("accName");

                entity.Property(e => e.AccPass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accPass");

                entity.Property(e => e.AccPhone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("accPhone");

                entity.Property(e => e.AccRole).HasColumnName("accRole");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.BillId).HasColumnName("billId");

                entity.Property(e => e.AccId).HasColumnName("accId");

                entity.Property(e => e.BillCreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("billCreatedTime");

                entity.Property(e => e.MerId).HasColumnName("merId");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.AccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__accId__36B12243");

                entity.HasOne(d => d.Mer)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.MerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__merId__37A5467C");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillDetail");

                entity.Property(e => e.BillDetailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("billDetailId");

                entity.Property(e => e.BillId).HasColumnName("billId");

                entity.Property(e => e.BillMerPrice).HasColumnName("billMerPrice");

                entity.Property(e => e.BillMerQuanity).HasColumnName("billMerQuanity");

                entity.Property(e => e.MerId).HasColumnName("merId");

                entity.HasOne(d => d.Bill)
                    .WithMany()
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillDetai__billI__398D8EEE");

                entity.HasOne(d => d.Mer)
                    .WithMany()
                    .HasForeignKey(d => d.MerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillDetai__merId__3A81B327");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK__Category__79D361B614E17B48");

                entity.ToTable("Category");

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");

                entity.Property(e => e.NameCateGory)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nameCateGory");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CusId)
                    .HasName("PK__Customer__BA9897F3E46C7BDC");

                entity.ToTable("Customer");

                entity.Property(e => e.CusId).HasColumnName("cusId");

                entity.Property(e => e.CusDob)
                    .HasColumnType("date")
                    .HasColumnName("cusDOB");

                entity.Property(e => e.CusGender).HasColumnName("cusGender");

                entity.Property(e => e.CusName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("cusName");

                entity.Property(e => e.CusPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cusPhone");
            });

            modelBuilder.Entity<ExportBill>(entity =>
            {
                entity.HasKey(e => e.ExId)
                    .HasName("PK__ExportBi__38F47E5849BD0C41");

                entity.ToTable("ExportBill");

                entity.Property(e => e.ExId).HasColumnName("exId");

                entity.Property(e => e.AccId).HasColumnName("accId");

                entity.Property(e => e.CusId).HasColumnName("cusId");

                entity.Property(e => e.ExDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exDate");

                entity.Property(e => e.ExManager)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("exManager");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.ExportBills)
                    .HasForeignKey(d => d.AccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ExportBil__accId__2F10007B");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.ExportBills)
                    .HasForeignKey(d => d.CusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ExportBil__cusId__300424B4");
            });

            modelBuilder.Entity<ImportBill>(entity =>
            {
                entity.HasKey(e => e.ImId)
                    .HasName("PK__ImportBi__9BF4082F3BA075E3");

                entity.ToTable("ImportBill");

                entity.Property(e => e.ImId).HasColumnName("imId");

                entity.Property(e => e.ImDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imDate");

                entity.Property(e => e.ImName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("imName");

                entity.Property(e => e.ImProvider)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("imProvider");

                entity.Property(e => e.MerId).HasColumnName("merId");

                entity.Property(e => e.ProId).HasColumnName("proId");

                entity.HasOne(d => d.Mer)
                    .WithMany(p => p.ImportBills)
                    .HasForeignKey(d => d.MerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ImportBil__merId__32E0915F");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.ImportBills)
                    .HasForeignKey(d => d.ProId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ImportBil__proId__33D4B598");
            });

            modelBuilder.Entity<Merchandise>(entity =>
            {
                entity.HasKey(e => e.MerId)
                    .HasName("PK__Merchand__31EEDA2147E7C5FA");

                entity.ToTable("Merchandise");

                entity.Property(e => e.MerId).HasColumnName("merId");

                entity.Property(e => e.MerDescription)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("merDescription");

                entity.Property(e => e.MerIdCategory).HasColumnName("merIdCategory");

                entity.Property(e => e.MerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("merName");

                entity.Property(e => e.MerPrice).HasColumnName("merPrice");

                entity.Property(e => e.MerQuantity).HasColumnName("merQuantity");

                entity.Property(e => e.MerUnit)
                    .HasMaxLength(50)
                    .HasColumnName("merUnit");

                entity.HasOne(d => d.MerIdCategoryNavigation)
                    .WithMany(p => p.Merchandises)
                    .HasForeignKey(d => d.MerIdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Merchandi__merId__2A4B4B5E");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.txtProviderID)
                    .HasName("PK__Provider__5BBBEEF5BBA9323C");

                entity.ToTable("Provider");

                entity.Property(e => e.txtProviderID).HasColumnName("proId");

                entity.Property(e => e.ProDob)
                    .HasColumnType("date")
                    .HasColumnName("proDOB");

                entity.Property(e => e.ProGender).HasColumnName("proGender");

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("proName");

                entity.Property(e => e.ProPhone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("proPhone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
