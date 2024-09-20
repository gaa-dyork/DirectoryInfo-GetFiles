using System.IO;

namespace GetFiles_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePrefix = "GL0013";
            string filePath = "C:/tmp/TestFiles";

            var searchDirInfo = new DirectoryInfo(filePath);
            var imageInfos = searchDirInfo.GetFiles(filePrefix + "*.jpg", SearchOption.TopDirectoryOnly);
        }
    }
}
