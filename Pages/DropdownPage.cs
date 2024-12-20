using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace RIBProject.Pages
{
    public class DropdownPage
    {
        private readonly IWebDriver _driver;
        public DropdownPage(IWebDriver driver) => _driver = driver;

        private IWebElement CountryDropdown => _driver.FindElement(By.Id("country"));

        public void SelectCountry(string country)
        {
            var selectElement = new SelectElement(CountryDropdown);
            selectElement.SelectByText(country);
        }
    }
}