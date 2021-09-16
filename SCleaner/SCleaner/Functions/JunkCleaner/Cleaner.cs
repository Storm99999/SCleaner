using SCleaner.Functions.Colorful_Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCleaner.Functions.JunkCleaner
{
    class Cleaner
    {
        /*                             MIT License

       Copyright ©️ 2021 Storm

       Permission is hereby granted, free of charge, to any person obtaining a copy
       of this software and associated documentation files (the "Software"), to deal
       in the Software without restriction, including without limitation the rights
       to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
       copies of the Software, and to permit persons to whom the Software is
       furnished to do so, subject to the following conditions:

       The above copyright notice and this permission notice shall be included in all
       copies or substantial portions of the Software.

       THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
       IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
       FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
       AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
       LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
       OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
       SOFTWARE. 
        


        - GitHub Source: https://github.com/Storm99999/SCleaner

        - Product License: MIT

        - Discord: https://discord.gg/bFPGZs35m8

        - Notes: THIS PRODUCT IS LICENSED UNDER THE MIT LICENSE, MEANS YOU CAN USE IT'S SOURCE FOR PRIVATE AND PUBLIC USE. (PLEASE DO NOT SELL THIS SOFTWARE).


        Enjoy.
         */
        public void CleanUp()
        {
            // String Of Visual Studio's Project Directory
            string ProjectDirs = $"C:\\Users\\{Environment.UserName}\\source\\repos";
            // String Of Better Discord's Installer Junk Directory
            string bdInstaller = $"C:\\Users\\{Environment.UserName}\\AppData\\Roaming\\BetterDiscord Installer";
            // DnSpy Junk
            string DnSpy = $@"C:\Users\{Environment.UserName}\AppData\Local\dnSpy";
            // Delete All Visual Studio Projects
            if (Directory.Exists(ProjectDirs))
            {
                string[] projFolders = Directory.GetDirectories(ProjectDirs);
                foreach (var dirs in projFolders)
                {
                    Directory.Delete(dirs, true);
                    DirectoryInfo dir = new DirectoryInfo(dirs);

                    CC.WriteLineSuccess("[+] Deleted "+ dir);
                }
                Directory.Delete(ProjectDirs, true);
            }
            else
            {
                CC.WriteLineError("[-] Not Deleted Project Directories In "+ ProjectDirs);
            }
            if (Directory.Exists(bdInstaller))
            {
                string[] Folders = Directory.GetDirectories(bdInstaller);
                foreach (var dirs in Folders)
                {
                    Directory.Delete(dirs, true);
                    DirectoryInfo dirInfo = new DirectoryInfo(dirs);
                    CC.WriteLineSuccess("[+] Deleted " + dirInfo.FullName);
                }
                string[] Files = Directory.GetFiles(bdInstaller);
                foreach (var files in Files)
                {
                    File.Delete(files);
                    FileInfo fileInfo = new FileInfo(files);
                    CC.WriteLineSuccess("[+] Deleted " + fileInfo.FullName);
                }
                Directory.Delete(bdInstaller,true);
            }
            else
            {
                CC.WriteLineError("[-] Not Deleted Files/Directories In " + bdInstaller);
            }

            // For A Suprise This Actually Does Not Break DnSpy Which Is Pretty Cool
            if (Directory.Exists(DnSpy))
            {
                // We Only Delete Folders Because Only In The Folders Are Files, So If We Delete Folders, We'll delete files automatically Too!
                string[] folders = Directory.GetDirectories(DnSpy);
                foreach (var folderStuff in folders)
                {
                    Directory.Delete(folderStuff, true);
                    DirectoryInfo fileInfo = new DirectoryInfo(folderStuff);

                    CC.WriteLineSuccess("[+] Deleted " + fileInfo.FullName);
                }
                Directory.Delete(DnSpy, true);
            }
            else
            {
                CC.WriteLineError("[-] Not Deleted Files/Directories In " + DnSpy);
            }
        }
    }
}
