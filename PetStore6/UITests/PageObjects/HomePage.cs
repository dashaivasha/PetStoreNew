using System;
using PetStore6.UITests.UITestData.WebDriver;
using OpenQA.Selenium;


namespace PetStore6.UITests.PageObjects
{
    public class HomePage : BasePage
    {
        private IWebElement GetByIdButton => driver.FindElement(By.XPath("//div[contains(@id,'pet-get')]//button[contains(@aria-label,'petId')]"));
        private By TryItOutButton = By.XPath("//div[@class='try-out']/button");
        private By PetIdInput = By.XPath("//div[@class='table-container']//input[contains(@placeholder,'petId')]");
        private By ExecuteButton =  By.XPath("//div[@class='execute-wrapper']/button");

        public HomePage() 
        {
        }

        public void PressGetByIdButton() => GetByIdButton.Click();

        public void EnterId(string id)
        {
            WebDriverExtensions.FindElement(driver, TryItOutButton, Data.WaitTime).Click();
            WebDriverExtensions.FindElement(driver,PetIdInput,Data.WaitTime).SendKeys(id);
        }

        public void Execute()
        {
            WebDriverExtensions.FindElement(driver, ExecuteButton, Data.WaitTime).Click();
        }
    }
}
