using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace automationpractice
{
    [TestClass]
    public class NewAccount
    {
        IWebDriver driver;
        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [TestMethod]
        public void NewAccountTest()
        {
            driver.Url = "http://automationpractice.com/index.php";
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.Id("email_create")).SendKeys(DateTime.Now.Millisecond+"@test.com"); //Generate different emails with Miliseconds to avoid using an existing account
            driver.FindElement(By.Id("SubmitCreate")).Click();
            driver.FindElement(By.Id("customer_firstname")).SendKeys("Andres");
            driver.FindElement(By.Id("customer_lastname")).SendKeys("Barros");
            driver.FindElement(By.Id("passwd")).SendKeys("testing");
            new SelectElement(driver.FindElement(By.Id("days"))).SelectByValue("22");
            new SelectElement(driver.FindElement(By.Id("months"))).SelectByValue("2");
            new SelectElement(driver.FindElement(By.Id("years"))).SelectByValue("1992");
            driver.FindElement(By.Id("address1")).SendKeys("Testing 123, Dorrego");
            driver.FindElement(By.Id("city")).SendKeys("Mendoza");
            new SelectElement(driver.FindElement(By.Id("id_state"))).SelectByValue("22");
            driver.FindElement(By.Id("postcode")).SendKeys("71239");
            driver.FindElement(By.Id("phone_mobile")).SendKeys("7123912345");
            driver.FindElement(By.Id("alias")).SendKeys("andres23");
            driver.FindElement(By.Id("submitAccount")).Click();
            driver.FindElement(By.ClassName("info-account")); //If this class is presented, the user is logged
            driver.FindElement(By.ClassName("logout")).Click();
            driver.FindElement(By.ClassName("login")); //If this class is presented, the user is not logged

        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}