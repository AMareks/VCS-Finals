using OpenQA.Selenium;
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
        // clickai pagal searcha ir t.t.
        private static IWebElement _clickSelectedProduct => _driver.FindElement(By.CssSelector("#searchList > li:nth-child(3) > div > form > div.order-container.clearfix > div.buttonBox > button"))
        public endToEnd(IWebDriver webdriver)
        {
            _driver = webdriver;
        }
        public void NavigateToDefaultPage()
        {
            _driver.Url = "https://www.aic.lt/";
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



    }
}
