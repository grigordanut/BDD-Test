using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HomeAppliancesCost.StepDefinitions
{
    [Binding]
    public class NorthernIrelandResidentStepDefinitions
    {
        IWebDriver driver;
        [Given(@"I am a resident from Northern Ireland")]
        public void GivenIAmAResidentFromNorthernIreland()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.citizensadvice.org.uk/");
        }

        [When(@"I select This advice applies to Northern Ireland")]
        public void WhenISelectThisAdviceAppliesToNorthernIreland()
        {
            driver.FindElement(By.XPath("//*[@id=\"home-extent-popup\"]/div/div/a[2]")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"I should get the results message as ‘The advice on this website doesn’t cover Northern Ireland’")]
        public void ThenIShouldGetTheResultsMessageAsTheAdviceOnThisWebsiteDoesnTCoverNorthernIreland()
        {
            throw new PendingStepException();
        }
    }
}
