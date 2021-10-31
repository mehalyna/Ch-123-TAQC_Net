using EventExpress.Pages.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExpress.Pages.Elements
{
    public class ButtonElement : WebComponent
    {
        public new void Click()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(Selector));
            base.Click();
        }
    }
}
