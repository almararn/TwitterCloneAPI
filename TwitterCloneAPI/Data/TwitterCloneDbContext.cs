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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TwitteCloneDB");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User us1= new User { UserId = 1, FirstName = "User1", LastName = "LastName1" };
            modelBuilder.Entity<User>().HasData(us1);
       
            User us2 = new User { UserId = 2, FirstName = "User2", LastName = "LastName2" };
            modelBuilder.Entity<User>().HasData(us2);



            //    Tweet tw1 = new Tweet { TweetId = 1,
            //        Text = "This is my first tweet",
            //  user = us2,
            //        Like = "User4", Retweet = "User4",
            //        Comment = "first comment",
            //    };

            //    Tweet tw2 = new Tweet { TweetId = 2, Text = "Tweet number two is here, making it a little", Like = "User1", Retweet = "User4", Comment = "nice tweet" };
            //   modelBuilder.Entity<Tweet>().HasData(tw2);

            modelBuilder.Entity<Tweet>().HasData(new Tweet
            {
                TweetId = 1,
                Text = "This is my first tweet",
                UserId = 1,
                Like = "User4",
                Retweet = "User4",
              //  Comment = new List<Comment>() { new Comment { CommentId = 2, CommentText = "prufa comment", UserId = 2} }
            });

            Comment cm1 = new Comment { CommentId = 1, CommentText = "prufa comment", UserId = 2, TweetId = 1 };
            modelBuilder.Entity<Comment>().HasData(cm1);

            Comment cm2 = new Comment { CommentId = 2, CommentText = "prufa comment2", UserId = 2, TweetId = 1 };
            modelBuilder.Entity<Comment>().HasData(cm2);

        }
    }
}
