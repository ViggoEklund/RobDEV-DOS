using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sys = Cosmos.System;

namespace RDOS
{
    class VFS

    {
        public static void start()
        {
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
        }

        public static void write(string path, string[] text)
        {
            System.IO.File.WriteAllLines(path, text);
        }
        public static void files(string path, string[] arr1, string[] arr2)
        {
            string[] array1 = Directory.GetFiles(@"0:\");

            // Display all files.
            Console.WriteLine("--- Files: ---");
            foreach (string name in array1)
            {
                Console.WriteLine(name);
            }
        }
        public static void CreatFile(string Path)
        {
            System.IO.File.Create(Path);
        }
        public static void Creatdir(string Path)
        {
            System.IO.Directory.CreateDirectory(Path);
        }
        public static void Delfile(string Path)
        {
            System.IO.File.Delete(Path);
        }
        public static void DelDir(string Path)
        {
            System.IO.Directory.Delete(Path);
        }
    }
}
