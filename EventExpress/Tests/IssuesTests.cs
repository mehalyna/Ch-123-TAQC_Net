using NUnit.Framework;
using static EventExpress.Pages.IssuesPage;
using static EventExpress.Pages.NavigationPage;

namespace EventExpress.Tests
{
    class IssuesTests: UIFixture
    {
        public static class IssueTestData
        {
            public static readonly string dayFrom = "21";
            public static readonly string monthFrom = "06";
            public static readonly string yearFrom = "2021";
            public static readonly string dayTo = "15";
            public static readonly string monthTo = "09";
            public static readonly string yearTo= "2022";
        }

        [Test]
        public void TestDatePickerOnIssuePage()
        {
            LoginAsAdmin(NavigationElementsText.IssuesAdminNavPageText);
            Pages.IssuesPage.SendDataToDatapickerFrom(IssueTestData.dayFrom, IssueTestData.monthFrom, IssueTestData.yearFrom);
            Pages.IssuesPage.SendDataToDatapickerTo(IssueTestData.dayTo, IssueTestData.monthTo, IssueTestData.yearTo);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Assert.AreEqual(2, Pages.IssuesPage.GetFieldIssueResults(), "Amount of issue results doesn`t same as expected");
        }

        [Test]
        public void TestCheckboxOnIssuePage()
        {
            LoginAsAdmin(NavigationElementsText.IssuesAdminNavPageText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Assert.AreEqual(3, Pages.IssuesPage.GetFieldIssueResults(), "Amount of issue results doesn`t same as expected");
        }

        [Test]
        public void TestIssueResetBtn()
        {
            LoginAsAdmin(NavigationElementsText.IssuesAdminNavPageText);
            Pages.IssuesPage.SendDataToDatapickerFrom(IssueTestData.dayFrom, IssueTestData.monthFrom, IssueTestData.yearFrom);
            Pages.IssuesPage.SendDataToDatapickerTo(IssueTestData.dayTo, IssueTestData.monthTo, IssueTestData.yearTo);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckResolveText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckInProgressText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.ResetBtnText);
            Assert.IsEmpty(Pages.IssuesPage.GetTextDatepickerTo(), "Input is not empty");
        }
    }
}
