using BestStories_WebApi.Models;

namespace BestStories_WebApi.Services
{
    public interface IStoriesServices
    {
        Task<List<Story>> GetBestStoriesAsync(int n);
    }
}
