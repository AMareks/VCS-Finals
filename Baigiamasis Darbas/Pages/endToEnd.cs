using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Baigiamasis_Darbas.Pages
{
     class endToEnd : BasePage
    {
        private const string PageAddress = "https://www.aic.lt/";
        public endToEnd(IWebDriver webDriver) : base(webDriver) { }
        private static IWebElement _searchBoxInput => Driver.FindElement(By.Id("searchParam"));
        private static IWebElement _submitButton => Driver.FindElement(By.CssSelector("#header > ul.second-header-block.inline-list.nobackground > li:nth-child(2) > div > form > div > a"));
        private static IWebElement _clickSelectedProduct => Driver.FindElement(By.CssSelector("#searchList > li:nth-child(5) > div > form > div.order-container.clearfix > div.buttonBox > button"));
        private static IWebElement _clickCheckOut => Driver.FindElement(By.CssSelector("#miniBasket > div > div > div > a"));
        private static IWebElement _clickCookies => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-block.cc-bottom.cc-color-override--1712192861 > div > a.cc-btn.cc-allow"));
        private static IWebElement _itemInCart => Driver.FindElement(By.CssSelector("#cartItem_1 > td:nth-child(1) > div"));

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void AcceptCookies()
        {
            _clickCookies.Click();
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
        
        public void VerifyOrderInCart()
        {
            Assert.That(_itemInCart.Text, Does.Contain("Prožektorius"));
        }


    }
}
