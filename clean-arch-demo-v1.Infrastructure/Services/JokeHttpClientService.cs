using clean_arch_demo_v1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_demo_v1.Infrastructure.Services
{
    public class JokeHttpClientService(HttpClient httpClient) : IJokeHttpClientService
    {
        public async Task<JokeModel> GetData()
        {
            return await httpClient.GetFromJsonAsync<JokeModel>("random_joke");
        }
    }
}
