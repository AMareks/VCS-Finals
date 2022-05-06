using NUnit.Framework;
using OpenQA.Selenium;


namespace Baigiamasis_Darbas.Pages
{
     class MainPage : BasePage
    {
        private const string PageAddress = "https://www.aic.lt/";    
        private static IWebElement _searchBoxInput => Driver.FindElement(By.Id("searchParam"));
        private static IWebElement _submitButton => Driver.FindElement(By.CssSelector("#header > ul.second-header-block.inline-list.nobackground > li:nth-child(2) > div > form > div > a"));
        private static IWebElement _searchResult => Driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper > div > div.page-content > div.page-header > h1"));
        private static IWebElement _clickCookies => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-banner.cc-type-opt-in.cc-theme-block.cc-bottom.cc-color-override--1712192861 > div > a.cc-btn.cc-allow"));
        public MainPage(IWebDriver webdriver) : base(webdriver) { }
       
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

        public void VerifySearchResults(string expectedResult)
        {
            Assert.IsTrue(expectedResult.Contains(expectedResult), _searchResult.Text,"Searched items not found !");            
        }

    }

}
