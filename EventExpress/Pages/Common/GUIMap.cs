using OpenQA.Selenium;

namespace EventExpress.Pages.Common
{
    public class GUIMap
    {
        public LandingPage LandingPage;
        public ModalPage ModalPage;
        public NavigationPage NavigationPage;
        public IssuesPage IssuesPage;

        public GUIMap(IWebDriver driver)
        {
            LandingPage = new LandingPage().InitPage<LandingPage>(driver);
            ModalPage = new ModalPage().InitPage<ModalPage>(driver);
            NavigationPage = new NavigationPage().InitPage<NavigationPage>(driver);
            IssuesPage = new IssuesPage().InitPage<IssuesPage>(driver);
        }
    }
}
