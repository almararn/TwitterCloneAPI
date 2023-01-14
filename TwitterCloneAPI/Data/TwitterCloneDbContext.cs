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
        public DbSet<Like>? Likes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TwitteCloneDB");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User us1 = new User { UserId = 1, FirstName = "Donald J.", LastName = "Trump", Handle = "@realDonaldTrump" };
            modelBuilder.Entity<User>().HasData(us1);

            User us2 = new User { UserId = 2, FirstName = "Elon", LastName = "Musk", Handle = "@elonmusk" };
            modelBuilder.Entity<User>().HasData(us2);

            User us3 = new User { UserId = 3, FirstName = "Barack", LastName = "Obama", Handle = "@BarackObama" };
            modelBuilder.Entity<User>().HasData(us3);

            User us4 = new User { UserId = 4, FirstName = "Justin", LastName = "Bieber", Handle = "@justinbieber" };
            modelBuilder.Entity<User>().HasData(us4);

            User us5 = new User { UserId = 5, FirstName = "Katy", LastName = "Perry", Handle = "@katyperry" };
            modelBuilder.Entity<User>().HasData(us5);

            User us6 = new User { UserId = 6, FirstName = "Rihanna", LastName = "", Handle = "@rihanna" };
            modelBuilder.Entity<User>().HasData(us6);

            User us7 = new User { UserId = 7, FirstName = "Cristiano", LastName = "Ronaldo", Handle = "@Cristiano" };
            modelBuilder.Entity<User>().HasData(us7);

            User us8 = new User { UserId = 8, FirstName = "Kim", LastName = "Kardashian", Handle = "@KimKardashian" };
            modelBuilder.Entity<User>().HasData(us8);

            User us9 = new User { UserId = 9, FirstName = "Justin", LastName = "Timberlake", Handle = "@jtimberlake" };
            modelBuilder.Entity<User>().HasData(us9);

            User us10 = new User { UserId = 10, FirstName = "Bill", LastName = "Gates", Handle = "@BillGates" };
            modelBuilder.Entity<User>().HasData(us10);

            Tweet tw1 = new Tweet { TweetId = 1, Text = "Great news: Thanks to @POTUS, the application for federal student loan debt relief is now available, and millions of working-and middle-class folks are eligible.", UserId = 3, Timestamp = DateTime.Today.AddDays(-1).AddMinutes(-36)  };
            modelBuilder.Entity<Tweet>().HasData(tw1);

            Tweet tw2 = new Tweet { TweetId = 2, Text = "I wonder what would have happened in 2009 if the Fed had raised rates instead of lowering them 🤔", UserId = 2, Timestamp = DateTime.Today.AddMinutes(-224) };
            modelBuilder.Entity<Tweet>().HasData(tw2);

            Tweet tw3 = new Tweet { TweetId = 3, Text = "They just happened to find 50,000 ballots late last night. The USA is embarrassed by fools. Our Election Process is worse than that of third world countries!", UserId = 1 , Timestamp = DateTime.Today.AddMinutes(100) };
            modelBuilder.Entity<Tweet>().HasData(tw3);

            Tweet tw4 = new Tweet { TweetId = 4, Text = "if you’re not throwing that carcass and the leftovers in a pot, simmering through the night, you’re not doing it right.", UserId = 5 };
            modelBuilder.Entity<Tweet>().HasData(tw4);

            Comment cm1 = new Comment { CommentId = 1, Text = "You are the worst president EVER!", UserId = 1, TweetId = 1 };
            modelBuilder.Entity<Comment>().HasData(cm1);

            Comment cm2 = new Comment { CommentId = 2, Text = "That's so hot 😊", UserId = 8, TweetId = 3 };
            modelBuilder.Entity<Comment>().HasData(cm2);

            Comment cm3 = new Comment { CommentId = 3, Text = "It would have been a disaster!", UserId = 10, TweetId = 2 };
            modelBuilder.Entity<Comment>().HasData(cm3);

            Like lk1 = new Like { LikeId = 1, TweetId = 1, UserId = 7 };
            modelBuilder.Entity<Like>().HasData(lk1);

            Like lk2 = new Like { LikeId = 2, TweetId = 2, UserId = 4 };
            modelBuilder.Entity<Like>().HasData(lk2);

            Like lk3 = new Like { LikeId = 3, TweetId = 2, UserId = 9 };
            modelBuilder.Entity<Like>().HasData(lk3);

            Like lk4 = new Like { LikeId = 4, TweetId = 2, UserId = 5 };
            modelBuilder.Entity<Like>().HasData(lk4);

            Like lk5 = new Like { LikeId = 5, TweetId = 4, UserId = 6 };
            modelBuilder.Entity<Like>().HasData(lk5);
        }
    }
}