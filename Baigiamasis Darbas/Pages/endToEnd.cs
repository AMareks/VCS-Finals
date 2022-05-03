using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_Darbas.Pages
{
     class endToEnd
    {
        private static IWebDriver _driver;
        private static IWebElement _searchBoxInput => _driver.FindElement(By.Id("searchParam"));
        private static IWebElement _submitButton => _driver.FindElement(By.CssSelector("#header > ul.second-header-block.inline-list.nobackground > li:nth-child(2) > div > form > div > a"));
        private static IWebElement _acceptCookies => _driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-block.cc-bottom.cc-color-override--1712192861 > div > a.cc-btn.cc-allow"));
        private static IWebElement _clickSelectedProduct => _driver.FindElement(By.CssSelector("#searchList > li:nth-child(5) > div > form > div.order-container.clearfix > div.buttonBox > button"));
        private static IWebElement _clickCheckOut => _driver.FindElement(By.CssSelector("#miniBasket > div > div > div > a"));
        private static IWebElement _clickAdress => _driver.FindElement(By.CssSelector("body > div.page - wrapper.checkout - foot > div.content - wrapper.checkout - page.step - basket > div > div > div.container.clearfix > div > div.checkout - bottom - wrapper.clearfix > div > form > button"));
        private static IWebElement _clickPayment => _driver.FindElement(By.CssSelector("##userNextStepBottom"));
        private static IWebElement _clickOrder => _driver.FindElement(By.CssSelector("#paymentNextStepBottom"));
        public endToEnd(IWebDriver webdriver)
        {
            _driver = webdriver;
        }
        public void NavigateToDefaultPage()
        {
            _driver.Url = "https://www.aic.lt/";
        }
        public void AcceptCookies()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(d => _acceptCookies.Displayed);
            _acceptCookies.Click();

        }
        public void SearchBoxFill(string searchFor)
        {
            _searchBoxInput.Clear();
            _searchBoxInput.SendKeys(searchFor);

        }
        public void SubmitSearch()
        {
            _submitButton.Click();
        }
        public void SelectProduct()
        {
            _clickSelectedProduct.Click();
        }
        public void GoToCheckout()
        {
            _clickCheckOut.Click();
        }
        public void ProceedToAdressLine()
        {
            _clickAdress.Click();
        }
        public void ProceedToPayment()
        {
            _clickPayment.Click();
        }
        public void FinishOrder()
        {
            _clickOrder.Click();
        }
        public void VerifyOrderSent()
        {
            // Sugalvot assert'a kazkaip
        }
        //pasitikrint ar viskas checkout damusta






    }
}
