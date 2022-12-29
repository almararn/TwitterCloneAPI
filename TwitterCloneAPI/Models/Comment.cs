namespace TwitterCloneAPI.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? CommentText { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public int? TweetId { get; set; }
    }
}
