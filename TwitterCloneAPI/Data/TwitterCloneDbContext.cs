using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using TwitterCloneAPI.Models;

namespace TwitterCloneAPI.Data
{
    public class TwitterCloneDbContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TwitteCloneDB");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User us1= new User { UserId = 1, FirstName = "Donald J.", LastName = "Trump", Handle = "@realDonaldTrump" };
            modelBuilder.Entity<User>().HasData(us1);
       
            User us2 = new User { UserId = 2, FirstName = "Elon", LastName = "Musk", Handle = "@elonmusk" };
            modelBuilder.Entity<User>().HasData(us2);

            User us3 = new User { UserId = 3, FirstName = "Barack", LastName = "Obama", Handle = "@BarackObama" };
            modelBuilder.Entity<User>().HasData(us3);

            Tweet tw1 = new Tweet { TweetId = 1, Text = "This is my first tweet", UserId = 2 };
            modelBuilder.Entity<Tweet>().HasData(tw1);
            
            Tweet tw2 = new Tweet { TweetId = 2, Text = "Tweet number two is here", UserId = 1 };
            modelBuilder.Entity<Tweet>().HasData(tw2);

            Comment cm1 = new Comment { CommentId = 1, Text = "prufa comment", UserId = 1, TweetId = 1 };
            modelBuilder.Entity<Comment>().HasData(cm1);

            Comment cm2 = new Comment { CommentId = 2, Text = "prufa comment2", UserId = 2, TweetId = 2 };
            modelBuilder.Entity<Comment>().HasData(cm2);

            Comment cm3 = new Comment { CommentId = 3, Text = "prufa comment3", UserId = 1, TweetId = 2 };
            modelBuilder.Entity<Comment>().HasData(cm3);

            Like lk1 = new Like { LikeId = 1, TweetId = 1, UserId = 1 };
            modelBuilder.Entity<Like>().HasData(lk1);

            Like lk2 = new Like { LikeId = 2, TweetId = 1, UserId = 2 };
            modelBuilder.Entity<Like>().HasData(lk2);
        }
    }
}
