using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Portfolio2.Middleware
{
    public class APIClient
    {
        private readonly HttpClient _httpClient;
        public APIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<T> GetAsync<T>(string url)
        {
           var result= await _httpClient!.GetFromJsonAsync<T>(url);
            return result!;
        }
    }
}
