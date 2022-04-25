using PetStore6.UITests.PageObjects;
using PetStore6.UITests.UITestData.TestData;
using PetStore6.UITests.UITestData.WebDriver;
using PetStore6.Services;
using NUnit.Framework;
using OpenQA.Selenium;

namespace PetStore6.UITests
{
    public class BaseTest 
    {
        public TestDetails Data = JsonManager.GetTestData();
        public IWebDriver WebDriver => DriverFactory.Driver;
        internal HomePage homePage = new HomePage();


        [OneTimeSetUp]
        public void Open()
        {
            DriverFactory.InitalizerDriver();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl(Data.HomePageUrl);
        }

        [SetUp]
        public void PostPet()
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

        [OneTimeTearDown]
        public void Close()
        {
            WebDriver.Quit();
        }
    }
}
