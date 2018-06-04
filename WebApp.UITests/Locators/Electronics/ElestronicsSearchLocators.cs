using OpenQA.Selenium;

namespace WebApp.UITests.Locators.Electronics
{
    public static class ElectronicsSearchLocators
    {
        public static By TxtPhrase = By.Id("ptxt");
        public static By LblPhrase = By.XPath("//td[@class='td6'][contains(text(),'Искомое слово или фраза:')]");
        public static By TxtPriceMin = By.Name("topt[8][min]");
        public static By TxtPriceMax = By.Name("topt[8][max]");
        public static By CmbTransactionType = By.Name("sid");
        public static By CmbRegion = By.Id("s_region_select");
        public static By CmbPeriod = By.Name("pr");
        public static By CmbSortBy = By.Name("sort");
        public static By BtnSearch = By.Id("sbtn");
    }
}
