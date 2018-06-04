using Common.Automation;
using TechTalk.SpecFlow;

namespace WebApp.UITests.StepDefinitions
{
    [Binding]
    public sealed class MainPageSteps: StepBase
    {
        [When(@"I go to section ""(.*)""")]
        public void WhenIGoToSection(string section)
        {
            Link.ClickByLinkText(section);
        }

    }
}
