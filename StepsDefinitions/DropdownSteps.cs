using OpenQA.Selenium;
using RIBProject.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;


namespace RIBProject.StepsDefinitions
{

    [Binding]
    public class DropdownSteps
    {
        private readonly IWebDriver _driver;
        private readonly DropdownPage _dropdownPage;

        public DropdownSteps(IWebDriver driver)
        {
            _dropdownPage = new DropdownPage(_driver);
        }

        [Given(@"I navigate to the dropdown demo page")]
        public void GivenINavigateToTheDropdownDemoPage()
        {
            _driver.Navigate().GoToUrl("http://www.globalsqa.com/demo-site/select-dropdown-menu/");
        }

        [When(@"I select ""(.*)"" from the dropdown")]
        public void WhenISelectFromTheDropdown(string country)
        {
            _dropdownPage.SelectCountry(country);
        }

        [Then(@"the selected country is displayed")]
        public void ThenTheSelectedCountryIsDisplayed()
        {
            // Add validation
        }
    }
}