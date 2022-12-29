using System.ComponentModel.DataAnnotations;

namespace TwitterCloneAPI.Models
{
    public class Tweet
    {
        public int TweetId { get; set; }
        public string? Text { get; set; }
        [MaxLength(255)]
        public List<Comment>? Comment { get; set; }
        [MaxLength(255)]
        public string? Retweet { get; set; }
        [MaxLength(255)]
        public string? Like { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
