using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace EventExpress.Tests
{
    [TestFixture]
    public class LandingTests : UIFixture
    {

        [Test]
        public void TestLogin()
        {
            string expetedResult = "log out";
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            Pages.LandingPage.ClickOnUser();
            Assert.AreEqual(expetedResult, Pages.LandingPage.GetSignOutText(), "Username results doesn`t same as expected");
        }

        [Test]
        [Ignore("Ignore a test")]
        public void TestRegistration()
        {
            string expetedResult = "Your register was successfull. Please confirm your email.";
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Registration(UserData.EmailAdmin, UserData.PasswordAdmin);
            Assert.AreEqual(expetedResult, Pages.ModalPage.GetSuccessRegisterText(), "Alert message doesn`t same as expected");
        }

        [Test]
        public void TestRenameFirstName()
        {
            string expetedResult = "Alexa";
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            Pages.LandingPage.ClickOnUser();
            Pages.LandingPage.ClickMyProfile();
            Pages.LandingPage.ClickFirstName();
            Pages.LandingPage.EnterFirstName("Alexa");
           
            Assert.AreEqual(expetedResult, Pages.LandingPage.GetFirstNameFieldValue(), "First name is not as expected");
        }
    }
}
