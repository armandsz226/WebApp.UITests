using OpenQA.Selenium;

namespace WebApp.UITests.Locators
{
    public static class SearchResultLocators
    {
        public static By CmbTransactionType = By.Name("sid");
        public static By ChkResults = By.XPath("(//input[@name='mid[]'])");
    }
}
