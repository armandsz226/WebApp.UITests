using Common.Automation;
using TechTalk.SpecFlow;

namespace WebApp.UITests.StepDefinitions
{
    [Binding]
    class BackgroundSteps: StepBase
    {
        [Given(@"I have maximized browser window")]
        public void GivenIHaveMaximizedBrowserWindow()
        {
            Browser.MaximizeWindow();
        }

        [Given(@"I have opened site ""(.*)""")]
        public void GivenIHaveOpenedSite(string pageUrl)
        {
            Browser.NavigateTo(pageUrl);
        }

    }
}
