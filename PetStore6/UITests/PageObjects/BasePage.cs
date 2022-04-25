using PetStore6.UITests;
using PetStore6.UITests.UITestData.TestData;
using PetStore6.UITests.UITestData.WebDriver;
using OpenQA.Selenium;

namespace PetStore6.UITests.PageObjects
{
    public class BasePage 
    {
        protected IWebDriver driver;

        public BasePage()
        {
            DriverFactory.InitalizerDriver();
            driver = DriverFactory.Driver;
        }

        internal TestDetails Data = JsonManager.GetTestData();
    }
}
