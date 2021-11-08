using EventExpress.Pages.Common;
using SeleniumExtras.WaitHelpers;

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
