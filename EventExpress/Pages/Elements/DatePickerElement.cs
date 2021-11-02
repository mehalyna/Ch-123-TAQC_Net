using EventExpress.Pages.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace EventExpress.Pages.Elements
{
    public class DatePickerElement: WebComponent
    {
        public void SendDataToDatePicker(string day, string month, string year)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Selector));
            SendKeys(Keys.LeftControl + "a");
            SendKeys(day);
            SendKeys(month);
            SendKeys(year);
        }
    }
}
