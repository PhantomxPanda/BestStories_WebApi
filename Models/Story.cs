namespace BestStories_WebApi.Models
{
    public class Story
    {
        private int? id;
        private Boolean? deleted;
        private string? type;
        private string? by;
        private int time; //Time in UNIX format
        private string? text;
        private Boolean? dead;
        private string? parent;
        private int? poll;
        private List<int>? kids;
        private string? url;
        private int? score;
        private string? title;
        private List<int>? parts;
        private int? descendants;

        public int? Id { get { return id; } set { id = value; } }
        public Boolean? Deleted { get { return deleted; } set { deleted = value; } }
        public string? Type { get { return type; } set { type = value; } }
        public string? By { get { return by; } set { by = value; } }
        public int Time { get { return time; } set { time = value; } }
        public string? Text { get { return text; } set { text = value; } }
        public Boolean? Dead { get { return dead; } set { dead = value; } }
        public string? Parent { get { return parent; } set { parent = value; } }
        public int? Poll { get { return poll; } set { poll = value; } }
        public List<int>? Kids { get { return kids; } set { kids = value; } }
        public string? Url { get { return url; } set { url = value; } }
        public int? Score { get { return score; } set { score = value; } }
        public string? Title { get { return title; } set { title = value; } }
        public List<int>? Parts { get { return parts; } set { parts = value; } }
        public int? Descendants { get { return descendants; } set { descendants = value; } }
    }
}
