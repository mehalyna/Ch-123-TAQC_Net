using AventStack.ExtentReports;
using NUnit.Framework;

namespace EventExpress.Tests
{
    [TestFixture]
    public class LandingTests : UIFixture
    {

        [Test]
        public void TestLogin()
        {
            test.Log(Status.Info, "Start Login");
            string expetedResult = "Log out";
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            test.Log(Status.Info, "Open Modal Page");
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            test.Log(Status.Info, "User data entered");
            Assert.AreEqual(expetedResult, Pages.LandingPage.GetSignOutText(), "Username results doesn`t same as expected");
            test.Log(Status.Info, "Login Successful");
        }

        [Test]
        [Ignore("Ignore a test")]
        public void TestRegistration()
        {
            test.Log(Status.Info, "Start Registration");
            string expetedResult = "Your register was successfull. Please confirm your email.";
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            test.Log(Status.Info, "Open Modal Page");
            Pages.ModalPage.Registration(UserData.EmailAdmin, UserData.PasswordAdmin);
            test.Log(Status.Info, "User data entered");
            Assert.AreEqual(expetedResult, Pages.ModalPage.GetSuccessRegisterText(), "Alert message doesn`t same as expected");
            test.Log(Status.Info, "Registration Successful");
        }
    }
}
