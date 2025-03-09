using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code.Recursive
{
    public class DirectoryList
    {
        public static void FindDirectory(string path)
        {
            string[] dirctories = Directory.GetDirectories(path);

            foreach (var dir in dirctories)
            {
                Console.WriteLine(dir);
                FindDirectory(dir);
            }
        }
    }
}
