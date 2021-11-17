using NUnit.Framework;
using static EventExpress.Pages.IssuesPage;
using static EventExpress.Pages.NavigationPage;
using Status = AventStack.ExtentReports.Status;

namespace EventExpress.Tests
{
    [TestFixture]
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
            test.Log(Status.Info, "Start Login");
            Pages.LandingPage.GoToPage(UserData.BaseUrl);
            Pages.LandingPage.ClickSignIn();
            test.Log(Status.Info, "Open Modal Page");
            Pages.ModalPage.Login(UserData.EmailAdmin, UserData.PasswordAdmin);
            test.Log(Status.Info, "User data entered");
            Pages.LandingPage.ClickFindEvent();
            test.Log(Status.Info, "Home page open");
            Pages.NavigationPage.ClickNavPageTitle(NavigationElementsText.IssuesAdminNavPageText);
            test.Log(Status.Info, "Issue page open");
        }


        [Test]
        public void TestDatePickerOnIssuePage()
        {
            EnterDateToDatePicker();
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            test.Log(Status.Info, "Click Search button");
            Assert.AreEqual(2, Pages.IssuesPage.GetFieldIssueResults(), "Amount of issue results doesn`t same as expected");
        }

        [Test]
        public void TestCheckboxOnIssuePage()
        {
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            test.Log(Status.Info, "Click Search button");
            Assert.AreEqual(4, Pages.IssuesPage.GetFieldIssueResults(), "Amount of issue results doesn`t same as expected");
        }

        [Test]
        public void TestIssueResetBtn()
        {
            EnterDateToDatePicker();
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckOpenText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckResolveText);
            Pages.IssuesPage.ClickCheckbox(IssuesElementsText.CheckInProgressText);
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.SearchBtnText);
            test.Log(Status.Info, "Click Clear button");
            Pages.IssuesPage.ClickResetSearchBtn(IssuesElementsText.ResetBtnText);
            Assert.IsEmpty(Pages.IssuesPage.GetTextDatepickerTo(), "Input is not empty");
        }

        #region TestSteps
        private void EnterDateToDatePicker()
        {
            test.Log(Status.Info, "Entering Data to Datepickers");
            Pages.IssuesPage.SendDataToDatapickerFrom(IssueTestData.dayFrom, IssueTestData.monthFrom, IssueTestData.yearFrom);
            Pages.IssuesPage.SendDataToDatapickerTo(IssueTestData.dayTo, IssueTestData.monthTo, IssueTestData.yearTo);
            test.Log(Status.Info, "Entered Data to Datepickers");
        }
        #endregion
    }
}
