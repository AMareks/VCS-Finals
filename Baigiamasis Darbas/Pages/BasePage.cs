using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Baigiamasis_Darbas.Pages
{
    class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public WebDriverWait GetWait(int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            return wait;
        }
    }
}