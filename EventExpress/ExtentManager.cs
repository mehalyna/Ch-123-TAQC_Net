using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace EventExpress
{
    public class ExtentManager
    {
        public static ExtentHtmlReporter htmlReporter;
        private static ExtentReports extent;

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                string reportPath = $"{Helper.GetProjectBinDirectory()}\\results\\report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");

                string extentConfigPath = $"{Helper.GetProjectDirectory()}\\extent-config.xml";
                htmlReporter.LoadConfig(extentConfigPath);
            }
            return extent;
        }

    }
}
