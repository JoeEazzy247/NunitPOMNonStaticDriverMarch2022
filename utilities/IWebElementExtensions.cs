using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProjectPOM.utilities
{
    public static class IWebElementExtensions
    {
        public static void ScrollIntoViewViaJs(this IWebElement element, IWebDriver? driver) => (driver as IJavaScriptExecutor)?
                .ExecuteScript("arguments[0].scrollIntoView(true);", element);

        public static void ClickViaJs(this IWebElement? element, IWebDriver? driver) => (driver as IJavaScriptExecutor)?
                .ExecuteScript("arguments[0].click()", element);
    }
}
