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
            _mainPage.AcceptCookies();
            _mainPage.SearchBoxFill(searchFor);
            _mainPage.SubmitSearch();
            _mainPage.VerifySearchResults(searchFor);
        }

        [Test]
        public static void TestLoginFunction()
        {
            _loginPage.NavigateToDefaultPage();
            _loginPage.AcceptCookies();
            _loginPage.OpenLoginForm();
            _loginPage.EnterUserEmail("testuotojast5@gmail.com");
            _loginPage.EnterPwd("12345678");
            _loginPage.Login();
            _loginPage.VerifyLogin();
        }

        [Test]
        public static void TestRegistrationFormErrorMessageWhenUserExist()
        {
            _registrationPage.NavigateToDefaultPage();
            _registrationPage.AcceptCookies();
            _registrationPage.OpenRegistrationForm();
            _registrationPage.EnterEmailToForm("testuotojast5@gmail.com");
            _registrationPage.EnterPasswordToForm("12345678");
            _registrationPage.ConfirmEnteredPassword("12345678");
            _registrationPage.EnterFirstName("Fredis");
            _registrationPage.EnterLastName("Testauskas");
            _registrationPage.EnterStreetName("Verkiu ");
            _registrationPage.EnterHouseNumber("1");
            _registrationPage.EnterZipCode("LT-98345");
            _registrationPage.EnterCityName("Vilnius");
            _registrationPage.SelectCountry();
            _registrationPage.EnterPhoneNumber("+37069440960");
            _registrationPage.ClickSaveButton();
            _registrationPage.VerifyAccountIsInUse();
        }

        [Test]
        public static void TestingEndToEnd()
        {
            _EndToEnd.NavigateToDefaultPage();
            _EndToEnd.AcceptCookies();
            _EndToEnd.SearchBoxFill("prožektorius");
            _EndToEnd.SubmitSearch();
            _EndToEnd.SelectProduct();
            _EndToEnd.GoToCheckout();
            _EndToEnd.VerifyOrderInCart();           
        }
    }
}
