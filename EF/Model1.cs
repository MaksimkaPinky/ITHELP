using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ITHelpWinFrm.EF
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Criticality> Criticality { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Hardware> Hardware { get; set; }
        public virtual DbSet<IT_Employees> IT_Employees { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<Quest> Quest { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<TypeOfProblem> TypeOfProblem { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hardware>()
                .Property(e => e.КоличествоРемонтов)
                .IsFixedLength();

            modelBuilder.Entity<Hardware>()
                .Property(e => e.ПричинаРемонта)
                .IsFixedLength();

            modelBuilder.Entity<Hardware>()
                .Property(e => e.ДатаПоследнегоРемонта)
                .IsFixedLength();

            modelBuilder.Entity<Office>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Office)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);
        }
    }
}
