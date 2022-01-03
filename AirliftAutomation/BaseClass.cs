using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace AirliftAutomation
{
    internal class BaseClass
    {
        public string url = "https://airliftexpress.com/";
        IWebDriver driver = new ChromeDriver();


        public void OpenUrl()
        {
            
           driver.Navigate().GoToUrl(url);
           driver.Manage().Window.Maximize();
        }

        public void entertext(By by, string value)
        {
            driver.FindElement(by).SendKeys(value);
        }
        public void clickOnButton(By by)
        {
            driver.FindElement(by).Click();
        }
        public void clearObject(By by, string value)
        {
            driver.FindElement(by).Clear();
        }
        public void waitForElementtoLoad(int wait = 5)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(wait);
        }
        public void hardWait(int sec)
        {
            Thread.Sleep(sec*1000);
        }

        public String getText(By by)
        {
            string text = driver.FindElement(by).Text;

            return text;
        }

        public void ListofElement(By by)
        {
            driver.FindElements(by);
        }
    }

   
}
