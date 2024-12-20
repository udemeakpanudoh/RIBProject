using OpenQA.Selenium;
using RIBProject.Pages;
using TechTalk.SpecFlow;


namespace RIBProject.StepsDefinitions
{

    [Binding]
    public class SamplePageSteps
    {
        private readonly IWebDriver _driver;
        private readonly SamplePage _samplePage;

        public SamplePageSteps(IWebDriver driver)
        {
            _driver = driver;
            _samplePage = new SamplePage(_driver);
        }

        [Given(@"I navigate to the sample page form")]
        public void GivenINavigateToTheSamplePageForm()
        {
            _driver.Navigate().GoToUrl("https://www.globalsqa.com/samplepagetest/");
        }

        [When(@"I fill out the form with the following details:")]
        public void WhenIFillOutTheFormWithTheFollowingDetails(Table table)
        {
            foreach (var row in table.Rows)
            {
                string field = row["Field"];
                string value = row["Value"];

                switch (field)
                {
                    case "Name":
                        _samplePage.EnterName(value);
                        break;
                    case "Email":
                        _samplePage.EnterEmail(value);
                        break;
                    case "Website":
                        _samplePage.EnterWebsite(value);
                        break;
                    case "Experience":
                        _samplePage.SelectExperience(value);
                        break;
                    case "Message":
                        _samplePage.EnterMessage(value);
                        break;
                }
            }
        }

        [Then(@"the form is submitted successfully")]
        public void ThenTheFormIsSubmittedSuccessfully()
        {
            _samplePage.SubmitForm();
            // Add assertion here if needed to verify success
        }
    }
}