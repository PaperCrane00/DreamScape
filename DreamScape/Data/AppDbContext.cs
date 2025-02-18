using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DreamScape.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemUser> ItemUsers { get; set; }
        public DbSet<ItemUsersTrade> ItemUsersTrades { get; set; }
        public DbSet<Magic> Magics { get; set; }
        public DbSet<MagicStat> MagicStats { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                ConfigurationManager.ConnectionStrings["DreamScapeDatabase"].ConnectionString,
                ServerVersion.Parse("8.0.30")
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Magic>().HasData(
                new Magic
                {
                    Id = 1,
                    Title = "Magic1"
                },
                new Magic
                {
                    Id = 2,
                    Title = "Magic2"
                }
            );
            modelBuilder.Entity<Stat>().HasData(
                new Stat
                {
                    Id = 1,
                    Rarity = 50,
                    Power = 50,
                    Speed = 50,
                    Durability = 50
                },
                new Stat
                {
                    Id = 2,
                    Rarity = 100,
                    Power = 100,
                    Speed = 100,
                    Durability = 100
                }
            );
            modelBuilder.Entity<MagicStat>().HasData(
                new MagicStat
                {
                    Id = 1,
                    StatId = 1,
                    MagicId = 1,
                    Value = 50
                },
                new MagicStat
                {
                    Id = 2,
                    StatId = 2,
                    MagicId = 2,
                    Value = 100
                }
            );
            modelBuilder.Entity<Type>().HasData(
                new Type
                {
                    Id = 1,
                    Title = "TestType"
                },
                new Type
                {
                    Id = 2,
                    Title = "TestType2"
                }
            );
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    Name = "TestItem",
                    Description = "This is a test description for the TestItem.",
                    StatId = 1,
                    TypeId = 1
                },
                new Item
                {
                    Id = 2,
                    Name = "TestItem2",
                    Description = "This is a test description for the TestItem.",
                    StatId = 2,
                    TypeId = 2
                }
            );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "TestUser",
                    Email = "Test@mail.com",
                    Password = "TestPassword",
                    Admin = false
                },
                new User
                {
                    Id = 2,
                    Username = "TestUser2",
                    Email = "Test2@mail.com",
                    Password = "TestPassword2",
                    Admin = false
                }
            );
            modelBuilder.Entity<ItemUser>().HasData(
                new ItemUser
                {
                    Id = 1,
                    ItemId = 1,
                    UserId = 1
                },
                new ItemUser
                {
                    Id = 2,
                    ItemId = 2,
                    UserId = 2
                }
            );
            modelBuilder.Entity<Trade>().HasData(
                new Trade
                {
                    Id = 1,
                    User1Id = 1,
                    User2Id = 2,
                    is_succesfull = false,
                    date = DateTime.Now
                }
            );
            modelBuilder.Entity<ItemUsersTrade>().HasData(
                new ItemUsersTrade
                {
                    Id = 1,
                    ItemUserId = 1,
                    TradeId = 1,
                    Completed = false
                },
                new ItemUsersTrade
                {
                    Id = 2,
                    ItemUserId = 2,
                    TradeId = 1,
                    Completed = false
                }
            );
        }
    }
}
