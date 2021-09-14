using SCleaner.Functions.Colorful_Console;
using SCleaner.Functions.FileDeleter;
using SCleaner.Functions.JunkCleaner;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            string _title = (string)@"
   _____ _                              _____ _                            
  / ____| |                            / ____| |                           
 | (___ | |_ ___  _ __ _ __ ___       | |    | | ___  __ _ _ __   ___ _ __ 
  \___ \| __/ _ \| '__| '_ ` _ \      | |    | |/ _ \/ _` | '_ \ / _ \ '__|
  ____) | || (_) | |  | | | | | |     | |____| |  __/ (_| | | | |  __/ |   
 |_____/ \__\___/|_|  |_| |_| |_|      \_____|_|\___|\__,_|_| |_|\___|_|";

            Console.WriteLine(_title);
            CC.WriteLine("\n\n\n [1] Delete All Files Within A Folder\n\n [2] Delete All Directories Within A Folder\n\n [3] Detect And Delete Junk");
            CC.WriteLine("Choose A Option [>]:");
            var input = Console.ReadLine();
            if (input.ToLower().ToString() == "3")
            {
                Cleaner cleaner = new Cleaner();
                cleaner.CleanUp();
                Console.ReadLine();
            }
            if (input.ToLower().ToString() == "1")
            {
                CC.WriteLine("Enter The Path [>]:");
                var path = Console.ReadLine();
                FileManager fileManager = new FileManager();
                fileManager.DeleteAllFiles(path);
                Console.ReadLine();
            }
            if (input.ToLower().ToString() == "2")
            {
                CC.WriteLine("Enter The Path [>]:");
                var path = Console.ReadLine();
                FileManager fileManager = new FileManager();
                fileManager.DeleteAllDirs(path);
                Console.ReadLine();
            }
        }
    }
}
