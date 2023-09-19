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
            driver.Navigate().GoToUrl("https://www.citizensadvice.org.uk/");
            driver.FindElement(By.XPath("//*[@id=\"home-extent-popup\"]/div/div/a[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"main-nav\"]/ul/li[4]/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/div/div[2]/ul/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/div/div[2]/ul/li[6]/a")).Click();
        }

        [When(@"I add the list appliances Electric blanket and its average usage and the national average rate")]
        public void WhenIAddTheListAppliancesElectricBlanketAndItsAverageUsageAndTheNationalAverageRate()
        {
            [When(@"I add the list appliances Electric blanket and its average usage and the national average rate")]
            public void WhenIAddTheListAppliancesElectricBlanketAndItsAverageUsageAndTheNationalAverageRate()
            {
                SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
                appliance.SelectByText("Electric blanket");
                driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 1);
                driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
                SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                frequency.SelectByValue("day");
                driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 34);
                driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
            }

            [When(@"I add the list appliances Immersion heater and its average usage and the national average rate")]
            public void WhenIAddTheListAppliancesImmersionHeaterAndItsAverageUsageAndTheNationalAverageRate()
            {
                SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
                appliance.SelectByText("Immersion heater");
                driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 40);
                driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
                SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                frequency.SelectByValue("week");
                driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 34);
                driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
            }


            [When(@"I add the list appliances Broadband router and its average usage and the national average rate")]
            public void WhenIAddTheListAppliancesBroadbandRouterAndItsAverageUsageAndTheNationalAverageRate()
            {
                SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
                appliance.SelectByText("Broadband router");
                driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 50);
                driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
                SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                frequency.SelectByValue("week");
                driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 34);
                driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
            }

            [When(@"I add the list appliances Games console and its average usage and the national average rate")]
            public void WhenIAddTheListAppliancesGamesConsoleAndItsAverageUsageAndTheNationalAverageRate()
            {
                SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
                appliance.SelectByText("Games console");
                driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 1);
                driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 10);
                SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                frequency.SelectByValue("day");
                driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 34);
                driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
            }
        }

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly cost")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCost()
        {
            throw new PendingStepException();
        }
    }
}
