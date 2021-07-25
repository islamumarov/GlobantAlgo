using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderPath
{
    public class FolderNode
    {
        public Tuple<List<string>, List<string>> GetFilesAndFolders(string root, int depth)
        {
            var folders = new List<string>();
            var files = new List<string>();
            foreach (var directory in Directory.EnumerateDirectories(root))
            {
                folders.Add(directory);
                if (depth > 0)
                {
                    var result = GetFilesAndFolders(directory, depth - 1);
                    folders.AddRange(result.Item1);
                    files.AddRange(result.Item2);
                }
            }

            files.AddRange(Directory.EnumerateFiles(root));

            return new Tuple<List<string>, List<string>>(folders, files);
        }

        public Tuple<List<string>, List<string>> GetFilesAndFoldersItterative(string _root, int depth)
        {
            List<string> roots = new List<string>() { _root };
            var folders = new List<string>();
            var files = new List<string>();
            while (depth > 0)
            {
                try
                {
                    foreach (var root in roots)
                    {
                        foreach (var directory in Directory.EnumerateDirectories(root))
                        {
                            folders.AddRange(Directory.EnumerateDirectories(directory));
                            files.AddRange(Directory.EnumerateFiles(directory));
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new ArgumentOutOfRangeException("No such depth path"); ;
                }

                roots = folders;
                depth--;
            }

            return new Tuple<List<string>, List<string>>(folders, files);
        }
    }
}
