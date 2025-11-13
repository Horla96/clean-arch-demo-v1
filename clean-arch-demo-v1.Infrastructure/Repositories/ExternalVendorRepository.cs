using clean_arch_demo_v1.Core.Interfaces;
using clean_arch_demo_v1.Core.Models;
using clean_arch_demo_v1.Infrastructure.Services;
using clean_arch_demo_v1.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch_demo_v1.Infrastructure.Repositories
{
    public class ExternalVendorRepository(ICoindeskHttpClientService coindeskHttpClientService,
        IJokeHttpClientService jokeHttpClientService) : IExternalVendorRepository

    {
        public async Task<CoindeskData> GetData()
        {
            return await coindeskHttpClientService.GetData();
        }
        public async Task<JokeModel> GetJoke()
        {
            return await jokeHttpClientService.GetData();
        }

    }
}
