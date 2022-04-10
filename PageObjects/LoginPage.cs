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

        #endregion



        public void ClickLogin()
        {
            IWebElement? login = driver?.FindElement(Login);
            login?.ScrollIntoViewViaJs(driver);
            login?.ClickViaJs(driver);
        }

        public string? GetLoginHeaderTxt() => driver?.FindElement(LoginheaderTxt).Text;
    }
}
