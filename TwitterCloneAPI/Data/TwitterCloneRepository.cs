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
           return _dbContext.Tweets.ToList();
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
    }
}
