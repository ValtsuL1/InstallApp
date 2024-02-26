using System.IO;

namespace InstallLogic
{
    public class Installer
    {
        public void Install(DirectoryInfo sourceInfo, DirectoryInfo targetInfo) 
        {
            Directory.CreateDirectory(targetInfo.FullName);


            // sleep functions added to better demonstrate installation progress
            foreach (var file in sourceInfo.GetFiles())
            {
                Thread.Sleep(500);
                file.CopyTo(Path.Combine(targetInfo.FullName, file.Name), true);
            }

            foreach (var sourceSubDir in sourceInfo.GetDirectories())
            {
                Thread.Sleep(500);
                var targetSubDir = targetInfo.CreateSubdirectory(sourceSubDir.Name);
                Install(sourceSubDir, targetSubDir);
            }
        }
    }
}
