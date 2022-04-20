using PetStore6.Models;

namespace PetStore6.Service
{
    public class PetStoreService
    {
        private readonly HttpClient _httpClient;

        public PetStoreService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<Pet?> GetPet(string id) =>
        await _httpClient.GetFromJsonAsync<Pet>(
            $"pet/{id}");

        public HttpResponseMessage PutPet(Pet pet)
        {
            var response =  _httpClient.PutAsJsonAsync($"pet/", pet).Result;
            return response;
        }

    }
}
