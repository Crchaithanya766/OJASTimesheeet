using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ojas.DataAccessLayer.Entites
{
    public partial class OjasTimeSheetDBContext : DbContext
    {
        public OjasTimeSheetDBContext()
        {
        }

        public OjasTimeSheetDBContext(DbContextOptions<OjasTimeSheetDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AssignedRoles> AssignedRoles { get; set; }
        public virtual DbSet<AuditTb> AuditTb { get; set; }
        public virtual DbSet<DescriptionTb> DescriptionTb { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<ElmahError> ElmahError { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseAuditTb> ExpenseAuditTb { get; set; }
        public virtual DbSet<NotificationsTb> NotificationsTb { get; set; }
        public virtual DbSet<ProjectMaster> ProjectMaster { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<TimeSheetAuditTb> TimeSheetAuditTb { get; set; }
        public virtual DbSet<TimeSheetDetails> TimeSheetDetails { get; set; }
        public virtual DbSet<TimeSheetMaster> TimeSheetMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=OJAS-DD67\\SQLEXPRESS;Initial Catalog=OjasTimeSheetDB;User ID=sa;Password=chinni@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssignedRoles>(entity =>
            {
                entity.Property(e => e.AssignedRolesId).HasColumnName("AssignedRolesID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RegistrationId).HasColumnName("RegistrationID");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.AssignedRoles)
                    .HasForeignKey(d => d.RegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignedRoles_Registration");
            });

            modelBuilder.Entity<AuditTb>(entity =>
            {
                entity.HasKey(e => e.AuditId);

                entity.ToTable("AuditTB");

                entity.Property(e => e.AuditId).HasColumnName("AuditID");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoggedInAt).HasColumnType("datetime");

                entity.Property(e => e.LoggedOutAt).HasColumnType("datetime");

                entity.Property(e => e.LoginStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PageAccessed)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlReferrer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuditTb)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuditTB_Registration");
            });

            modelBuilder.Entity<DescriptionTb>(entity =>
            {
                entity.HasKey(e => e.DescriptionId);

                entity.ToTable("DescriptionTB");

                entity.Property(e => e.DescriptionId)
                    .HasColumnName("DescriptionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TimeSheetMasterId).HasColumnName("TimeSheetMasterID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.DescriptionNavigation)
                    .WithOne(p => p.InverseDescriptionNavigation)
                    .HasForeignKey<DescriptionTb>(d => d.DescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DescriptionTB_DescriptionTB");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DescriptionTb)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DescriptionTB_ProjectMaster");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DescriptionTb)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DescriptionTB_TimeSheetMaster");
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.ExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Expense");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Registration");
            });

            modelBuilder.Entity<ElmahError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ELMAH_Error");

                entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AllXml)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TimeUtc).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.PurposeorReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VoucherId)
                    .HasColumnName("VoucherID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expense_ProjectMaster");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expense_Registration");
            });

            modelBuilder.Entity<ExpenseAuditTb>(entity =>
            {
                entity.HasKey(e => e.ApprovaExpenselLogId);

                entity.ToTable("ExpenseAuditTB");

                entity.Property(e => e.ApprovaExpenselLogId).HasColumnName("ApprovaExpenselLogID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.ExpenseAuditTb)
                    .HasForeignKey(d => d.ExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseAuditTB_Expense");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ExpenseAuditTb)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseAuditTB_Registration");
            });

            modelBuilder.Entity<NotificationsTb>(entity =>
            {
                entity.HasKey(e => e.NotificationsId);

                entity.ToTable("NotificationsTB");

                entity.Property(e => e.NotificationsId).HasColumnName("NotificationsID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProjectMaster>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.NatureofIndustry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.Property(e => e.RegistrationId).HasColumnName("RegistrationID");

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateofJoining).HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Registration_Roles");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeSheetAuditTb>(entity =>
            {
                entity.HasKey(e => e.ApprovalTimeSheetLogId);

                entity.ToTable("TimeSheetAuditTB");

                entity.Property(e => e.ApprovalTimeSheetLogId).HasColumnName("ApprovalTimeSheetLogID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.TimeSheetId).HasColumnName("TimeSheetID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TimeSheetAuditTb)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeSheetAuditTB_Registration");
            });

            modelBuilder.Entity<TimeSheetDetails>(entity =>
            {
                entity.HasKey(e => e.TimeSheetId);

                entity.Property(e => e.TimeSheetId).HasColumnName("TimeSheetID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DaysofWeek)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Period).HasColumnType("date");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TimeSheetMasterId).HasColumnName("TimeSheetMasterID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TimeSheetDetails)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeSheetDetails_ProjectMaster1");

                entity.HasOne(d => d.TimeSheetMaster)
                    .WithMany(p => p.TimeSheetDetails)
                    .HasForeignKey(d => d.TimeSheetMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeSheetDetails_TimeSheetMaster");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TimeSheetDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeSheetDetails_Registration");
            });

            modelBuilder.Entity<TimeSheetMaster>(entity =>
            {
                entity.Property(e => e.TimeSheetMasterId).HasColumnName("TimeSheetMasterID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TimeSheetMaster)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeSheetMaster_Registration");
            });
        }
    }
}
