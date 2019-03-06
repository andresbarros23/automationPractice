using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{
    [TestClass]
    public class SignIn
    {
        IWebDriver driver;
        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
        }

        [TestMethod]
        public void SignInTest()
        {
            driver.Url = "http://automationpractice.com/index.php";
            driver.FindElement(By.ClassName("login")).Click();          
            driver.FindElement(By.Id("email")).SendKeys("andres@test.com");
            driver.FindElement(By.Id("passwd")).SendKeys("testing");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            string successfullLogin = driver.FindElement(By.ClassName("info-account")).Text;
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", successfullLogin);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
