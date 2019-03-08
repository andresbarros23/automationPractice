using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;


namespace automationpractice.Classes
{
    class homepage
    {
        private IWebDriver driver;

        public homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "contact-link")]
        private IWebElement contactUsLink;
        public void clickOnContactLink()
        {
            Actions.ClickOn(driver,contactUsLink);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
    }
}
