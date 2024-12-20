using OpenQA.Selenium;
using RIBProject.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;


namespace RIBProject.StepsDefinitions
{
    [Binding]
    public class DragAndDropSteps
    {
        private readonly IWebDriver _driver;
        private readonly DragAndDropPage _dragAndDropPage;

        public DragAndDropSteps(ScenarioContext scenarioContext)
        {
            _driver = (IWebDriver)scenarioContext["WebDriver"]; // Retrieve WebDriver
        }

        [Given(@"I navigate to the Drag and Drop page")]
        public void GivenINavigateToDragAndDropPage()
        {
            _driver.Navigate().GoToUrl("http://www.globalsqa.com/demo-site/draganddrop/");
        }

        [When(@"I drag the image to the trash")]
        public void WhenIDragImageToTrash()
        {
            _dragAndDropPage.DragImageToTrash();
        }

        [Then(@"the image should be successfully dropped")]
        public void ThenImageShouldBeDropped()
        {
            // Validation logic
        }
    }

}