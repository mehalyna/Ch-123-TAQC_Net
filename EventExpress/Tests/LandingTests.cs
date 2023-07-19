using NUnit.Framework;


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
            Pages.LandingPage.ClickMyProfile();
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
    }
}
