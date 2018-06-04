using Common.Automation;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace WebApp.UITests
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new FirefoxDriver();
            StateHolder.Intitialize(_driver);
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
