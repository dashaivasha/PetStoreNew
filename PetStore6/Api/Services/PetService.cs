
using PetStore6.Models;

namespace PetStore6.Services
{
    public class PetService : PetStoreService
    {
        PetService(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<Pet?> GetPet(string id) =>
        await _httpClient.GetFromJsonAsync<Pet>(
        $"pet/{id}");

        public HttpResponseMessage PutPet(Pet pet)
        {
            var response = _httpClient.PutAsJsonAsync($"pet/", pet).Result;
            return response;
        }

    }
}
