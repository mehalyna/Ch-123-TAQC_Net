using EventExpress.Pages.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EventExpress
{
    public class UIFixture
    {
        private IWebDriver driver;
        public GUIMap Pages;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            Pages = new GUIMap(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
