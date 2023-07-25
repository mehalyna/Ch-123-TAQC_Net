using EventExpress.Pages.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;

namespace EventExpress.Pages.Common
{
    public abstract class BaseWraper : ISearchContext
    {
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait Wait { get; set; }

        public void Init(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        public T FindElementByCSS<T>(string locator) where T : WebComponent, new()
            => FindElement<T>(By.CssSelector(locator));

        public T FindElementByXPath<T>(string locator) where T : WebComponent, new()
            => FindElement<T>(By.XPath(locator));
        public T FindElementById<T>(string locator) where T : WebComponent, new()
           => FindElement<T>(By.Id(locator));

        public T FindElement<T>(By by) where T : WebComponent, new()
        {
            Wait.Until(drv => drv.FindElement(by));
            var el = new T();
            el.Init(by, Driver);
            return el;
        }

        public IWebElement FindElement(By by)
        {
            return Wait.Until(drv => drv.FindElement(by));
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            Wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
            return Wait.Until(drv => drv.FindElements(by));
        }
        public void WaitAndClickOnButtonElement(ButtonElement button, string locator)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
            button.Click();

        }

    }
}
