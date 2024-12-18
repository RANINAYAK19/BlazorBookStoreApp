using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorBookStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorBookStoreApp.Services
{
    public class PostService : IPostService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PostService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            // IHttpClientFactory se ek client create karte hain
            var httpClient = _httpClientFactory.CreateClient();

            // API request bhejte hain
            var posts = await httpClient.GetFromJsonAsync<List<Post>>("https://jsonplaceholder.typicode.com/posts");

            return posts ?? new List<Post>();
        }

        //// Fetch posts from your local database using Entity Framework
        //public async Task<List<Post>> GetPostsFromDatabaseAsync()
        //{
        //    return await _context.Posts.ToListAsync();
        //}
    }
}
