using AventStack.ExtentReports;
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
        public ExtentReports rep;
        public ExtentTest test;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            Pages = new GUIMap(driver);
            rep = ExtentManager.GetInstance();
            test = rep.CreateTest(TestContext.CurrentContext.Test.FullName);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.FailCount > 0)
            {
                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                test.Log(Status.Fail, TestContext.CurrentContext.Result.Message);
                test.Fail("", MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot.AsBase64EncodedString).Build());
            }
            else
            {
                test.Log(Status.Pass, "Test pass");
            }
            rep.Flush();
            driver.Close();
            driver.Quit();
        }
    }
}
