using System;
using OpenQA.Selenium;

namespace Common.Automation.Elements
{
    public class CheckBox:ElementBase
    {
        public CheckBox(IWebDriver driver) : base(driver)
        {

        }

        public void Check(By by)
        {
            var element = GetElement(by);
            element.Click();
        }
        public void Check(By by, int num, out string checkedElementsId)
        {
            var elements = GetElements(by);
            var checkedElements = elements[num];
            checkedElements.Click();
            checkedElementsId = checkedElements.GetAttribute("Id");
        }
    }
}