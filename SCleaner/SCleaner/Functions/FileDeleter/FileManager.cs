using SCleaner.Functions.Colorful_Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCleaner.Functions.FileDeleter
{
    class FileManager
    {
        public void DeleteAllFiles(string dir)
        {
            if (Directory.Exists(dir))
            {
                string[] Files = Directory.GetFiles(dir);
                foreach (var dirs in Files)
                {
                    File.Delete(dirs);
                    FileInfo dirInfo = new FileInfo(dirs);

                    CC.WriteLineSuccess("[+] Deleted " + dirInfo.FullName);
                }
            }
            else
            {
                CC.WriteLineError("Invalid Directory Path.");
            }
        }

        public void DeleteAllDirs(string dir)
        {
            if (Directory.Exists(dir))
            {
                string[] Files = Directory.GetDirectories(dir);
                foreach (var dirs in Files)
                {
                    Directory.Delete(dirs);
                    DirectoryInfo dirInfo = new DirectoryInfo(dirs);

                    CC.WriteLineSuccess("[+] Deleted " + dirInfo.FullName);
                }
            }
            else
            {
                CC.WriteLineError("Invalid Directory Path.");
            }
        }
    }
}
