using System.Collections.Generic;
using System.Threading;
using Common.Automation;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebApp.UITests.Models;

namespace WebApp.UITests.StepDefinitions
{
    [Binding]
    public sealed class FavoritesPageSteps:StepBase
    {
        private PageHeaderSteps PageHeaderSteps { get; } = new PageHeaderSteps();

        [Then(@"selected ads matches with the previously selected")]
        public void ThenSelectedAdsMatchesWithThePreviouslySelected()
        {
            var favorites = (List<FavoritesModel>)ScenarioContext.Current["favorites"];
            Browser.Home();
            //For debug purpose
            //Thread.Sleep(2000);
            PageHeaderSteps.WhenIgoToFavorites();
            foreach (var c in favorites)
            {
                Assert.IsTrue(CheckBox.IsDisplayedById(c.Id));
            }
            
        }

    }
}
