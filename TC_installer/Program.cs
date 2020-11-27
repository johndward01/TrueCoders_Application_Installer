using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Threading;

namespace TC_installer
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            watch.Start();

            IWebDriver driver = new ChromeDriver();
            Download.DownloadAll(driver);
        }
    }
}
