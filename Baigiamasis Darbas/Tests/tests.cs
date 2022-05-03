using Baigiamasis_Darbas.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Baigiamasis_Darbas.Tests
{
  
     class tests
    {
        
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
          // pakeisti normalu accept cookies method'a
          //Optimizuot cookies kad cia butu
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _driver.Quit();
        }


        [TestCase("Batai" , TestName = "Search 1")]
        [TestCase("Kuprinė" , TestName = "Search 2")]
        public static void TestSearchFunction(string searchFor)
        {
            

            MainPage maiPage = new MainPage(_driver);

            maiPage.NavigateToDefaultPage();
            maiPage.SearchBoxFill(searchFor);
            maiPage.SubmitSearch();

            maiPage.VerifySearchResults(searchFor);
        }
        [Test]
        public static void TestLoginFunction()
        {
            string userName = "testuotojast5@gmail.com";
            string password = "12345678";

            LoginPage loginPage = new LoginPage(_driver);

            loginPage.NavigateToDefaultPage();
            loginPage.OpenLoginForm();
            loginPage.EnterUserEmail(userName);
            loginPage.EnterPwd(password);
            loginPage.Login();
            loginPage.VerifyLogin("https://www.aic.lt/uzsakymu-istorija/");

        }
        [Test]
        public static void TestingRegitrationPage()
        {
            RegistrationPage registrationPage = new RegistrationPage(_driver);
            registrationPage.NavigateToDefaultPage();
            registrationPage.OpenRegistrationForm();
            registrationPage.EnterEmailToForm("");
            registrationPage.EnterPasswordToForm("");
            registrationPage.ConfirmEnteredPassword("");
            registrationPage.EnterFirstName("");
            registrationPage.EnterLastName("");
            registrationPage.EnterStreetName("");
            registrationPage.EnterHouseNumber("");
            registrationPage.EnterZipCode("");
            registrationPage.EnterCityName("");
            //registrationPage.SelectCountry(3);
            registrationPage.EnterPhoneNumber("");
            // registrationPage.ClickSaveButton("");
        }
        [Test]
        public static void TestingEndToEnd()
        {
            endToEnd EndToEnd = new endToEnd(_driver);
            EndToEnd.NavigateToDefaultPage();
            EndToEnd.AcceptCookies();
            EndToEnd.SearchBoxFill("prožektorius");
            EndToEnd.SubmitSearch();
            EndToEnd.SelectProduct();
            EndToEnd.GoToCheckout();
           // EndToEnd.ProceedToAdressLine();
           // EndToEnd.ProceedToPayment();
            //EndToEnd.FinishOrder();
             //EndToEnd.VerifyOrderSent();

        }
    }
}
