namespace TwitterCloneAPI.Models.DTO
{
    public class TweetDTO
    {
        public int TweetId { get; set; }
        public string? Text { get; set; }
        public int? UserIds { get; set;}
    }
}
