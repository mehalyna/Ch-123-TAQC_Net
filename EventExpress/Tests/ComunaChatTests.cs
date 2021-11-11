using NUnit.Framework;
using static EventExpress.Pages.NavigationPage;

namespace EventExpress.Tests
{
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
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            Pages.LandingPage.ClickFindEvent();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.ComunaNavPageText);
        }

        [Test]
        public void TestChatSendMessage()
        {
            SendMessageTestUser();
            StringAssert.Contains(ComunaChatTestData.message, Pages.ComunaChatPage.GetLastMessageText());
        }

        [Test]
        public void TestTextInfoComunaPage()
        {
            SendMessageTestUser();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.ComunaNavPageText);
            StringAssert.Contains(ComunaChatTestData.notification, Pages.ComunaChatPage.GetInfoTextByName(ComunaChatTestData.nameUser));
        }

        #region TestSteps
        private void SendMessageTestUser()
        {
            Pages.ComunaChatPage.ClickComunaUserItemByName(ComunaChatTestData.nameUser);
            Pages.ComunaChatPage.InputTextArea(ComunaChatTestData.message);
            Pages.ComunaChatPage.ClickBtnSend();
        }
        #endregion
    }
}
