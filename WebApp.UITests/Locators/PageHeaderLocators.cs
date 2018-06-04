using OpenQA.Selenium;

namespace WebApp.UITests.Locators
{
    public static class PageHeaderLocators
    {
        public static By LinkRuLanguage = By.XPath("//a[@href='/ru/']");
        public static By LinkLvLanguage = By.XPath("//a[@href='/lv/']");

        public static By Search = By.XPath("//span[@class='page_header_menu']/b[3]/a");

        public static By Favorites = By.XPath("/html[1]/body[1]/div[2]/div[1]/span[2]/span[1]/b[1]/a[1]");

    }
}
