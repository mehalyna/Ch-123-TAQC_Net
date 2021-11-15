using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;

namespace EventExpress.Pages
{
    public class ComunaChatPage: CommonPage
    {
        #region Selectors
        private string comunaUserItemByIndexCSS(int index) => $"div:nth-child({index}) > a > div > div > h5";
        private string comunaUserItemByNameXPath(string name) => $"//h5[text()='{name}']";
        private string comunaUserItemInfoTextByNameXPath(string name) => $"//div[h5[text()='{name}' ]]/span";
        private string chatAvatarCSS = ".SmallAvatar";
        private string chatTextAreaCSS = "textarea";
        private string btnSendCSS = "button[type='submit']";
        private string lastMessageCSS = "div:last-child > div.msg_cotainer_send";
        #endregion

        #region Elements
        private ButtonElement comunaUserItem(int index) => FindElementByCSS<ButtonElement>(comunaUserItemByIndexCSS(index));
        private ButtonElement comunaUserItemByName(string name) => FindElementByXPath<ButtonElement>(comunaUserItemByNameXPath(name));
        private WebComponent comunaUserItemInfoTextByName(string name) => FindElementByXPath<ButtonElement>(comunaUserItemInfoTextByNameXPath(name));
        private ButtonElement chatAvatar => FindElementByCSS<ButtonElement>(chatAvatarCSS);
        private InputElements chatTextArea => FindElementByCSS<InputElements>(chatTextAreaCSS);
        private ButtonElement btnSend => FindElementByCSS<ButtonElement>(btnSendCSS);
        private WebComponent lastMessage => FindElementByCSS<WebComponent>(lastMessageCSS);

        #endregion

        public void ClickUserItemByIndex(int index) => comunaUserItem(index).Click();
        public void ClickComunaUserItemByName(string name) => comunaUserItemByName(name).Click();
        public void ClickAvatar() => chatAvatar.Click();
        public void InputTextArea(string text) => chatTextArea.SendKeys(text);
        public void ClickBtnSend() => btnSend.Click();
        public string GetLastMessageText() => lastMessage.Text;
        public string GetInfoTextByName(string name) => comunaUserItemInfoTextByName(name).Text;
    }
}
