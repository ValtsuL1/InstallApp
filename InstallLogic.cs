﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallLogic
{
    public class Installer
    {
        public void Install(DirectoryInfo sourceInfo, DirectoryInfo targetInfo) 
        {
            Directory.CreateDirectory(targetInfo.FullName);

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