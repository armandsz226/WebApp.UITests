using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Common.Automation
{
    public class ElementBase
    {
        private readonly IWebDriver _driver;
        public ElementBase(IWebDriver driver)
        {
            _driver = driver;
        }

        protected IWebElement GetElement(By by)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
            try
            {
               var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
               return element;
            }
            catch (NoSuchElementException)
            {
                throw new Exception($"Element not found: {@by}");
            }
        }
        protected ReadOnlyCollection<IWebElement> GetElements(By by)
        {
            try
            {
                return _driver.FindElements(by);
            }
            catch (NoSuchElementException)
            {
                throw new Exception($"Element not found: {@by}");
            }
        }
        public void Click(By by)
        {
           _driver.FindElement(by).Click();
        }

        public void WaitUntilElementIsClickable(By by)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            catch (WebDriverTimeoutException)
            {
                throw new Exception($"Element is not clickable {@by}");
            }
        }
        public bool IsDisplayedById(string id)
        {
          return _driver.FindElement(By.Id(id)).Displayed;
        }
        public void ClickByLinkText(string linkText)
        {
            try
            {
                _driver.FindElement(By.LinkText(linkText)).Click();
            }
            catch (Exception)
            {
                throw new Exception($"Can not click on link by link text {linkText}");
            }
        }

        public void ClickAt(By by, int x, int y)
        {
            var actions = new Actions(_driver);
            var element = GetElement(by);
            actions.MoveToElement(element,0,0);
            actions.MoveByOffset(x,y);
            actions.Click();
            actions.Perform();
        }

    }
}
