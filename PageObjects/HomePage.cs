using NUnitProjectPOM.utilities;
using OpenQA.Selenium;

namespace NUnitProjectPOM.PageObjects
{
    public class HomePage : Base
    {
        public HomePage(IWebDriver? driver)
        {
            this.driver = driver;
        }

        #region 
        //Properties
        static By Elements => 
            By.XPath("//div[@class='card mt-4 top-card'][.='Elements']");
        static By Forms =>
            By.XPath("//div[@class='card mt-4 top-card'][.='Forms']");
        static By AlertFramesAndWindows =>
            By.XPath("//div[@class='card mt-4 top-card'][.='Alerts, Frame & Windows']");
        static By Widget =>
            By.XPath("//div[@class='card mt-4 top-card'][.='Widgets']");
        static By BookStoreApplications =>
            By.XPath("//div[@class='card mt-4 top-card'][.='Book Store Application']");
        #endregion



        //Methods which calls the above properties
        public void ClickElements()=>
            driver?.FindElement(Elements).Click();

        public void ClickForms() =>
            driver?.FindElement(Forms).Click();

        public void ClickAlertFrameWindows() =>
            driver?.FindElement(AlertFramesAndWindows).Click();

        public void ClickWidgets() =>
            driver?.FindElement(Widget).Click();

        public void ClickBookStoreApplications()
        {
            IWebElement? element = 
                driver?.FindElement(BookStoreApplications);
            element?.ScrollIntoViewViaJs(driver);
            element?.ClickViaJs(driver);
            //IjavaScriptExtensions.ScrollIntoViewViaJs(element, _driver);
            //IjavaScriptExtensions.ClickViaJs(element, _driver);
        }
            
    }
}
