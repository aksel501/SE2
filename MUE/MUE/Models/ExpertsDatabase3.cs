namespace MUE.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ExpertsDatabase3 : DbContext
    {
        public ExpertsDatabase3()
            : base("name=ExpertsDatabase3")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<CATAGORY> CATAGORies { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<POST> POSTs { get; set; }
        public virtual DbSet<PROJECT> PROJECTs { get; set; }
        public virtual DbSet<SPECIALTY> SPECIALTies { get; set; }
        public virtual DbSet<CatSpecUserViewModel> CatSpecUserViewModels { get; set; }

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
                .HasMany(e => e.PROJECTs)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.PROJECTCREATORID);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Messages)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.RecieverID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Messages1)
                .WithRequired(e => e.AspNetUser1)
                .HasForeignKey(e => e.SenderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.POSTs)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.USERID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.SPECIALTies)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.expertID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.PROJECTs1)
                .WithMany(e => e.AspNetUsers)
                .Map(m => m.ToTable("COLLABORATOR").MapLeftKey("UserId").MapRightKey("ProjectId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.CATAGORies)
                .WithMany(e => e.AspNetUsers)
                .Map(m => m.ToTable("UserCatagories").MapLeftKey("USERID").MapRightKey("CATAGORYID"));

            modelBuilder.Entity<CATAGORY>()
                .HasMany(e => e.PROJECTs)
                .WithMany(e => e.CATAGORies)
                .Map(m => m.ToTable("PROJECTTYPE").MapLeftKey("CATAGORYID").MapRightKey("PROJECTID"));

            modelBuilder.Entity<POST>()
                .HasMany(e => e.POST1)
                .WithOptional(e => e.POST2)
                .HasForeignKey(e => e.REPLIED_TO_POST_ID);
        }
    }
}
