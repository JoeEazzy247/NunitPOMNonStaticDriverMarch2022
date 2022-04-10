using NUnit.Framework;
using NUnitProjectPOM;
using NUnitProjectPOM.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NunitProjectNonStaticDriverPOM.TestModules
{
    public class LoginTest : Base
    {
        private readonly HomePage _homePage;
        private readonly ElementsPage _elementsPage;
        private readonly LoginPage? _loginPage;

        public LoginTest()
        {
            _homePage = new HomePage(GetDriver());
            _elementsPage = new ElementsPage(GetDriver());
            _loginPage = new LoginPage(GetDriver());
        }

        
        [Test]
        public void TextBoxTest1()
        {
            _homePage.ClickElements();
            _elementsPage.ClickTextBox();
        }

        [Test]
        public void LoginTest1()
        {
            _homePage.ClickBookStoreApplications();
            _loginPage?.ClickLogin();
            var txtValue = _loginPage?.GetLoginHeaderTxt();
             Assert.AreEqual("Welcome,\r\nLogin in Book Store", txtValue, "Values are not equal");
            _loginPage?.EnterCredentials();
            var usernamelbl = _loginPage?.IstextDisplayed();
            Assert.AreEqual(TestContext.Parameters["Username"], usernamelbl, "values not equal");
           Thread.Sleep(5000);
        }
    }
}
