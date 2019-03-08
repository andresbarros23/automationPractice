using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace automationpractice
{
    class Actions
    {

        public static void ClickOn(IWebDriver driver, IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", element);
       
            }
        }

        public static void Type(IWebDriver driver, IWebElement element, String value)
        {
            element.SendKeys(value);
        }

        public static void SelectElement(IWebDriver driver, SelectElement element, String value)
        {
            element.SelectByValue(value);
        }
    }
}
