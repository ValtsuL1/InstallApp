using System.IO;
using InstallLogic;

namespace Presentation
{
    public static class Presenter
    {
        public static string? InstallationPath { get; set; }
        private static string sourcePath = Path.Combine(Environment.CurrentDirectory, "Tiedostot");

        public static void Install()
        {
            var targetInfo = new DirectoryInfo(InstallationPath);
            var sourceInfo = new DirectoryInfo(sourcePath);
            Installer installer = new();

            installer.Install(sourceInfo, targetInfo);
        }
    }
}
