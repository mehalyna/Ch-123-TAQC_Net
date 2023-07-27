using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;

namespace EventExpress.Pages
{
    public class LandingPage : CommonPage
    {
        #region CSS Selectors

        private readonly string btnSignInUpCSS= "#headbtn";
        private readonly string btnFindEventCSS = "div.buttons > a";
        private readonly string btnCreateEventCSS = "div.buttons > button";
        private readonly string btnJoinEventexpressCSS = "div.text-center > div.d-inline-block > button";
        private readonly string btnMyProfileCSS = "#userNameAlign";
        private readonly string btnLogOutCSS = "#bgcolornav button:nth-child(2)";
        private readonly string _invalidLoginCSS = ".MuiFormHelperText-root.Mui-error.MuiFormHelperText-filled";
        private readonly string _invalidPasswordCSS = ".text-danger";
        #endregion

        #region Elements
        private ButtonElement btnSignInUp => FindElementByCSS<ButtonElement>(btnSignInUpCSS);
        private ButtonElement btnFindEvent => FindElementByCSS<ButtonElement>(btnFindEventCSS);
        private ButtonElement btnCreateEvent => FindElementByCSS<ButtonElement>(btnCreateEventCSS);
        private ButtonElement btnJoinEventexpress => FindElementByCSS<ButtonElement>(btnJoinEventexpressCSS);
        private ButtonElement btnMyProfile => FindElementByCSS<ButtonElement>(btnMyProfileCSS);
        private ButtonElement btnLogOut => FindElementByCSS<ButtonElement>(btnLogOutCSS);
        #endregion

        public void ClickSignIn() => btnSignInUp.Click();

        public void ClickFindEvent() => btnFindEvent.Click();

        public void ClickCreateEvent() => btnCreateEvent.Click();

        public void ClickJoinEventexpress() => btnJoinEventexpress.Click();

        public void ClickLogOut() => btnLogOut.Click();

        public void ClickMyProfile() => btnMyProfile.Click();

        public string GetSignOutText() => btnLogOut.Text;
        public string FindLoginErrorMessage() => FindElementByCSS<WebComponent>(_invalidLoginCSS).Text;
        public string FindPassErrorMessage() => FindElementByCSS<WebComponent>(_invalidPasswordCSS).Text;
    }
}
