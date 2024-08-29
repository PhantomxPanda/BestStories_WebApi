namespace BestStories_WebApi.Models
{
    public class StorySummary
    {
        private int? id;//
        private string? postedBy;//
        private DateTime? time; //Time in UNIX format
        private int? commentCount;//comments count - kids
        private string? url;//
        private int? score;//
        private string? title;//

        public int? Id { get { return id; } set { id = value; } }

        public string? PostedBy { get { return postedBy; } set { postedBy = value; } }
        public DateTime? Time { get { return time; } set { time = value; } }
        public int? CommentCount { get { return commentCount; } set { commentCount = value; } }
        public string? Url { get { return url; } set { url = value; } }
        public int? Score { get { return score; } set { score = value; } }
        public string? Title { get { return title; } set { title = value; } }
    }
}
