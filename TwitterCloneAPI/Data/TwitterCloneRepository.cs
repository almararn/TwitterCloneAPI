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
            return _dbContext.Tweets.Include(x => x.User).Include(y => y.Comments).Include(z => z.Likes).ToList();
        }

        public void CreateTweet(Tweet tweet)
        {
            _dbContext.Tweets.Add(tweet);
            _dbContext.SaveChanges();
        }
        public Tweet GetTweetById(int id)
        {
    
             return _dbContext.Tweets.Where(t => t.TweetId == id).Include(x => x.User).Include(z => z.Likes).Include(y => y.Comments).ThenInclude(z => z.User).FirstOrDefault(); 
     
            
        }
        public Like GetLikeById(int id)
        {

            return _dbContext.Likes.Where(t => t.LikeId == id).FirstOrDefault();


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

            tweetFromDB.Comments = tweetFromBody.Comments;

            _dbContext.SaveChanges();

            return tweetFromDB;
        }
        public void AddComment(Comment comment)
        {
            _dbContext.Comments.Add(comment);
            _dbContext.SaveChanges();
        }
        public void AddLike(Like like)
        {
            _dbContext.Likes.Add(like);
            _dbContext.SaveChanges();
        }
        public bool DeleteLike(Like like)
        {
            try
            {
                _dbContext.Likes.Remove(like);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
