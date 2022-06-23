using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    internal class Sample01
    {

        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            if (lastDirectory)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "│  ";
            }

            Console.WriteLine(dir.Name);

            DirectoryInfo[] subDirs = dir.GetDirectories();

            FileInfo[] subFiles = dir.GetFiles();

            // вывести иерархию вместе с файлами

            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, i == subDirs.Length - 1);
            }


        }

        static void Main(string[] args)
        {
            // Directory, File, FileInfo, DirectoryInfo

            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                Console.WriteLine($"FullName: {directoryInfo.FullName}");
                Console.WriteLine($"Name: {directoryInfo.Name}");
                Console.WriteLine($"Parent: {directoryInfo.Parent}");
                Console.WriteLine($"CreationTime: {directoryInfo.CreationTime}");
                Console.WriteLine($"Root: {directoryInfo.Root}");

                
            }


            PrintDir(new DirectoryInfo(@"D:\My_projects\!GeekBrains\4 Основы С#\CScharp_Level1_Lessons\Lesson06"), "", true);
            
        
        }
    }
}