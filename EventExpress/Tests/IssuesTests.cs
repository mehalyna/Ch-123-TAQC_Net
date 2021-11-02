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
            LoginAsAdmin();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.IssuesAdminNavPageText);
            Pages.IssuesPage.SendDataToDatapickerFrom("21", "06", "2021");
            Pages.IssuesPage.SendDataToDatapickerTo("15", "09", "2022");
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Assert.AreEqual(2, Pages.IssuesPage.GetFieldIssueResults());
        }

        [Test]
        public void TestCheckboxOnIssuePage()
        {
            LoginAsAdmin();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.IssuesAdminNavPageText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Assert.AreEqual(3, Pages.IssuesPage.GetFieldIssueResults());
        }

        [Test]
        public void TestIssueResetBtn()
        {
            LoginAsAdmin();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.IssuesAdminNavPageText);
            Pages.IssuesPage.SendDataToDatapickerFrom("21", "06", "2021");
            Pages.IssuesPage.SendDataToDatapickerTo("15", "09", "2022");
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckResolveText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckInProgressText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);

            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.ResetBtnText);
            Assert.IsEmpty(Pages.IssuesPage.GetTextDatepickerTo());
        }
    }
}
