// Module : https://learn.microsoft.com/ko-kr/training/modules/dotnet-files/

using System.Diagnostics;

namespace MyStudy
{
    public class DotnetFile
    {
        public void CreateDirandFile(string dir, string fileName)
        {
            bool dirExistis = Directory.Exists((Path.Combine(Directory.GetCurrentDirectory(), dir)));
            bool fileExists = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), dir, fileName + ".txt"));
            if (!dirExistis)
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), dir));
                Debug.WriteLine("Directory created : " + dir);

                if (!fileExists)
                {
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), dir, fileName + ".txt"), "Hello World");
                    Debug.WriteLine("File created : " + fileName + ".txt");

                }
                else
                {
                    Debug.WriteLine("File already exists.");
                }

            }
            else
            {
                Debug.WriteLine("Directory already exists.");
            }

        }
    }
}