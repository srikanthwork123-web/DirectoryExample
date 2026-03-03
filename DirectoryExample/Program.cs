using System;
using System.IO;

namespace DirectoryExample
{
    class Program
    {
        static void Main()
        {//here we are checking folder is exist or not
            if (Directory.Exists(@"D:\folder1") == true)
            {//if the folder is exists delete that folder
                Directory.Delete(@"D:\folder1", true);
            }
            if (Directory.Exists(@"D:\folder2") == true)
            {
                Directory.Delete(@"D:\folder2", true);
            }
            //CreateDirectory() method creates a folder.folder and Directory both are same.
            Directory.CreateDirectory(@"D:\folder1");
            Console.WriteLine("folder1 created");
            Console.WriteLine("folder1 exists: " + Directory.Exists(@"D:\folder1")); //Output: True
            //Delete() method deltes the folder
            Directory.Delete(@"D:\folder1");
            Console.WriteLine("folder1 deleted");
            Console.WriteLine("folder1 exists: " + Directory.Exists(@"D:\folder1")); //Output: False

            Directory.CreateDirectory(@"D:\folder1");
            Console.WriteLine("folder1 created");
            //Directory.CreateDirectory(@"D:\folder2");
            //Console.WriteLine("folder2 created");
            Directory.Move(@"D:\folder1", @"D:\folder2");//Move() method rename the foldername.
            Console.WriteLine("folder1 moved as folder2");

            Console.ReadKey();
        }
    }
}


