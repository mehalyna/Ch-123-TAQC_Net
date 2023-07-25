using EventExpress.Pages.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EventExpress
{
    public class UIFixture
    {
        public IWebDriver driver;
        public GUIMap Pages;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            Pages = new GUIMap(driver);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
