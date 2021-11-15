using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExpress.Pages
{
    public class HomePage : CommonPage
    {
        public static class HomePageElementsText
        {
            public static readonly string ResetBtnText = "Reset";
            public static readonly string FavouriteBtnText = "Favourite";
            public static readonly string SearchBtnText = "Search";
        }
        #region Selectors for Home Page
        private string btnCardToEventLinkCSS (int index) => $"div:nth-child({index}) > div > .MuiCardMedia-root";
        private string btnNumberOfPageCSS (int index) => $"button.btn-primary:nth-child({index})";
        private const string inpKeywordCSS = "input[name='keyWord']";
        private const string btnMoreFiltersCSS = "button.MuiButton-textSecondary";
        private string btnResetFavouriteSearchXPath (string text) => $"//span [text() ='{text}']";
        #endregion
        #region Selecrots for More Filters Menu
        private const string inpDateFromCSS = ".form-group:nth-child(2) input";
        private const string inpDateToCSS = ".form-group:nth-child(3) input";
        private const string inpHashtagsCSS = "input.rw-input-reset";
        private string checkXpath (int index) => $"//input [@name='statuses[{index}]']";
        private const string btnFilterByLocationCSS = "button.MuiButton-outlined";
        private const string btnLessCSS = "button.MuiButton-textSecondary";
        #endregion
        //Locators for tests.
        private const string resultCSS = ".h1";
        private const string eventTitleCSS = ".text-block > .title";
        #region Elements
        private ButtonElement cardToEventLink(int index) => FindElementByCSS<ButtonElement>(btnCardToEventLinkCSS(index + 1));
        private ButtonElement numberOfPage(int index) => FindElementByCSS<ButtonElement>(btnNumberOfPageCSS(index + 1));
        private ButtonElement keyword => FindElementByCSS<ButtonElement>(inpKeywordCSS);
        private ButtonElement moreFilters => FindElementByCSS<ButtonElement>(btnMoreFiltersCSS);
        private ButtonElement resetfavouritesearch(string text) => FindElementByXPath<ButtonElement>(btnResetFavouriteSearchXPath(text));
        private DatePickerElement dateFrom => FindElementByCSS<DatePickerElement>(inpDateFromCSS);
        private DatePickerElement dateTo => FindElementByCSS<DatePickerElement>(inpDateToCSS);
        private ButtonElement hashtags => FindElementByCSS<ButtonElement>(inpHashtagsCSS);
        private ButtonElement check (int index) => FindElementByXPath<ButtonElement>(checkXpath(index));
        private ButtonElement filterByLocation => FindElementByCSS<ButtonElement>(btnFilterByLocationCSS);
        private ButtonElement less => FindElementByCSS<ButtonElement>(btnLessCSS);
        private WebComponent result => FindElementByCSS<WebComponent>(resultCSS);
        private WebComponent eventTitle => FindElementByCSS<WebComponent>(eventTitleCSS);
        #endregion
        public void ClickCardToEventLink(int index) => cardToEventLink(index).Click();
        public void ClickNumberOfPage(int index) => numberOfPage(index-1).Click();
        public void InputKeyword(string text) => keyword.SendKeys(text);
        public void ClickMoreFilters() => moreFilters.Click();
        public void ClickResetFavoutiteSearch(string text) => resetfavouritesearch(text).Click();
        public void SendDataToDatapickerFrom(string day, string month, string year) => dateFrom.SendDataToDatePicker(day, month, year);
        public void SendDataToDatapickerTo(string day, string month, string year) => dateTo.SendDataToDatePicker(day, month, year);
        public void InputHashtags(string text) => hashtags.SendKeys(text);
        public void ClickCheck(int index) => check(index).Click();
        public void ClickFilterByLocation() => filterByLocation.Click();
        public void ClickLess() => less.Click();
        #region Method for tests
        public bool IsResultPresent() => result.Displayed;
        public bool IsTitleDisplayed() => eventTitle.Displayed;
        public string GetUrl() => Driver.Url;
        #endregion
    }
}
