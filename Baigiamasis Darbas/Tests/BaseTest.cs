using Baigiamasis_Darbas.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using VCSPavasaris.Tools;

namespace Baigiamasis_Darbas.Tests
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static MainPage _mainPage;
        public static endToEnd _EndToEnd;
        public static LoginPage _loginPage;
        public static RegistrationPage _registrationPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = new ChromeDriver();

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));        
             Driver.Manage().Window.Maximize();

            _mainPage = new MainPage(Driver);
            _EndToEnd = new endToEnd(Driver);
            _loginPage = new LoginPage(Driver);
            _registrationPage = new RegistrationPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
             Driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MakeScreenshot.TakeScreenshot(Driver);
            }
        }

    }
}