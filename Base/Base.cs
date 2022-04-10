using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;

namespace NUnitProjectPOM
{
    public enum BrowserType
    {
        chrome,
        firefox
    }

    public class Base 
    {
        public IWebDriver? driver;


        public IWebDriver SelectBrowser(BrowserType browser) => browser switch
            {
                BrowserType.chrome => driver = new ChromeDriver(),
                BrowserType.firefox => driver = new FirefoxDriver(),
                _ => throw new NotFoundException("No such browser")
            };

        public IWebDriver? GetDriver()
        {
            //if (driver != null)
            //{
            //    return driver;
            //}
            //return driver = SelectBrowser(BrowserType.chrome);
            //tenary if statement
            return driver != null ? driver : driver = SelectBrowser(BrowserType.chrome);
        }

        [SetUp]
        public void Start()
        {
            driver = GetDriver();
            driver?.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(TestContext.Parameters["demoqaUrl"]);
            driver.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromSeconds(20);
        }

        [TearDown]
        public void QuitBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            driver = null;
        }

        //private static string Url => 
        //    TestContext.Parameters["demoqaUrl"]
        //        ?? throw new NotImplementedException("key not found.");
    }
}