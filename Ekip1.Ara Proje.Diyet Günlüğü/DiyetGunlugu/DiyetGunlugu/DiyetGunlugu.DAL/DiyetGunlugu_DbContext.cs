using DiyetGunlugu.DAL.Configurations;
using DiyetGunlugu.MODEL.Entity;
using DiyetGunlugu.MODEL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DiyetGunlugu.DAL
{
    public class DiyetGunlugu_DbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DiyetDukkani;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<EatingMeal> EatingMeals { get; set; }
        public DbSet<Foods> Foods { get; set; }

        public DbSet<Servings> Serving { get; set; }
        public DbSet<TypeOfFoods> TypeOfFoods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<WeightChange> WeightChanges { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            SetBaseProperies();
            return base.SaveChanges();
        }

        private void SetBaseProperies()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                SetIfAdded(entry);
                SetIfModified(entry);
                SetIfDeleted(entry);

            }
        }

        private void SetIfDeleted(EntityEntry<BaseEntity> entry)
        {

            if (entry.State is not EntityState.Deleted)
            {
                return;
            }
            entry.State = EntityState.Modified;
            entry.Entity.Status = Status.Deleted;
            entry.Entity.DeletedDate = DateTime.Now;
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.ModifiedDate = DateTime.Now;
                entry.Entity.Status = Status.Modiefied;
            }
        }
        private void SetIfAdded(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreateDate = DateTime.Now;
                entry.Entity.Status = Status.Created;
            }

        }
    }
}
