using NUnit.Framework;
using static EventExpress.Pages.IssuesPage;
using static EventExpress.Pages.NavigationPage;

namespace EventExpress.Tests
{
    class IssuesTests : UIFixture
    {
        public static class IssueTestData
        {
            public static readonly string dayFrom = "21";
            public static readonly string monthFrom = "06";
            public static readonly string yearFrom = "2021";
            public static readonly string dayTo = "15";
            public static readonly string monthTo = "09";
            public static readonly string yearTo = "2022";
        }

        [SetUp]
        public void SetupIssuePage()
        {
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            Pages.LandingPage.ClickFindEvent();
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.IssuesAdminNavPageText);
        }
        [Ignore("Ignore test")]
        [Test]
        public void TestDatePickerOnIssuePage()
        {
            EnterDateToDatePicker();
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Assert.AreEqual(2, Pages.IssuesPage.GetFieldIssueResults(), "Amount of issue results doesn`t same as expected");
        }
        [Ignore("Ignore test")]
        [Test]
        public void TestCheckboxOnIssuePage()
        {
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Assert.AreEqual(3, Pages.IssuesPage.GetFieldIssueResults(), "Amount of issue results doesn`t same as expected");
        }

        [Test]
        public void TestIssueResetBtn()
        {
            EnterDateToDatePicker();
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckResolveText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckInProgressText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.ResetBtnText);
            Assert.IsEmpty(Pages.IssuesPage.GetTextDatepickerTo(), "Input is not empty");
        }

        #region TestSteps
        private void EnterDateToDatePicker()
        {
            Pages.IssuesPage.SendDataToDatapickerFrom(IssueTestData.dayFrom, IssueTestData.monthFrom, IssueTestData.yearFrom);
            Pages.IssuesPage.SendDataToDatapickerTo(IssueTestData.dayTo, IssueTestData.monthTo, IssueTestData.yearTo);
        }
        #endregion
    }
}
