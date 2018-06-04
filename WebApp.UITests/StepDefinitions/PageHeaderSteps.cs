using Common.Automation;
using TechTalk.SpecFlow;
using WebApp.UITests.Locators;

namespace WebApp.UITests.StepDefinitions
{
    [Binding]
    public sealed class PageHeaderSteps:StepBase
    {
        [Given(@"I have switched to russian language")]
        public void WhenISwitchToRussianLanguage()
        {
            Link.Click(PageHeaderLocators.LinkRuLanguage);
        }
        [Given(@"I have switched to latvian language")]
        public void WhenISwitchLatvianToLanguage()
        {
            Link.Click(PageHeaderLocators.LinkLvLanguage);
        }

        [When(@"I go to favorites")]
        public void WhenIgoToFavorites()
        {
            Link.WaitUntilElementIsClickable(PageHeaderLocators.Favorites);
            Link.Click(PageHeaderLocators.Favorites);
        }

    }
}
