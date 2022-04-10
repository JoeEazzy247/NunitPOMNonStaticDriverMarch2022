using OpenQA.Selenium;

namespace NUnitProjectPOM.PageObjects
{
    public class ElementsPage : Base
    {
        public ElementsPage(IWebDriver? driver)
        {
            this.driver = driver;
        }

        #region 
        //Property
        static By TextBox => By.Id("item-0");

        #endregion

        public void ClickTextBox() =>
            driver?.FindElement(TextBox).Click();
    }
}
