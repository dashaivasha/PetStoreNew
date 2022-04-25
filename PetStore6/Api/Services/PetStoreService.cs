using PetStore6.Models;

namespace PetStore6.Services
{
    public class PetStoreService 
    {
        protected readonly HttpClient _httpClient;

        public PetStoreService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
    }
}
