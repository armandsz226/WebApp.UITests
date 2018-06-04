using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Common.Automation
{
    public class Browser
    {
        private readonly IWebDriver _driver;
        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateTo(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
        public void MaximizeWindow()
        {
            _driver.Manage().Window.Maximize();
        }
        public void Home()
        {
            var actions = new Actions(_driver);
            actions.SendKeys(Keys.Home).Build().Perform();
        }
    }
}
