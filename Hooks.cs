using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using NUnit.Framework;


[Binding]
public class Hooks
{
    private readonly ScenarioContext _scenarioContext;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void Setup()
    {
        var driver = new ChromeDriver(); // Initialize WebDriver
        driver.Manage().Window.Maximize();
        _scenarioContext["WebDriver"] = driver; // Store WebDriver in ScenarioContext
    }

    [AfterScenario]
    public void TearDown()
    {
        if (_scenarioContext.ContainsKey("WebDriver"))
        {
            var driver = (IWebDriver)_scenarioContext["WebDriver"];
            driver.Quit(); // Quit the WebDriver after scenario execution
        }
    }
}