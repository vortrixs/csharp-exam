using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace BusinessLogic.Context
{
	public class FitnessApiContext : DbContext
	{
		public DbSet<MemberEntity> Members { get; set; }
		public DbSet<SubscriptionEntity> Subscriptions { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseLazyLoadingProxies();
				optionsBuilder.UseSqlite("Data Source=fitness.db");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			/*
			modelBuilder.Entity<MemberEntity>()
				.HasOne<SubscriptionEntity>(m => m.Subscription)
				.WithOne(s => s.Member)
				.HasForeignKey<SubscriptionEntity>(s => s.MemberId);
				*/
		}
	}
}
