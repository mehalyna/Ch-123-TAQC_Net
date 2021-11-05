using EventExpress.Pages.Common;
using EventExpress.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EventExpress
{
    public class UIFixture
    {
        private IWebDriver driver;
        public GUIMap Pages;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            Pages = new GUIMap(driver);
        }

        public void LoginAsAdmin(string text)
        {
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            Pages.LandingPage.ClickFindEvent();
            Pages.NavigationPage.ClickNavPageTitle(text);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
