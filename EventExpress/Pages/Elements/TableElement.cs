using EventExpress.Pages.Common;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;

namespace EventExpress.Pages.Elements
{
    class TableElement : WebComponent
    {
        public int FindElementInRow(string searchName)
        {
            Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(Selector));
            var sd = new List<IWebElement>(FindElements(Selector));
            var df = sd.Find(x => x.Text == searchName);
            return sd.IndexOf(df);
        }
    }
}
