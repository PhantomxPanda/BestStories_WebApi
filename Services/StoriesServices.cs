using BestStories_WebApi.Models;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BestStories_WebApi.Services
{
    public class StoriesServices:IStoriesServices
    {
        private static readonly HttpClient client;

        static StoriesServices()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://hacker-news.firebaseio.com/v0/")
            };
        }

        public async Task<List<Story>> GetBestStoriesAsync(int n)
        {
            var URL_best_stories_items_id = string.Format("beststories.json");
            List<Story> result_stories = new List<Story>();
            List<int> result_best_stories_items_id = new List<int>();
            var response_best_stories_items_id = await client.GetAsync(URL_best_stories_items_id);

            if (response_best_stories_items_id.IsSuccessStatusCode)
            {

                string stringResponse = await response_best_stories_items_id.Content.ReadAsStringAsync();
                result_best_stories_items_id = JsonSerializer.Deserialize<List<int>>(stringResponse, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

                for (int i = 0; i < n; i++)
                {
                    var URL_story = string.Format("item/{0}.json", result_best_stories_items_id[i]);
                    var response_story = await client.GetAsync(URL_story);

                    if (response_story.IsSuccessStatusCode)
                    {
                        string stringResponse2 = await response_story.Content.ReadAsStringAsync();
                        Story story_n = JsonSerializer.Deserialize<Story>(stringResponse2, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                        result_stories.Add(story_n);
                    }

                    else
                    {
                        throw new HttpRequestException(response_story.ReasonPhrase);
                    }

                }
            }

            else
            {
                throw new HttpRequestException(response_best_stories_items_id.ReasonPhrase);
            }

            return result_stories;
        }
    }
}
