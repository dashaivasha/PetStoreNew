using PetStore6.UITests.UITestData.TestData;
using PetStore6.Services;
using NUnit.Framework;

namespace PetStore6.ApiTests
{
    public class BaseTest
    {
        public TestDetails Data = JsonManager.GetTestData();

        [OneTimeSetUp]
        public void Open()
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddHttpClient<PetService>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://petstore.swagger.io/v2/");
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            var PetService = builder.Services.BuildServiceProvider().GetService<PetService>();
            var pet = JsonManager.GetPetFromJson();
            PetService.PutPet(pet);
        }
    }
}
