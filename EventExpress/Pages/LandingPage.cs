using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;
using OpenQA.Selenium;

namespace EventExpress.Pages
{
    public class LandingPage: CommonPage
    {
        #region CSS Selectors
        private readonly string btnSignInUpCSS= ".MuiButton-label";
        private readonly string btnFindEventCSS = "div.buttons > a";
        private readonly string btnCreateEventCSS = "div.buttons > button";
        private readonly string btnJoinEventexpressCSS = "div.text-center > div.d-inline-block > button";
        private readonly string btnLogOutCSS = "div.text-right > div";
        #endregion

        #region Elements
        private ButtonElement btnSignInUp => FindElementByCSS<ButtonElement>(btnSignInUpCSS);
        private ButtonElement btnFindEvent => FindElementByCSS<ButtonElement>(btnFindEventCSS);
        private ButtonElement btnCreateEvent => FindElementByCSS<ButtonElement>(btnCreateEventCSS);
        private ButtonElement btnJoinEventexpress => FindElementByCSS<ButtonElement>(btnJoinEventexpressCSS);
        private ButtonElement btnLogOut => FindElementByCSS<ButtonElement>(btnLogOutCSS);
        #endregion
        public void ClickSignIn() => btnSignInUp.Click();

        public void ClickFindEvent() => btnFindEvent.Click();

        public void ClickCreateEvent() => btnCreateEvent.Click();

        public void ClickJoinEventexpress() => btnJoinEventexpress.Click();

        public void ClickLogOut() => btnLogOut.Click();
        public string GetSignOutText() => btnLogOut.Text;
    }
}
