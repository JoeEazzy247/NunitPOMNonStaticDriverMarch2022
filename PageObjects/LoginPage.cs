using NUnit.Framework;
using NunitPOMNonStaticDriverMarch2022.utilities;
using NUnitProjectPOM.utilities;
using OpenQA.Selenium;

namespace NUnitProjectPOM.PageObjects
{
    public class LoginPage : Base
    {
        public LoginPage(IWebDriver? driver)
        {
            this.driver = driver;
        }

        #region 
        //Property
        static By Login => By.XPath("(//li[@id='item-0'])[6]");
        static By LoginheaderTxt => By.XPath("(//form[@id='userForm']/div)[1]");
        static By Username => By.Id("userName");
        static By Password => By.Id("password");
        static By login => By.Id("login");
        static By UserNameLbl => By.Id("userName-value");
        #endregion



        public void ClickLogin()
        {
            IWebElement? login = driver?.FindElement(Login);
            WaitExtensions.WaitForElementAndclick(driver, Login);
            login?.ScrollIntoViewViaJs(driver);
            login?.ClickViaJs(driver);
        }

        public string? GetLoginHeaderTxt() => driver?.FindElement(LoginheaderTxt).Text;

        public void EnterCredentials()
        {
            driver?.FindElement(Username).SendKeys(TestContext.Parameters["Username"]);
            driver?.FindElement(Password).SendKeys(TestContext.Parameters["Password"]);
            driver?.FindElement(login).Click();
        }

        public string IstextDisplayed()
        {
            var text = driver?.FindElement(UserNameLbl);
            //WaitExtensions.WaitForAndGettext(driver,text, TestContext.Parameters["Username"]);
            return text.Text;
        }
    }
}
