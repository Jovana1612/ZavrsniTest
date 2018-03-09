﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace zavrsniTestSelenium
{
    class ZavrsniTestSelenium
    {
        IWebDriver driver;
        string isDisplayed;
        string email = "qa@testing.net";
        string pwd = "pw0rd4qa!";

        [SetUp]
        public void StartBrowser()
        {
            driver = new FirefoxDriver();

        }

        public void GoToURL(string url)
        {
            this.driver.Url = url;
        }

        public void Sleep(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        public IWebElement WaitForElement(By by, int timeoutSeconds)
        {
            if (timeoutSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
                wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        [Test]


        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
