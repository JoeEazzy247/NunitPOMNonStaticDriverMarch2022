using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitPOMNonStaticDriverMarch2022.utilities
{
    public class WaitExtensions 
    {
        public static void WaitForElementAndclick(IWebDriver driver, By by)
        {
            var Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static void WaitForAndGettext(IWebDriver? driver, By by)
        {
            var Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            Wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
