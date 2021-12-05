using System;
using System.IO;
using System.IO.Compression;

namespace CustomClassesLibrary.Homework15
{
    public class FindFileRecursive
    {

        private FileInfo FindInDir(DirectoryInfo dir, string fileName)
        {
            foreach (var file in dir.GetFiles())
            {
                if (file.Name.Equals(fileName))
                {
                    return file;
                }
            }

            foreach (var subdir in dir.GetDirectories())
            {
                var file = FindInDir(subdir, fileName);
                if (file != null)
                {
                    return file;
                }
            }

            return null;
        }


        public void FindFile(string directory, string fileName)
        {
            try
            {
                var file = FindInDir(new DirectoryInfo(directory), fileName);
                if (file != null)
                {
                    var newPath = Compress(file.FullName, @"D:\Test\Test2\SubDir1\Test.gz");
                    Console.WriteLine($"Compress complete successfully. New path {newPath}");
                }
                else
                {
                    throw new FileNotFoundException($"File with name: {fileName} not found");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string Compress(string sourceFile, string compressedFile)
        {
            //поток для чтения исходного файла
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                // поток для записи сжатого файла
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    // поток архивации
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                        return targetStream.Name;
                    }
                }
            }
        }

    }
}
