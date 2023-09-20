using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace HomeAppliancesCost.StepDefinitions
{
    [Binding]
    public class WalesResidentCostStepDefinitions
    {
        IWebDriver driver;
        [Given(@"I am a resident from Wales")]
        public void GivenIAmAResidentFromWales()
        {
            driver = new ChromeDriver();
            //driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.citizensadvice.org.uk/");
            driver.FindElement(By.XPath("//*[@id=\"home-extent-popup\"]/div/div/a[4]")).Click();            
            driver.FindElement(By.XPath("/html/body/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"main-nav\"]/ul/li[4]/a")).Click();            
            driver.FindElement(By.XPath("//*[@id=\"cads-main-content\"]/div/div/div/main/div[1]/nav/ul/li/a")).Click();            
            driver.FindElement(By.XPath("//*[@id=\"cads-main-content\"]/div/div/div/main/div[1]/nav/ul/li[6]/a")).Click();
        }

        [When(@"I add the list appliance Immersion heater and its average usage and the national average rates")]
        public void WhenIAddTheListApplianceImmersionHeaterAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Immersion heater");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 35);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("week");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliance Broadband router and its average usage and the national average rates")]
        public void WhenIAddTheListApplianceBroadbandRouterAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Broadband router");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 50);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("week");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliance Washing machine and its average usage and the national average rates")]
        public void WhenIAddTheListApplianceWashingMachineAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Washing machine");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 3);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 20);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliance Microwave and its average usage and the national average rates")]
        public void WhenIAddTheListApplianceMicrowaveAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Microwave");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 1);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 15);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliance Slow cooker and its average usage and the national average rates")]
        public void WhenIAddTheListApplianceSlowCookerAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Slow cooker");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 50);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("week");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly costs is")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCostsIs()
        {
            string actual = driver.FindElement(By.XPath("//*[@id=\"RootPlaceHolder_RootPlaceHolder_SubHeading\"]/span")).Text;
            Console.WriteLine(actual);
            String expected = "This advice applies to Wales";
            Assert.AreEqual(actual, expected);
            driver.FindElement(By.XPath("//*[@id=\"appliance_running\"]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"reset\"]")).Click();
            driver.SwitchTo().Alert().Accept();
            driver.Quit();
        }
    }
}
