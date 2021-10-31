using EventExpress.Pages.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExpress.Pages.Elements
{
    public class DatePickerElement: WebComponent
    {
        public void SendDataToDatePicker(string day, string month, string year)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Selector));
            SendKeys(year);
            SendKeys(year);
            SendKeys(year);
            SendKeys(Keys.ArrowLeft);
            SendKeys(month);
            SendKeys(Keys.ArrowLeft);
            SendKeys(Keys.ArrowLeft);
            SendKeys(day);
        }
    }
}
