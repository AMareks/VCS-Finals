using NUnit.Framework;
using OpenQA.Selenium;


namespace Baigiamasis_Darbas.Pages
{
     class LoginPage : BasePage
    {
        private const string PageAddress = "https://www.aic.lt/";
        private static IWebElement _clickLoginForm => Driver.FindElement(By.CssSelector("#header > ul:nth-child(2) > li.pull-right > ul.breadcrumbs > li.login-btn > a"));
        private static IWebElement _enterEmail => Driver.FindElement(By.Id("loginUser"));
        private static IWebElement _enterPass => Driver.FindElement(By.Id("loginPwd"));
        private static IWebElement _loginSubmit => Driver.FindElement(By.Id("loginButton"));
        private static IWebElement _myProfile => Driver.FindElement(By.CssSelector("#header > ul:nth-child(2) > li.pull-right > ul.breadcrumbs > li:nth-child(2) > a"));
        public LoginPage(IWebDriver webdriver) : base(webdriver) { }
        
        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
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
