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
     class MainPage
    {
        private static IWebDriver _driver;

        private static IWebElement _searchBoxInput => _driver.FindElement(By.Id("searchParam"));
        private static IWebElement _submitButton => _driver.FindElement(By.CssSelector("#header > ul.second-header-block.inline-list.nobackground > li:nth-child(2) > div > form > div > a"));
        private static IWebElement _searchResult => _driver.FindElement(By.CssSelector("body > div.page-wrapper > div.content-wrapper > div > div.page-content > div.page-header > h1"));
       
        public MainPage(IWebDriver webdriver )
        {
            _driver = webdriver;
        }

        public void NavigateToDefaultPage()
        {
            _driver.Url = "https://www.aic.lt/";
        }

       /* public void ClosePopUp()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(d => _popup.Displayed);
            _popup.Click();
        }
       */
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

   


        

        

      //  public void VerifyCheckedBoxes(string checkedBoxes)
       // {
     //       Assert.AreEqual($"{checkedBoxes}", _checkBoxResult.Text, "Box is not checked");
      //  }



    }
