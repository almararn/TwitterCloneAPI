using Microsoft.AspNetCore.Mvc;
using TwitterCloneAPI.Data;
using TwitterCloneAPI.Models;


namespace TwitterCloneAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class TwitterCloneController : ControllerBase
    {
        private TwitterCloneRepository _repo;

        public TwitterCloneController()
        {
            _repo = new TwitterCloneRepository();
        }

        
        [HttpGet]
        [Route("tweets")]
        public List<Tweet> GetAllTweets()
        {
            return _repo.GetAllTweets();
        }

        [HttpPost]
        [Route("tweets")]
        public ActionResult<Tweet> CreateTweet(Tweet tweet)
        {
            _repo.CreateTweet(tweet);
            return StatusCode(201);
        }

        [HttpGet]
        [Route("tweet/{id}")]
        public ActionResult<Tweet> GetTweetById(int id)
        {

            Tweet? tweet = _repo.GetTweetById(id);

            if (tweet == null)
            {
                return NotFound();
            }


            return tweet;

        }
    }
}
