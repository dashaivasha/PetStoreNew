using PetStore6.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient<PetStoreService>(httpClient =>
{
    httpClient.BaseAddress = new Uri("https://petstore.swagger.io/v2/");
    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
});
var petStoreService = builder.Services.BuildServiceProvider().GetService<PetStoreService>();
var responsePet = await petStoreService.GetPet("22");
var app = builder.Build();

app.MapGet("/", () => petStoreService.GetPet("22"));

app.Run();
