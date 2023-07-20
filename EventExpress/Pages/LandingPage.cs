using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;

namespace EventExpress.Pages
{
    public class LandingPage : CommonPage
    {
        #region CSS Selectors
        private readonly string btnSignInUpCSS = "#headbtn";
        private readonly string btnFindEventCSS = "div.buttons > a";
        private readonly string btnCreateEventCSS = "div.buttons > button";
        private readonly string btnJoinEventexpressCSS = "div.text-center > div.d-inline-block > button";
        private readonly string btnLogOutCSS = "#bgcolornav button:nth-child(2)";
        private readonly string btnMyProfileCSS = "#bgcolornav button:nth-child(1)";
        private readonly string btnUserCSS = "#userNameAlign";
        private readonly string btnFirstNameXPath = "//p[normalize-space(text())='First Name']/ancestor::div[2]";
        private readonly string fldFirstNameCSS = "input[name='firstName']";






        #endregion

        #region Elements
        private ButtonElement btnSignInUp => FindElementByCSS<ButtonElement>(btnSignInUpCSS);
        private ButtonElement btnFindEvent => FindElementByCSS<ButtonElement>(btnFindEventCSS);
        private ButtonElement btnCreateEvent => FindElementByCSS<ButtonElement>(btnCreateEventCSS);
        private ButtonElement btnJoinEventexpress => FindElementByCSS<ButtonElement>(btnJoinEventexpressCSS);
        private ButtonElement btnLogOut => FindElementByCSS<ButtonElement>(btnLogOutCSS);

        private ButtonElement btnMyProfile => FindElementByCSS<ButtonElement>(btnMyProfileCSS);
        private ButtonElement btnUser => FindElementByCSS<ButtonElement>(btnUserCSS);

        private ButtonElement btnFirstName => FindElementByXPath<ButtonElement>(btnFirstNameXPath);
        private ButtonElement fldFirstName => FindElementByCSS<ButtonElement>(fldFirstNameCSS);

        #endregion

        public void ClickSignIn() => btnSignInUp.Click();

        public void ClickMyProfile() => btnMyProfile.Click();

        public void ClickFirstName() => btnFirstName.Click();
        public void EnterFirstName(string firstName) {  /*fldFirstName.SendKeys(firstName);*/
        fldFirstName.Clear(); 
    fldFirstName.SendKeys(firstName);
        }


        public void ClickFindEvent() => btnFindEvent.Click();

        public void ClickCreateEvent() => btnCreateEvent.Click();

        public void ClickJoinEventexpress() => btnJoinEventexpress.Click();
        public void ClickOnUser() => btnUser.Click();

        public void ClickLogOut() => btnLogOut.Click();
        public string GetSignOutText() => btnLogOut.Text;


        public string GetFirstNameFieldValue() => fldFirstName.GetAttribute("value");
    }
}



