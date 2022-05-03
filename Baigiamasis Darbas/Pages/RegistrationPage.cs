using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_Darbas.Pages
{
     class RegistrationPage
    {
        private static IWebDriver _driver;
        private static IWebElement _clickRegistrationForm => _driver.FindElement(By.Id("registerLink"));
        private static IWebElement _enterEmail => _driver.FindElement(By.Id("userLoginName"));
        private static IWebElement _enterPassword => _driver.FindElement(By.Id("userPassword"));
        private static IWebElement _confirmPassword => _driver.FindElement(By.Id("userPasswordConfirm"));
        private static IWebElement _enterName => _driver.FindElement(By.Id("oxuser__oxfname"));
        private static IWebElement _enterLastName => _driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(2) > input[type=text]"));
        private static IWebElement _enterStreetName => _driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(3) > input[type=text]"));
        private static IWebElement _enterHouseNum => _driver.FindElement(By.CssSelector("private static IWebElement _enterStreetName => _driver.FindElement(By.CssSelector"));
        private static IWebElement _enterZipCode => _driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(6) > input[type=text]"));
        private static IWebElement _enterCityName => _driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(7) > input[type=text]"));
       /* private static IWebElement _selectCountry => _driver.FindElement(By.CssSelector("#invCountrySelect"));
        * susiziuret kaip is meniu pasidaryt kad methode rinktu pagal indeksa LT
        * */
        private static IWebElement _enterPhoneNum => _driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper.register-page > div > div.page-content > form > ul:nth-child(12) > li:nth-child(9) > input[type=text]"));
        private static IWebElement _clickSave => _driver.FindElement(By.Id("accUserSaveTop"));

        public RegistrationPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void NavigateToDefaultPage()
        {
            _driver.Url = "https://www.aic.lt/";
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
            IWebElement _selectCountry = _driver.FindElement(By.CssSelector("#invCountrySelect"));
            var selectObject = new SelectElement(_selectCountry);
            selectObject.SelectByIndex(3);
            //pabandyti pagal indeksa susirast
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
    }
}
