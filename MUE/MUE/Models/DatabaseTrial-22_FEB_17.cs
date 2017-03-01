namespace MUE.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseTrial_22_FEB_17 : DbContext
    {
        public DatabaseTrial_22_FEB_17()
            : base("name=DatabaseTrial22FEB17")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<CATAGORY> CATAGORies { get; set; }
        public virtual DbSet<EXPERT> EXPERTs { get; set; }
        public virtual DbSet<POST> POSTs { get; set; }
        public virtual DbSet<PROJECT> PROJECTs { get; set; }
        public virtual DbSet<SPECIALTY> SPECIALTies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasOptional(e => e.EXPERT)
                .WithRequired(e => e.AspNetUser);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.POSTs)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.USERID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CATAGORY>()
                .HasMany(e => e.PROJECTs)
                .WithMany(e => e.CATAGORies)
                .Map(m => m.ToTable("PROJECTTYPE").MapLeftKey("CATAGORYID").MapRightKey("PROJECTID"));

            modelBuilder.Entity<EXPERT>()
                .HasMany(e => e.SPECIALTies)
                .WithRequired(e => e.EXPERT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<POST>()
                .HasOptional(e => e.POST1)
                .WithMany(e => e.POSTs);

            modelBuilder.Entity<PROJECT>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.PROJECTs)
                .Map(m => m.ToTable("COLLABORATOR").MapLeftKey("ProjectId").MapRightKey("UserId"));
        }
    }
}
