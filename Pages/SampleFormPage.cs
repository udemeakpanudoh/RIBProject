using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;


namespace RIBProject.Pages
{
        public class SamplePage
        {
            private readonly IWebDriver _driver;

            public SamplePage(IWebDriver driver)
            {
                _driver = driver;
            }

            // Locators
            private IWebElement NameField => _driver.FindElement(By.Id("g2599-name"));
            private IWebElement EmailField => _driver.FindElement(By.Id("g2599-email"));
            private IWebElement WebsiteField => _driver.FindElement(By.Id("g2599-website"));
            private IWebElement ExperienceDropdown => _driver.FindElement(By.Id("g2599-experienceinyears"));
            private IWebElement ExpertiseRadioButton => _driver.FindElement(By.XPath("//input[@type='checkbox' and @value='Automation Testing']"));
            private IWebElement EducationRadioButton => _driver.FindElement(By.XPath("//*[@id=\"contact-form-2599\"]/form/div[6]/label[3]/input"));
            private IWebElement MessageField => _driver.FindElement(By.Id("contact-form-comment-g2599-comment"));
            private IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[contains(text(),'Submit')]"));

            // Actions
            public void EnterName(string name) => NameField.SendKeys(name);
            public void EnterEmail(string email) => EmailField.SendKeys(email);

            public void ExpertiseRadioButton(string expertise) => ExpertiseRadioButton.Click();

        public void EducationRadioButton(string education)
        {
            EducationRadioButton.Click();
        }

        public void EnterWebsite(string website) => WebsiteField.SendKeys(website);
            public void SelectExperience(string experience)
            {
                var dropdown = new SelectElement(ExperienceDropdown);
                dropdown.SelectByText(experience);
            }
            public void EnterMessage(string message) => MessageField.SendKeys(message);
            public void SubmitForm() => SubmitButton.Click();
        }
    }