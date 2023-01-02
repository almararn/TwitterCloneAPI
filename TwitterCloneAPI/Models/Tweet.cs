using System.ComponentModel.DataAnnotations;

namespace TwitterCloneAPI.Models
{
    public class Tweet
    {
        public int TweetId { get; set; }
        public string? Text { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public int UserId { get; set; } 
        public User? User { get; set; }
        public List<Like>? Likes { get; set; }
        public List<Comment>? Comments { get; set; }
        
    }
}
