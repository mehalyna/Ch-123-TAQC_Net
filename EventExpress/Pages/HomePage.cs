using EventExpress.Pages.Common;
using EventExpress.Pages.Elements;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection.Emit;
using System.Web;

namespace EventExpress.Pages
{
    public class HomePage : CommonPage
    {
        #region Selectors
        private string sortBtnCSS = "div[class='d-flex justify-content-end'] button:nth-child(1)";
        private string filterBtnXpath = "/ html / body / div[1] / div / div[3] / div[2] / div[1] / button"; // ??
        private string startSoonXpath = "//li[normalize-space()='Start soon']";
        private string recentlyPublishedXpath = "//li[normalize-space()='Recently published']";
        private string tagNameCss = ".float-left";
        private string eventsContainerCSS = "div[class='events-container'] div[class='row']";
        private string eventsCSS = ".col-12";
        private string categoryFilterXpath = "//body/div[@id='root']/div[@class='page-wrapper']/div[@id='main']/div/div[@class='MuiDrawer-root MuiDrawer-docked']/div[@class='MuiPaper-root MuiDrawer-paper jss44 MuiDrawer-paperAnchorRight MuiDrawer-paperAnchorDockedRight MuiPaper-elevation0']/form/div[2]";
        private string welnessXpath = "//body[1]/div[1]/div[1]/div[3]/div[2]/div[2]/div[1]/form[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]";
        private string climbingCheckboxXpath = "//input[@value='3517729d-f01b-4642-1e3f-08da11c89293']";
        private string applyFilterCSS = "button[type='submit'] span[class='MuiButton-label']";
        #endregion

        #region Elements
        private ButtonElement sortButton => FindElementByCSS<ButtonElement>(sortBtnCSS);
        private ButtonElement filterButton => FindElementByXPath<ButtonElement>(filterBtnXpath);
        private ButtonElement startSoonXButton => FindElementByXPath<ButtonElement>(startSoonXpath);
        private ButtonElement recentlyPublishedButton => FindElementByXPath<ButtonElement>(recentlyPublishedXpath);
        private TableElement eventsContainer => FindElementByCSS<TableElement>(eventsContainerCSS);
        private ReadOnlyCollection<IWebElement> events => FindElements(By.CssSelector(eventsCSS));
        private ReadOnlyCollection<IWebElement> tagNames => FindElements(By.CssSelector(tagNameCss));
        private ButtonElement categoryFilter => FindElementByXPath<ButtonElement>(categoryFilterXpath);
        private ButtonElement welness => FindElementByXPath<ButtonElement>(welnessXpath);
        private ButtonElement climbingCheckBox => FindElementByXPath<ButtonElement>(climbingCheckboxXpath);
        private ButtonElement applyFilter => FindElementByCSS<ButtonElement>(applyFilterCSS);
        #endregion

        public void ClickOnSortButton()
        {
            WaitAndClickOnButtonElement(sortButton, eventsContainerCSS);
        }
        public void Filter()
        {
            WaitAndClickOnButtonElement(filterButton, eventsContainerCSS);
            categoryFilter.Click();
            welness.Click();
            climbingCheckBox.Click();
            applyFilter.Click();
        }
        


        public void ClickOnRecentlyPublished()
        {
            WaitAndClickOnButtonElement(recentlyPublishedButton, eventsContainerCSS);
        }
        public string GetFirstTagName()
        {
            IWebElement firstElement = tagNames[0];
            return firstElement.Text;

        }
        

    }
}
