using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;


namespace EventExpress.Pages
{
    public class ModalPage : CommonPage
    {
        public static class ModalElementsText
        {
            public static readonly string SignInBtnText = "Sign In";
            public static readonly string ClearBtnText = "CLEAR";
            public static readonly string CancelBtnText = "Cancel";
            public static readonly string FormPageBtnSignUpText = "Sign Up";
            public static readonly string FormPageLoginText = "Login";
            public static readonly string FormPageRegisterText = "Register";
        }

        #region Selectors
        private const string modalDialogXPath = "//div[@class='MuiDialog-root'][2]";
        private string formPageXPath(string text) => $"{modalDialogXPath}//span[@class='MuiTab-wrapper'][text()='{text}']";
        private readonly string inpFormEmailXPath = $"{modalDialogXPath}//input[@name='email']";
        private readonly string inpFormPasswordXPath = $"{modalDialogXPath}//input[@name='password']";
        private readonly string inpFormRegisterPasswordRepeatXPath = $"{modalDialogXPath}//input[@name='RepeatPassword']";

        private string btnFormXpath(string text) => $"{modalDialogXPath}//span[@class='MuiButton-label' and text()='{text}']";
        private readonly string textSuccessPageAllertCSS = "div.alert-success";
        #endregion
        #region Elements
        private InputElements inpFormEmail => FindElementByXPath<InputElements>(inpFormEmailXPath);
        private InputElements inpFormPassword => FindElementByXPath<InputElements>(inpFormPasswordXPath);
        private InputElements inpFormRegisterPasswordRepeat => FindElementByXPath<InputElements>(inpFormRegisterPasswordRepeatXPath);
        private ButtonElement btnSignInUpClear(string text) => FindElementByXPath<ButtonElement>(btnFormXpath(text));
        private ButtonElement btnForm(string text) => FindElementByXPath<ButtonElement>(formPageXPath(text));
        private WebComponent successRegisterText => FindElementByCSS<WebComponent>(textSuccessPageAllertCSS);
        #endregion
        public void InputEmail(string text) => inpFormEmail.SendKeys(text);
        public void InputPassword(string text) => inpFormPassword.SendKeys(text);
        public void InputRePassword(string text) => inpFormRegisterPasswordRepeat.SendKeys(text);
        public void ClickSignInUpClearBtn(string text) => btnSignInUpClear(text).Click();
        public void ClickFormBtn(string text) => btnForm(text).Click();
        public string GetSuccessRegisterText() => successRegisterText.Text;
        public void Login(string email, string password)
        {
            inpFormEmail.SendData(email);
            inpFormPassword.SendData(password);
            btnSignInUpClear(ModalElementsText.SignInBtnText).Click();
        }

        public void Registration(string email, string password)
        {
            btnForm(ModalElementsText.FormPageRegisterText).Click();
            inpFormEmail.SendData(email);
            inpFormPassword.SendData(password);
            inpFormRegisterPasswordRepeat.SendData(password);
            btnSignInUpClear(ModalElementsText.FormPageBtnSignUpText).Click();
        }
    }
}
