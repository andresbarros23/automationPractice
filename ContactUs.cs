using System;
using automationpractice.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{
    [TestClass]
    public class ContactUs
    {
        IWebDriver driver;
        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TestMethod]
        public void ContactUsTest()
        {

            homepage homePage = new homepage(driver);
            

            homePage.goToPage();
            homePage.clickOnContactLink();
            contactUsPage cUsPage = new contactUsPage(driver);
            cUsPage.FillContactUsForm("email@gol.com","102030","message123");
            Assert.AreEqual("Your message has been successfully sent to our team.", cUsPage.GetSuccessMessage());

        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }
    }
}
