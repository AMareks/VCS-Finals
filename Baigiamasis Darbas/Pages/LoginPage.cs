using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Baigiamasis_Darbas.Pages
{
     class LoginPage : BasePage
    {

        private const string PageAddress = "https://www.aic.lt/";
        public LoginPage(IWebDriver webdriver) : base(webdriver) { }
        private static IWebElement _clickLoginForm => Driver.FindElement(By.CssSelector("#header > ul:nth-child(2) > li.pull-right > ul.breadcrumbs > li.login-btn > a"));
        private static IWebElement _enterEmail => Driver.FindElement(By.Id("loginUser"));
        private static IWebElement _enterPass => Driver.FindElement(By.Id("loginPwd"));
        private static IWebElement _loginSubmit => Driver.FindElement(By.Id("loginButton"));
        private static IWebElement _myProfile => Driver.FindElement(By.CssSelector("#header > ul:nth-child(2) > li.pull-right > ul.breadcrumbs > li:nth-child(2) > a"));
        private static IWebElement _clickCookies => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-block.cc-bottom.cc-color-override--1712192861 > div > a.cc-btn.cc-allow"));
       
        
        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        
        public void AcceptCookies()
        {
            _clickCookies.Click();
        }       

        public void OpenLoginForm()
        {
            _clickLoginForm.Click();
        }

        public void EnterUserEmail(string userName)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(d => _enterEmail.Displayed);
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

        public void VerifyLogin()
        {          
            Assert.AreEqual("Fredis Testauskas", _myProfile.Text );
        }     
    }
}
