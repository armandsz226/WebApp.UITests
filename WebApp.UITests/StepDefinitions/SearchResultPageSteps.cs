using System.Collections.Generic;
using Common.Automation;
using Common.Automation.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebApp.UITests.Locators;
using WebApp.UITests.Models;

namespace WebApp.UITests.StepDefinitions
{
    [Binding]
    public sealed class SearchResultPageSteps:StepBase
    {
        [When(@"I sort search results by ""(.*)""")]
        public void WhenISortSearchResultsByPrice(string sort)
        {
            Link.ClickByLinkText(sort);
        }
        [When(@"I select transaction type ""(.*)""")]
        public void WhenISelectTransactionType(string transactionType)
        {
            ComboBox.SelectElement(SearchResultLocators.CmbTransactionType, transactionType);
        }
        [When(@"I open link ""(.*)""")]
        public void WhenIOpenLink(string link)
        {
            Link.ClickByLinkText(link);
        }

        [When(@"I add to memo (.*) random ads")]
        public void WhenIAddToMemoRandomAds(int items)
        {
            var elementsToClick = RandomHelper.GetRandomNumbers(items, 1, 20);
            var favorites = new List<FavoritesModel>();
            string elementId;
            foreach (var c in elementsToClick)
            {
                CheckBox.Check(SearchResultLocators.ChkResults, c, out elementId);
                favorites.Add(new FavoritesModel() { Id = elementId });
                ScenarioContext.Current["favorites"] = favorites;
            }
        }

    }
}
