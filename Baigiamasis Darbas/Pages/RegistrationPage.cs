using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Baigiamasis_Darbas.Pages
{
     class RegistrationPage : BasePage
    {
        private const string PageAddress = "https://www.aic.lt/";
        public RegistrationPage(IWebDriver webdriver) : base(webdriver) { }

        private static IWebElement _clickRegistrationForm => Driver.FindElement(By.Id("registerLink"));
        private static IWebElement _enterEmail => Driver.FindElement(By.Id("userLoginName"));
        private static IWebElement _enterPassword => Driver.FindElement(By.Id("userPassword"));
        private static IWebElement _confirmPassword => Driver.FindElement(By.Id("userPasswordConfirm"));
        private static IWebElement _enterName => Driver.FindElement(By.Id("oxuser__oxfname"));
        private static IWebElement _enterLastName => Driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(2) > input[type=text]"));
        private static IWebElement _enterStreetName => Driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(3) > input[type=text]"));
        private static IWebElement _enterHouseNum => Driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li.streetno.req-form-row > input[type=text]"));
        private static IWebElement _enterZipCode => Driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(6) > input[type=text]"));
        private static IWebElement _enterCityName => Driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(7) > input[type=text]"));          
        private static IWebElement _enterPhoneNum => Driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(9) > input[type=text]"));
        private static IWebElement _clickSave => Driver.FindElement(By.Id("accUserSaveTop"));
        private static IWebElement _userAlreadyExists => Driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > div.alert-box.error-message"));
        private static IWebElement _clickCookies => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-block.cc-bottom.cc-color-override--1712192861 > div > a.cc-btn.cc-allow"));

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        public void AcceptCookies()
        {
            _clickCookies.Click();
        }

            public void OpenRegistrationForm()
        {
            _clickRegistrationForm.Click();
        }

        public void EnterEmailToForm(string userName)
        {
            _enterEmail.Clear();
            _enterEmail.SendKeys(userName);
        }

        public void EnterPasswordToForm(string password)
        {
            _enterPassword.Clear();
            _enterPassword.SendKeys(password);
        }

        public void ConfirmEnteredPassword(string password)
        {
            _confirmPassword.Clear();
            _confirmPassword.SendKeys(password);
        }

        public void EnterFirstName(string firstName)
        {
            _enterName.Clear();
            _enterName.SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            _enterLastName.Clear();
            _enterLastName.SendKeys(lastName);
        }

        public void EnterStreetName(string streetName)
        {
            _enterStreetName.Clear();
            _enterStreetName.SendKeys(streetName);
        }

        public void EnterHouseNumber(string houseNumber)
        {
            _enterHouseNum.Clear();
            _enterHouseNum.SendKeys(houseNumber);
        }

        public void EnterZipCode(string zipCode)
        {
            _enterZipCode.Clear();
            _enterZipCode.SendKeys(zipCode);
        }

        public void EnterCityName(string cityName)
        {
            _enterCityName.Clear();
            _enterCityName.SendKeys(cityName);
        }

        public void SelectCountry()
        {
            IWebElement _selectCountry = Driver.FindElement(By.CssSelector("#invCountrySelect"));
            var selectObject = new SelectElement(_selectCountry);
            selectObject.SelectByIndex(3);
        }

        public void EnterPhoneNumber(string phoneNumber)
        {
            _enterPhoneNum.Clear();
            _enterPhoneNum.SendKeys(phoneNumber);
        }
        public void ClickSaveButton()
        {
            _clickSave.Click();
        }
        public void VerifyAccountIsInUse()
        {
            Assert.AreEqual("Negalite užsiregistruoti testuotojast5@gmail.com. Gal jūs jau užsiregistravote?", _userAlreadyExists.Text);
        }
    }
}
