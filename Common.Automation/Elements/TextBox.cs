using OpenQA.Selenium;

namespace Common.Automation.Elements
{
    public class TextBox : ElementBase
    {
        public TextBox(IWebDriver driver) : base(driver)
        {

        }

        public void EnterText(By by, string textToEnter)
        {
            var element = GetElement(by);
            if (!string.IsNullOrEmpty(element.GetAttribute("value")))
            {
                element.Clear();
            }
            element.SendKeys(textToEnter);
        }
    }
}