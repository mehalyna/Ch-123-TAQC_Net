using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExpress.Pages.Common
{
    public class WebComponent : BaseWraper, IWebElement
    {
        protected By Selector { get; private set; }
        private IWebElement baseComponent => FindElement(Selector);
        public string TagName => baseComponent.TagName;
        public string Text => baseComponent.Text;
        public bool Enabled => baseComponent.Enabled;
        public bool Selected => baseComponent.Selected;

        public Point Location => baseComponent.Location;

        public Size Size => baseComponent.Size;

        public bool Displayed => baseComponent.Displayed;

        public void Clear()
            => baseComponent.Clear();

        public void Click()
            => baseComponent.Click();

        public string GetAttribute(string attributeName)
            => baseComponent.GetAttribute(attributeName);

        public string GetCssValue(string propertyName)
            => baseComponent.GetCssValue(propertyName);

        public string GetDomAttribute(string attributeName)
            => baseComponent.GetDomAttribute(attributeName);

        public string GetDomProperty(string propertyName)
            => baseComponent.GetDomProperty(propertyName);

        public string GetProperty(string propertyName)
            => baseComponent.GetProperty(propertyName);

        public ISearchContext GetShadowRoot()
            => baseComponent.GetShadowRoot();

        public void SendKeys(string text)
            => baseComponent.SendKeys(text);

        public void Submit()
         => baseComponent.Submit();

        public void Init(By by, IWebDriver driver)
        {
            Selector = by;
            Init(driver);
        }
    }
}
