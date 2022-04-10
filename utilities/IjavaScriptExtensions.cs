using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProjectPOM.utilities
{
    public class IjavaScriptExtensions
    {
        public static void ScrollIntoViewViaJs(IWebElement? element,IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public static void ClickViaJs(IWebElement? element, IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].click()", element);
        }
    }
}
