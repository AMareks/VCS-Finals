using NUnit.Framework;


namespace Baigiamasis_Darbas.Tests
{
  
     class tests: BaseTest
    {
        [TestCase("Batai" , TestName = "Search 1")]
        [TestCase("Kuprinė" , TestName = "Search 2")]
        [TestCase("Kava", TestName = "Search 3")]

        public static void TestSearchFunction(string searchFor)
        {
            _mainPage.NavigateToDefaultPage();
            _mainPage.SearchBoxFill(searchFor);
            _mainPage.SubmitSearch();
            _mainPage.VerifySearchResults(searchFor);
        }

        [Test]
        public static void TestLoginFunction()
        {
           _loginPage.NavigateToDefaultPage();
            _loginPage.OpenLoginForm();
            _loginPage.EnterUserEmail("testuotojast5@gmail.com");
            _loginPage.EnterPwd("12345678");
            _loginPage.Login();
            _loginPage.VerifyLogin("https://www.aic.lt/uzsakymu-istorija/");
        }

        [Test]
        public static void TestingRegitrationPage()
        {
            _registrationPage.NavigateToDefaultPage();
            _registrationPage.OpenRegistrationForm();
            _registrationPage.EnterEmailToForm("gogelis@mogelis.lt");
            _registrationPage.EnterPasswordToForm("kriause");
            _registrationPage.ConfirmEnteredPassword("kriause");
            _registrationPage.EnterFirstName("pulas");
            _registrationPage.EnterLastName("longas");
            _registrationPage.EnterStreetName("pasaku");
            _registrationPage.EnterHouseNumber("55");
            _registrationPage.EnterZipCode("LT-34343");
            _registrationPage.EnterCityName("long Beachas");
            _registrationPage.SelectCountry();
            _registrationPage.EnterPhoneNumber("+37067843673");
            //_registrationPage.ClickSaveButton();
            // _registrationPage verification??
        }

        [Test]
        public static void TestingEndToEnd()
        {
            _EndToEnd.NavigateToDefaultPage();
          //  _EndToEnd.AcceptCookies();
            _EndToEnd.SearchBoxFill("prožektorius");
            _EndToEnd.SubmitSearch();
            _EndToEnd.SelectProduct();
            _EndToEnd.GoToCheckout();
            // _EndToEnd.ProceedToAdressLine();
            // _EndToEnd.ProceedToPayment();
            //_EndToEnd.FinishOrder();
            //_EndToEnd.VerifyOrderSent();
        }
    }
}
