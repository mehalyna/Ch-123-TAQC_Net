using OpenQA.Selenium;

namespace EventExpress.Pages.Common
{
    public class CommonPage : BaseWraper
    {
        public readonly string BaseUrl;

        public void GoToPage()
           => Driver.Navigate().GoToUrl(BaseUrl);

        public void GoToPage(string url)
            => Driver.Navigate().GoToUrl(url);

        public T InitPage<T>(IWebDriver driver) where T : CommonPage, new()
        {
            var page = new T();
            page.Init(driver);
            return page;
        }
    }
}
