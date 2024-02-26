using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstallLogic;

namespace Presentation
{
    public static class Presenter
    {
        public static string? InstallationPath { get; set; }
        private static string sourcePath = Path.Combine(Environment.CurrentDirectory, "copyfrom");

        public static void Install()
        {
            var targetInfo = new DirectoryInfo(InstallationPath);
            var sourceInfo = new DirectoryInfo(sourcePath);
            Installer installer = new();

            installer.Install(sourceInfo, targetInfo);
        }
    }
}
