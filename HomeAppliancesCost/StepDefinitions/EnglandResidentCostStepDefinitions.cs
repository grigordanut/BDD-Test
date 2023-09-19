using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HomeAppliancesCost.StepDefinitions
{
    [Binding]
    public class EnglandResidentCostStepDefinitions
    {
        IWebDriver driver;
        [Given(@"I am a resident from England")]
        public void GivenIAmAResidentFromEngland()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"I add the list appliances Electric blanket and its average usage and the national average rate")]
        public void WhenIAddTheListAppliancesElectricBlanketAndItsAverageUsageAndTheNationalAverageRate()
        {
            throw new PendingStepException();
        }

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly cost")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCost()
        {
            throw new PendingStepException();
        }
    }
}
