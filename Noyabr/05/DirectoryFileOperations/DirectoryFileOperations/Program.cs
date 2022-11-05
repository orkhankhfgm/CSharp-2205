using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = ReadFileContentByLine("C:/test/salam.txt");
        }

        static void CreateNewFolder(string path)
        {
            DirectoryInfo dirInfo = Directory.CreateDirectory(path);
        }

        static void CreateNewFolderIfNotExists(string path)
        {
            bool pathExists = Directory.Exists(path);

            if (!pathExists)
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(path);
            }
        }

        static void DeleteFolder(string path)
        {
            Directory.Delete(path, true);
        }

        static void MoveFolder(string source, string destination)
        {
            Directory.Move(source, destination);
        }

        static bool FileExists(string path)
        {
            var isFileExists = File.Exists(path);
            return isFileExists;
        }

        static void CreateFile(string path)
        {
            if (!FileExists(path))
            {
                FileStream fileStream = File.Create(path);
                fileStream.Close();
            }
            else
            {
                Console.WriteLine(path + " fayli artiq movcuddur!");
            }
        }

        static void DeleteFile(string path)
        {
            if (FileExists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine(path + " fayli artiq silinib!");
            }
        }

        static void MoveFile(string from, string to)
        {
            File.Move(from, to);
        }

        static void CopyFile(string from, string to)
        {
            File.Copy(from, to);
        }

        static void AppendTextToFile(string path, string text)
        {
            File.AppendAllText(path, text);
        }

        static string ReadFileContent(string path)
        {
            string content = File.ReadAllText(path);
            return content;
        }

        static void AppendMultipleTextsToFile(string path, List<string> texts)
        {
            File.AppendAllLines(path, texts);
        }

        static string[] ReadFileContentByLine(string path)
        {
            string[] contents = File.ReadAllLines(path);

            return contents;
        }
    }
}
