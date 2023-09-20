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
    public class ScotlandResidentCostStepDefinitions
    {
        IWebDriver driver;
        [Given(@"I am a resident from Scotland")]
        public void GivenIAmAResidentFromScotland()
        {
            driver = new ChromeDriver();
            //driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.citizensadvice.org.uk/");
            driver.FindElement(By.XPath("//*[@id=\"home-extent-popup\"]/div/div/a[3]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"main-nav\"]/ul/li[4]/a")).Click();            
            driver.FindElement(By.XPath("//*[@id=\"cads-main-content\"]/div/div/div/main/div[1]/nav/ul/li/a")).Click();         
            driver.FindElement(By.XPath("//*[@id=\"cads-main-content\"]/div/div/div/main/div[1]/nav/ul/li[6]/a")).Click();
        }

        [When(@"I add the list appliances Electric blanket and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesElectricBlanketAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Electric blanket");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 1);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 45);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("67");
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances Fan heater and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesFanHeaterAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Fan heater");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 2);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances Broadband router and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesBroadbandRouterAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Broadband router");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 45);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 20);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("week");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances Games console and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesGamesConsoleAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Games console");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 2);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 15);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances PC or desktop computer and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesPCOrDesktopComputerAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("PC or desktop computer");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 40);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("week");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances Dehumidifier and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesDehumidifierAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Dehumidifier");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 30);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 20);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("week");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances Dishwasher and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesDishwasherAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Dishwasher");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 2);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 25);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances Oven and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesOvenAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Oven");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 1);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances Iron and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesIronAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Iron");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 1);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [When(@"I add the list appliances Vacuum cleaner and its average usage and the national average rates")]
        public void WhenIAddTheListAppliancesVacuumCleanerAndItsAverageUsageAndTheNationalAverageRates()
        {
            SelectElement appliance = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"appliance\"]")));
            appliance.SelectByText("Vacuum cleaner");
            driver.FindElement(By.XPath("//*[@id=\"hours\"]")).SendKeys("" + 1);
            driver.FindElement(By.XPath("//*[@id=\"mins\"]")).SendKeys("" + 30);
            SelectElement frequency = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"frequency\"]")));
            frequency.SelectByValue("day");
            driver.FindElement(By.XPath("//*[@id=\"kwhcost\"]")).SendKeys("" + 67);
            driver.FindElement(By.XPath("//*[@id=\"submit\"]")).Click();
        }

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly costs")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCosts()
        {
            string actual = driver.FindElement(By.XPath("//*[@id=\"RootPlaceHolder_RootPlaceHolder_SubHeading\"]/span")).Text;
            Console.WriteLine(actual);
            String expected = "This advice applies to Scotland";
            Assert.AreEqual(actual, expected);
            driver.FindElement(By.XPath("//*[@id=\"appliance_running\"]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"reset\"]")).Click();
            driver.SwitchTo().Alert().Accept();
            driver.Quit();
        }
    }
}
