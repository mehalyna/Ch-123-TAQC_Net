using EventExpress.Pages.Common;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExpress.Pages.Elements
{
    class TableElement: WebComponent
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
