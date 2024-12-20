using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;


namespace RIBProject.Pages
{
    public class DragAndDropPage
    {
        private readonly IWebDriver _driver;
        public DragAndDropPage(IWebDriver driver) => _driver = driver;

        private IWebElement SourceImage => _driver.FindElement(By.CssSelector(".ui-draggable"));
        private IWebElement TrashBin => _driver.FindElement(By.Id("trash"));

        public void DragImageToTrash()
        {
            var actions = new Actions(_driver);
            actions.DragAndDrop(SourceImage, TrashBin).Perform();
        }
    }
}