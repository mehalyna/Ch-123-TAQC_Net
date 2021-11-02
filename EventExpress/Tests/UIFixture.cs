using EventExpress.Pages.Common;
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

        public void LoginAsAdmin()
        {
            Pages.LandingPage.GoToPage("https://eventsexpress-test.azurewebsites.net/");
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login("admin@gmail.com", "1qaz1qaz");
            Pages.LandingPage.ClickFindEvent();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
