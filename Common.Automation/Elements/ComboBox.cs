using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Common.Automation.Elements
{
    public class ComboBox:ElementBase
    {
        public ComboBox(IWebDriver driver) : base(driver)
        {

        }

        public void SelectElement(By by, string textToSelect)
        {
            var element = GetElement(by);
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(textToSelect);
        }
    }
}