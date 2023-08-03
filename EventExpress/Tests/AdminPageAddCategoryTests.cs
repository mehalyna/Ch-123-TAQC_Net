using EventExpress.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static EventExpress.Pages.NavigationPage;
namespace EventExpress.Tests

{

    public class AdminTests : UIFixture

    {

        private static Random random = new Random();


        public static string RandomString(int length)

        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)

                .Select(s => s[random.Next(s.Length)]).ToArray());

        }

        [SetUp]

        public void SetupAdminPage()

        {

            Pages.LandingPage.GoToPage(UserData.BaseUrl);

            Pages.LandingPage.ClickSignIn();

            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);

            Pages.LandingPage.ClickFindEvent();

            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.AdminAdminNavPageText);

        }

        [Test]

        public void AddNewCategory()

        {

            Pages.AdminPage.ClickAddCategory();

            Pages.AdminPage.EnterCategory(RandomString(5));

            Pages.AdminPage.SelectCategory();

            Pages.AdminPage.ClickConfirm();


        }

    }

}
