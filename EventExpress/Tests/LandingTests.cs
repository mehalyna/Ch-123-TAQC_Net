using NUnit.Framework;


namespace EventExpress.Tests
{
    [TestFixture]
    public class LandingTests : UIFixture
    {

        [Test]
        public void TestLogin()
        {
            string expetedResult = "Log out";
            Pages.LandingPage.GoToPage("https://eventsexpress-test.azurewebsites.net/");
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login("admin@gmail.com", "1qaz1qaz");
            Assert.AreEqual(expetedResult, Pages.LandingPage.GetSignOutText(), "Username results doesn`t same as expected");
        }

        [Test]
        [Ignore("Ignore a test")]
        public void TestRegistration()
        {
            string expetedResult = "Your register was successfull. Please confirm your email.";
            Pages.LandingPage.GoToPage("https://eventsexpress-test.azurewebsites.net/");
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Registration("user@gmail.com", "1q2w3e4r5t");
            Assert.AreEqual(expetedResult, Pages.ModalPage.GetSuccessRegisterText(), "Alert message doesn`t same as expected");
        }
    }
}
