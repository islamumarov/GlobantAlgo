using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderPath
{
    public class Program
    {
        public static void Main(string[] ars)
        {
            var cs = new FolderNode();
            var filesFolderLoop = cs.GetFilesAndFoldersItterative(@"C:\Users\Public", 2); 
            var filesFoldersRecursive = cs.GetFilesAndFolders(@"C:\Users\Public", 1);

            foreach (var v in filesFolderLoop.Item1)
            {
                Console.WriteLine("Folder:  " + v);
                
            }

            foreach (var f in filesFolderLoop.Item2)
            {
                Console.WriteLine("Files:  "+ f);
            }
            
        }
    }
}
