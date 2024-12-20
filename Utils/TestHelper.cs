using OpenQA.Selenium;
using NUnit.Framework;


public class TestHelper
{
    private static readonly object? ScreenshotImageFormat;

    public static void CaptureScreenshot(IWebDriver driver, string testName, Screenshot screenshot)
    {
        //var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
        //screenshot.SaveAsFile($"./TestResults/{testName}.png");
    }
}