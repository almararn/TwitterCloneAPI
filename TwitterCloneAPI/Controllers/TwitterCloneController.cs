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

        [HttpPost]
        [Route("comments")]
        public ActionResult<Comment> AddComment(Comment comment)
        {
            _repo.AddComment(comment);
            return StatusCode(201);
        }

        [HttpPost]
        [Route("likes")]
        public ActionResult<Like> AddLike(Like like)
        {
            _repo.AddLike(like);
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

        [HttpDelete]
        [Route("tweet/{id}")]
        public ActionResult<bool> DeleteTweetById(int id)
        {
            try
            {
                Tweet? tweet = _repo.GetTweetById(id);

                if (tweet == null)
                {
                    return NotFound();
                }

                bool succsess = _repo.DeleteTweet(tweet);
                if (!succsess)
                {
                    return StatusCode(500);
                }

                return Ok();

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpDelete]
        [Route("likes/{id}")]
        public ActionResult<bool> DeleteLikeById(int id)
        {
            try
            {
                Like? like = _repo.GetLikeById(id);

                if (like == null)
                {
                    return NotFound();
                }

                bool succsess = _repo.DeleteLike(like);
                if (!succsess)
                {
                    return StatusCode(500);
                }

                return Ok();

            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpPut]
        [Route("tweet/{id}")]
        public IActionResult UpdateTweet(int id, Tweet tweetFromBody)
        {

            try
            {
                Tweet? updated = _repo.UpdateTweet(id, tweetFromBody);

                if (updated == null)
                {
                    return NotFound();
                }

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
