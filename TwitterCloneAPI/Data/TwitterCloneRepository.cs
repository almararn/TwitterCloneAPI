using Microsoft.EntityFrameworkCore;
using TwitterCloneAPI.Models;

namespace TwitterCloneAPI.Data
{
    public class TwitterCloneRepository
    {
        private TwitterCloneDbContext _dbContext;
        public TwitterCloneRepository()
        {
            _dbContext = new TwitterCloneDbContext();
        }

        public List<Tweet> GetAllTweets()
        {
           return _dbContext.Tweets.Include(x => x.User).Include(y => y.Comment).ToList();
        }

        public void CreateTweet(Tweet tweet)
        {
            _dbContext.Tweets.Add(tweet);
            _dbContext.SaveChanges();
        }
        public Tweet? GetTweetById(int id)
        {
            return _dbContext.Tweets.Where(t => t.TweetId == id).FirstOrDefault();
        }
        public bool DeleteTweet(Tweet tweet)
        {
            try
            {
                _dbContext.Tweets.Remove(tweet);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public Tweet? UpdateTweet(int id, Tweet tweetFromBody)
        {
            Tweet? tweetFromDB = GetTweetById(id);

            if (tweetFromDB == null)
            {
                return null;
            }

            tweetFromDB.Comment = tweetFromBody.Comment;

            _dbContext.SaveChanges();

            return tweetFromDB;
        }
    }
}
