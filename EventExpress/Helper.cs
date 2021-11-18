using System.IO;

namespace EventExpress
{
    public class Helper
    {
        public static string GetProjectDirectory()
            => Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}
