using System.IO;

namespace EventExpress
{
    public class Helper
    {
        public static string GetProjectBinDirectory()
            => Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static string GetProjectDirectory()
        {
            var binLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return binLocation.Substring(0, binLocation.IndexOf("\\bin"));
        }
    }
}
