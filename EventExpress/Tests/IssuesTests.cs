using NUnit.Framework;
using static EventExpress.Pages.IssuesPage;
using static EventExpress.Pages.NavigationPage;

namespace EventExpress.Tests
{
    class IssuesTests: UIFixture
    {
        [Test]
        public void TestDatePickerOnIssuePage()
        {
            Pages.LandingPage.GoToPage("https://eventsexpress-test.azurewebsites.net/");
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login("admin@gmail.com", "1qaz1qaz");
            Pages.LandingPage.ClickFindEvent();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.IssuesAdminNavPageText);
            Pages.IssuesPage.SendDataToDatapickerFrom("21", "6", "2021");
            Pages.IssuesPage.SendDataToDatapickerTo("15", "9", "2022");
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Assert.AreEqual(2, Pages.IssuesPage.GetFieldIssueResults());
        }

        [Test]
        public void TestCheckboxOnIssuePage()
        {
            Pages.LandingPage.GoToPage("https://eventsexpress-test.azurewebsites.net/");
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login("admin@gmail.com", "1qaz1qaz");
            Pages.LandingPage.ClickFindEvent();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.IssuesAdminNavPageText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Assert.AreEqual(3, Pages.IssuesPage.GetFieldIssueResults());
        }

        [Test]
        public void TestIssueResetBtn()
        {
            Pages.LandingPage.GoToPage("https://eventsexpress-test.azurewebsites.net/");
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login("admin@gmail.com", "1qaz1qaz");
            Pages.LandingPage.ClickFindEvent();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.IssuesAdminNavPageText);

            Pages.IssuesPage.SendDataToDatapickerFrom("21", "6", "2021");
            Pages.IssuesPage.SendDataToDatapickerTo("15", "9", "2022");
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckResolveText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckInProgressText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);

            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.ResetBtnText);
            Assert.IsEmpty(Pages.IssuesPage.GetTextDatepickerTo());
        }
    }
}
