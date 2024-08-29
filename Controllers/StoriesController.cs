using Microsoft.AspNetCore.Mvc;
using BestStories_WebApi.Models;
using BestStories_WebApi.Services;

namespace BestStories_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoriesController : ControllerBase
    {
        private readonly ILogger<StoriesController> logger;
        
        public StoriesController(ILogger<StoriesController> logger)
        {
            this.logger = logger;
        }

        // GET /BestStories/5
        [HttpGet(template:"stories:int", Name = "GetBestStories")]        
        public IEnumerable<StorySummary> Get(int stories) 
        {
            List<Story> best_n_stories = new List<Story>();
            List<StorySummary> best_n_stories_sumary = new List<StorySummary>();

            IStoriesServices storiesServices = new StoriesServices();
            best_n_stories = storiesServices.GetBestStoriesAsync(stories).Result;

            foreach (Story story in best_n_stories)
            {
                StorySummary storySummary = new StorySummary();

                storySummary.Id = story.Id;
                storySummary.Title = story.Title;
                storySummary.Url = story.Url;
                storySummary.PostedBy = story.By;
                storySummary.Time = DateTimeOffset.FromUnixTimeSeconds(story.Time).DateTime;
                storySummary.Score = story.Score;
                storySummary.CommentCount = story.Kids.Count();

                best_n_stories_sumary.Add(storySummary);
            }

            return best_n_stories_sumary;
        }
    }
}
