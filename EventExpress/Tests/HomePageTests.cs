using EventExpress.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Threading;
using static EventExpress.Pages.NavigationPage;

namespace EventExpress.Tests
{
    class HomePage : UIFixture
    {
        [SetUp]
        public void SetupHomePage()
        {
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            Pages.LandingPage.ClickFindEvent();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.HomeNavPageText);
        }



        [Test]
        public void CheckTagInTheLatestEvent()
        {
            Pages.HomePage.Filter();
            Pages.HomePage.ClickOnSortButton();
            Pages.HomePage.ClickOnRecentlyPublished();
            Assert.That(Pages.HomePage.GetFirstTagName, Is.EqualTo("#Climbing"), "Tag name is incorrect.");


        }

    }
}
