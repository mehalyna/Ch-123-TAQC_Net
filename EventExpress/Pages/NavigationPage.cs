using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;

namespace EventExpress.Pages
{
    public class NavigationPage : CommonPage
    {
        public static class NavigationElementsText
        {
            public static readonly string HomeNavPageText = "Home";
            public static readonly string ComunaNavPageText = "Comuna";
            public static readonly string AdminAdminNavPageText = "Admin";
            public static readonly string IssuesAdminNavPageText = "Issues";
            public static readonly string ProfileUserNavPageText = "Profile";
            public static readonly string DraftUserNavPageText = "Draft";
            public static readonly string SearchUserNavPageText = "Search Users";
            public static readonly string EventsUserNavPageText = "Recurrent Events";
            public static readonly string ContactUserNavPageText = "Contact us";
        }

        #region CSS Selectors
        private string navPageTitleXPath(string text) => $"//span[@class='nav-item-text' and text()='{text}']";
        private const string navEditProfileCSS = "a:nth-child(1) > button";
        private const string navLogoutCSS = "a:nth-child(2) > button";
        private const string navUsernameCSS = "h4.user-name";
        #endregion
        
        #region Elements
        private ButtonElement navPageTitle(string pageTitle) => FindElementByXPath<ButtonElement>(navPageTitleXPath(pageTitle));
        private ButtonElement navEditProfile => FindElementByCSS<ButtonElement>(navEditProfileCSS);
        private ButtonElement navLogout => FindElementByCSS<ButtonElement>(navLogoutCSS);
        private WebComponent navUsername => FindElementByCSS<WebComponent>(navUsernameCSS);
        #endregion
        public void ClickNavPageTitle(string text) => navPageTitle(text).Click();
        public void ClickNavEditProfile() => navEditProfile.Click();
        public void ClickNavLogout() => navLogout.Click();
        public string GetUserName() => navUsername.Text;
    }
}
