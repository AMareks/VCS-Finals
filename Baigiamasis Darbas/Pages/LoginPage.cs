using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_Darbas.Pages
{
     class LoginPage
    {
        private static IWebDriver _driver;
        private static IWebElement _clickLoginForm => _driver.FindElement(By.CssSelector("#header > ul:nth-child(2) > li.pull-right > ul.breadcrumbs > li.login-btn > a"));
        private static IWebElement _enterEmail => _driver.FindElement(By.Id("loginUser"));
        private static IWebElement _enterPass => _driver.FindElement(By.Id("loginPwd"));
        private static IWebElement _loginSubmit => _driver.FindElement(By.Id("loginButton"));
        private static IWebElement _myProfile => _driver.FindElement(By.CssSelector("#header > ul:nth-child(2) > li.pull-right > ul.breadcrumbs > li:nth-child(2) > a"));
        public LoginPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void NavigateToDefaultPage()
        {
            _driver.Url = "https://www.aic.lt/";
        }
        public void OpenLoginForm()
        {
            _clickLoginForm.Click();
        }
        public void EnterUserEmail(string userName)
        {
            _enterEmail.Clear();
            _enterEmail.SendKeys(userName);
        }
        public void EnterPwd(string password)
        {
            _enterPass.Clear();
            _enterPass.SendKeys(password);
        }
        public void Login()
        {
            _loginSubmit.Click();
        }
        public void VerifyLogin(string myProfile)
        {
            myProfile = "https://www.aic.lt/uzsakymu-istorija/";
            Assert.AreEqual(myProfile, _myProfile );
        }
        //kaip padaryti passed?? 
    }
}
