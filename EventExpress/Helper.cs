using System.IO;

namespace EventExpress
{
    public class Helper
    {
        public static string GetProjectBinDirectory()
            => Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static string GetProjectDirectory()
        {
            string df = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return $"{df.Substring(0, df.IndexOf("\\bin\\Debug"))}";
        }

    }
}
