using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Automation;
using TechTalk.SpecFlow;

namespace WebApp.UITests.StepDefinitions
{
    [Binding]
    public sealed class FavoritesPageSteps:StepBase
    {
        private PageHeaderSteps _pageHeaderSteps => new PageHeaderSteps();
        [Then(@"selected ads matches with the previously selected")]
        public void ThenSelectedAdsMatchesWithThePreviouslySelected()
        {
            Browser.Home();
            _pageHeaderSteps.WhenIgoToFavorites();
        }

    }
}
