using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorBookStoreApp.Models;

namespace BlazorBookStoreApp.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPostsAsync();
    }
}
