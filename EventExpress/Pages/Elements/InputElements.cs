using EventExpress.Pages.Common;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExpress.Pages.Elements
{
    class InputElements: WebComponent
    {
        public void SendData(string data)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Selector));
            SendKeys(data);
        }
    }
}
