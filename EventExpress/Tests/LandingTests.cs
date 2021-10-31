using NUnit.Framework;


namespace EventExpress.Tests
{
    [TestFixture]
    public class LandingTests : UIFixture
    {
        [Test]
        public void TestLogin()
        {
            Pages.LandingPage.GoToPage("https://eventsexpress-test.azurewebsites.net/");
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login("admin@gmail.com", "1qaz1qaz");
            Assert.AreEqual("Log out", Pages.LandingPage.GetSignOutText(), "Text element doesn`t same as expected");
        }

        [Test]
        public void TestRegistration()
        {
            Pages.LandingPage.GoToPage("https://eventsexpress-test.azurewebsites.net/");
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Registration("user@gmail.com", "1q2w3e4r5t");
        }


    }
}
