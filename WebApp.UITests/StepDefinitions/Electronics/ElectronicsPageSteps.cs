using Common.Automation;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebApp.UITests.Locators;
using WebApp.UITests.Locators.Electronics;
using WebApp.UITests.Models;

namespace WebApp.UITests.StepDefinitions.Electronics
{
    [Binding]
    public sealed class ElectronicsPageSteps:StepBase
    {
        [When(@"I search for a electronics by following parameters:")]
        public void WhenISearchForAElectronicsByFollowingParameters(Table table)
        {
            Link.Click(PageHeaderLocators.Search);
            var sl = table.CreateInstance<ElectronicsSearchModel>();
            EnterElectronicsSearchPhrase(sl.Phrase);
            SelectElectronicsSearchRegion(sl.Region);
            SelectElectronicsSearchPeriod(sl.Period);
            ExecuteElectronicsSearch();
        }
        [When(@"I enter electronics search phrase""(.*)""")]
        public void EnterElectronicsSearchPhrase(string phrase)
        {
            if (string.IsNullOrEmpty(phrase)) return;
            TextBox.EnterText(ElectronicsSearchLocators.TxtPhrase, phrase);
            //Workaround to disable suggestion window
            TextBox.ClickAt(ElectronicsSearchLocators.TxtPhrase,-10,1);
        }
        [When(@"I select electronics search region ""(.*)""")]
        public void SelectElectronicsSearchRegion(string region)
        {
            if (string.IsNullOrEmpty(region)) return;
            ComboBox.SelectElement(ElectronicsSearchLocators.CmbRegion, region);
        }
        [When(@"I select electronics search period ""(.*)""")]
        public void SelectElectronicsSearchPeriod(string period)
        {
            if (string.IsNullOrEmpty(period)) return;
            ComboBox.SelectElement(ElectronicsSearchLocators.CmbPeriod, period);
        }
        [When(@"I execute search")]
        public void ExecuteElectronicsSearch()
        {
            Button.Click(ElectronicsSearchLocators.BtnSearch);
        }       

        [When(@"I enter search option price between ""(\d*[,|.]?\d*)"" and ""(\d*[,|.]?\d*)""")]
        public void EnterSearchOptionPriceBetweenAnd_(string priceMin, string priceMax)
        {
            EnterElectronicsSearchPriceMin(priceMin);
            EnterElectronicsSearchPriceMax(priceMax);
        }
        [When(@"I enter electronics price min ""(\d*[,|.]?\d*)""")]
        public void EnterElectronicsSearchPriceMin(string priceMin)
        {
            if (string.IsNullOrEmpty(priceMin)) return;
            TextBox.EnterText(ElectronicsSearchLocators.TxtPriceMin, priceMin);
        }
        [When(@"I enter electronics price max ""(\d*[,|.]?\d*)""")]
        public void EnterElectronicsSearchPriceMax(string priceMax)
        {
            if (string.IsNullOrEmpty(priceMax)) return;
            TextBox.EnterText(ElectronicsSearchLocators.TxtPriceMax, priceMax);
        }
    }
}
