using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EventExpress.Pages.HomePage;

namespace EventExpress.Tests
{
    class HomePageTests : UIFixture
    {
        public static class HomePageTestData
        {
        }

        [SetUp]
        public void SetupHomePage()
        {
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            Pages.LandingPage.ClickFindEvent();
        }
        [Test]
        public void TestHomePageBlockedCheck()
        {
            Pages.HomePage.ClickMoreFilters();
            Pages.HomePage.ClickCheck(1);
            Pages.HomePage.ClickResetFavoutiteSearch(HomePageElementsText.SearchBtnText);
            Assert.IsTrue(Pages.HomePage.IsResultPresent());
        }
        [Test]
        public void TestHomePageEvent()
        {  
            Pages.HomePage.ClickCardToEventLink(2);
            Assert.IsTrue(Pages.HomePage.IsTitleDisplayed());
        }
        [Test]
        public void Testуауауа()
        {
            int PageIndex = 2;
            string ExpectedResult = $"https://eventsexpress-test.azurewebsites.net/home/events?page={PageIndex}";
            Pages.HomePage.ClickNumberOfPage(PageIndex);
            Assert.AreEqual(ExpectedResult, Pages.HomePage.GetUrl());
        }
    }
}
