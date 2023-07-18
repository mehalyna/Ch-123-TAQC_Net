using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace EventExpress.Pages
{
    public class IssuesPage : CommonPage
    {
        public static class IssuesElementsText
        {
            public static readonly string IssuesPageText = "Issues";
            public static readonly string SearchBtnText = "Search";
            public static readonly string ResetBtnText = "Reset";
            public static readonly string CheckOpenText = "Open";
            public static readonly string CheckInProgressText = "In progress";
            public static readonly string CheckResolveText = "Resolve";
        }

        #region CSS Selectors
        private string btnViewCSS(int index) => $"tr:nth-child({index})  a > button";
        private string checkXPath(string text) => $"//label[text()='{text}']/input";
        private string btnFormXPath(string text) => $"//div/button/span[text()='{text}']";
        private const string datapickerFromCSS = ".form-group:nth-child(1) .MuiInputBase-input.MuiInput-input";
        private const string datapickerToCSS = ".form-group:nth-child(2) .MuiInputBase-input.MuiInput-input";
        private const string fieldIssueResultsCSS = ".events-container"; // not working 
        #endregion
        #region Elements
        private ButtonElement btnResetSearch(string text) => FindElementByXPath<ButtonElement>(btnFormXPath(text));
        private ButtonElement btnView(int index) => FindElementByXPath<ButtonElement>(btnViewCSS(index + 1));
        private ButtonElement checkbox(string text) => FindElementByXPath<ButtonElement>(checkXPath(text));
        private DatePickerElement datapickerFrom => FindElementByCSS<DatePickerElement>(datapickerFromCSS);
        private DatePickerElement datapickerTo => FindElementByCSS<DatePickerElement>(datapickerToCSS);
        private ReadOnlyCollection<IWebElement> fieldIssueResults => FindElements(By.CssSelector(fieldIssueResultsCSS));
        #endregion
        public void ClickResetSearchBtn(string text) => btnResetSearch(text).Click();
        public void ClickViewBtn(int index) => btnView(index).Click();
        public void ClickCheckbox(string text) => checkbox(text).Click();
        public void SendDataToDatapickerFrom(string day, string month, string year) => datapickerFrom.SendDataToDatePicker(day, month, year);
        public void SendDataToDatapickerTo(string day, string month, string year) => datapickerTo.SendDataToDatePicker(day, month, year);
        public int GetFieldIssueResults() => fieldIssueResults.Count;
        public string GetTextDatepickerTo() => datapickerFrom.Text;
    }
}
