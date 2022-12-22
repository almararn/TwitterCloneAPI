using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using TwitterCloneAPI.Models;

namespace TwitterCloneAPI.Data
{
    public class TwitterCloneDbContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TwitteCloneDB");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User us1= new User {UserId = 1, FirstName = "User1", LastName = "LastName1"};
            modelBuilder.Entity<User>().HasData(us1);

            Tweet tw1 = new Tweet { TweetId = 1, Text = "This is my first tweet", Like = "User4", Retweet = "User4", Comment = "first comment" };
            Tweet tw2 = new Tweet { TweetId = 2, Text = "Tweet number two is here, making it a little bit longer than the first one. Few lines more. Just adding some text to make it to the third line of the user intrerface.", Like = "User1", Retweet = "User4", Comment = "nice tweet" };
            modelBuilder.Entity<Tweet>().HasData(tw1);
            modelBuilder.Entity<Tweet>().HasData(tw2);
        }
    }
}
