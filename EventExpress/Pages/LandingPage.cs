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
        private readonly string btnLogOutCSS = ".dropdown-item:nth-child(2)";
        private readonly string btnUserCSS = "#userNameAlign";
        #endregion

        #region Elements
        private ButtonElement btnSignInUp => FindElementByCSS<ButtonElement>(btnSignInUpCSS);
        private ButtonElement btnFindEvent => FindElementByCSS<ButtonElement>(btnFindEventCSS);
        private ButtonElement btnCreateEvent => FindElementByCSS<ButtonElement>(btnCreateEventCSS);
        private ButtonElement btnJoinEventexpress => FindElementByCSS<ButtonElement>(btnJoinEventexpressCSS);
        private ButtonElement btnLogOut => FindElementByCSS<ButtonElement>(btnLogOutCSS);
        private ButtonElement btnUser => FindElementByCSS<ButtonElement>(btnUserCSS);
        #endregion
        public void ClickSignIn() => btnSignInUp.Click();

        public void ClickFindEvent() => btnFindEvent.Click();

        public void ClickCreateEvent() => btnCreateEvent.Click();

        public void ClickJoinEventexpress() => btnJoinEventexpress.Click();
        public void ClickOnUserProfile() => btnUser.Click();

        public void ClickLogOut() => btnLogOut.Click();
        
        public string GetSignOutText() => btnLogOut.Text;
        
    }
}
