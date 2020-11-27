using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TC_installer
{
    class Download
    {
        public static void DownloadAll(IWebDriver driver)
        {
            MySQL(driver);
            Git(driver);
            VS_Code(driver);
            VisualStudioCommunity(driver);
            BestBuyScript(driver);
        }

        public static void MySQL(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://dev.mysql.com/downloads/windows/installer/8.0.html");
            Thread.Sleep(2000);

            IWebElement MySQL_downloadButton = driver.FindElement(By.CssSelector("tr:nth-child(3) a"));
            MySQL_downloadButton.Click();
            Thread.Sleep(2000);

            MySQL_downloadButton = driver.FindElement(By.CssSelector("#content > div > div > p:nth-child(6) > b > a"));
            MySQL_downloadButton.Click();
            Thread.Sleep(2000);
        }

        public static void Git(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://git-scm.com/");
            Thread.Sleep(2000);

            IWebElement git_downloadButton = driver.FindElement(By.Id("download-link"));
            git_downloadButton.Click();
            Thread.Sleep(2000);
        }

        public static void VS_Code(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://code.visualstudio.com/download");
            Thread.Sleep(2000);

            IWebElement visualStudioCode_downloadButton = driver.FindElement(By.CssSelector("button.link-button.dlink"));
            visualStudioCode_downloadButton.Click();
            Thread.Sleep(2000);
        }

        public static void VisualStudioCommunity(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://visualstudio.microsoft.com/free-developer-offers/");
            Thread.Sleep(3000);

            IWebElement visualStudioCommunity_downloadButton = driver.FindElement(By.CssSelector("span.fusion-button-text"));
            visualStudioCommunity_downloadButton.Click();
            Thread.Sleep(2000);
        }

        public static void BestBuyScript(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://drive.google.com/file/d/1JK7j9pREUf5r2OHGO_b8B2n0JyWLmMLz/view");
            Thread.Sleep(1000);

            IWebElement bestBuy_Script = driver.FindElement(By.CssSelector(".ndfHFb-c4YZDc-nupQLb-Bz112c"));
            bestBuy_Script.Click();
            Thread.Sleep(1000);
        }
    }
}
