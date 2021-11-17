using AventStack.ExtentReports;
using NUnit.Framework;
using static EventExpress.Pages.NavigationPage;

namespace EventExpress.Tests
{
    [TestFixture]
    class ComunaChatTests : UIFixture
    {
        public static class ComunaChatTestData
        {
            public static readonly int indexUser = 4;
            public static readonly string nameUser = "Yuriy Gora";
            public static readonly string message = "test message";
            public static readonly string notification = "You have";
        }

        [SetUp]
        public void SetupComunaChatPage()
        {
            test.Log(Status.Info, "Start Login");
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            test.Log(Status.Info, "Open Modal Page");
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            test.Log(Status.Info, "User data entered");
            Pages.LandingPage.ClickFindEvent();
            test.Log(Status.Info, "Home page open");
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.ComunaNavPageText);
            test.Log(Status.Info, "Comuna page open");
        }

        [Test]
        public void TestChatSendMessage()
        {
            SendMessageTestUser();
            StringAssert.Contains(ComunaChatTestData.message, Pages.ComunaChatPage.GetLastMessageText(), "Message doesn`t same as expected");
            test.Log(Status.Pass, "Message same as expected");
        }

        [Test]
        public void TestTextInfoComunaPage()
        {
            SendMessageTestUser();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.ComunaNavPageText);
            test.Log(Status.Info, "Comuna page opened");
            StringAssert.Contains(ComunaChatTestData.notification, Pages.ComunaChatPage.GetInfoTextByName(ComunaChatTestData.nameUser), "Info message doesn`t find");
            test.Log(Status.Pass, "Info message same as expected");
        }

        #region TestSteps
        private void SendMessageTestUser()
        {
            Pages.ComunaChatPage.ClickComunaUserItemByName(ComunaChatTestData.nameUser);
            test.Log(Status.Info, "Chat with user opened");
            Pages.ComunaChatPage.InputTextArea(ComunaChatTestData.message);
            Pages.ComunaChatPage.ClickBtnSend();
            test.Log(Status.Info, "Message sent");
        }
        #endregion

    }
}
