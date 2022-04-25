using PetStore6.Models;
using PetStore6.Services;

namespace PetStore6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddHttpClient<PetService>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://petstore.swagger.io/v2/");
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            var PetService = builder.Services.BuildServiceProvider().GetService<PetService>();
           // var responsePet = await PetService.GetPet("22");
         //   responsePet.Name = "Amaya";
            var response = PetService.GetPet("22");
            var app = builder.Build();

            app.MapGet("/", () => response);

            app.Run();
        }
    }
}