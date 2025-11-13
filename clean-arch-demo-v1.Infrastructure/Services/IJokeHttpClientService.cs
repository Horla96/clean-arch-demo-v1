using clean_arch_demo_v1.Core.Models;

namespace clean_arch_demo_v1.Infrastructure.Services
{
    public interface IJokeHttpClientService
    {
        Task<JokeModel> GetData();
    }
}