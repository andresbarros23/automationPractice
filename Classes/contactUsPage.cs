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
    class contactUsPage
    {
        private IWebDriver driver;

        public contactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "id_order")]
        private IWebElement idOrder;

        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement message;

        [FindsBy(How = How.Id, Using = "submitMessage")]
        private IWebElement submitButton;

        [FindsBy(How = How.CssSelector, Using = "p.alert.alert-success")]
        private IWebElement successMessage;

        public SelectElement getDropdownElement()
        {
            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("id_contact")));
            return selectElement;
        }

        public void FillContactUsForm(String email, String id_order, String message)
        {
            Actions.SelectElement(driver, getDropdownElement(), "2");
            Actions.Type(driver, this.email, email);
            Actions.Type(driver, this.idOrder, id_order);
            Actions.Type(driver, this.message, message);
            Actions.ClickOn(driver,submitButton);
        }

        public String GetSuccessMessage()
        {
            return successMessage.Text;
        }
    }
}
