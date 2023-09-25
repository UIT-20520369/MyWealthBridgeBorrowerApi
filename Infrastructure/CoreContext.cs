using Domain.AggregateModels.Borrowers;
using Domain.AggregateModels.ExternalLogins;
using Domain.BorrowerCards;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class CoreContext: DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options):base(options) {
        }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<ExternalLogin> ExternalLogins { get; set; }
        public DbSet<BorrowerCard> BorrowerCards { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Borrower
            modelBuilder.Entity<Borrower>().HasOne(u => u.ExternalLogin).WithOne(e => e.User).HasForeignKey<ExternalLogin>("UserId");
            //Borower Cards
            modelBuilder.Entity<BorrowerCard>().Property(b => b.Balance).HasColumnType("money");
            modelBuilder.Entity<BorrowerCard>().Property(b => b.Limit).HasColumnType("money");
            modelBuilder.Entity<BorrowerCard>().Property(b => b.RecurringCharges).HasColumnType("money");
            modelBuilder.Entity<BorrowerCard>().HasOne(b => b.Borrower).WithMany(b => b.BorrowerCards).HasForeignKey(b =>b.BorrowerId).IsRequired();
        }
    }
}
