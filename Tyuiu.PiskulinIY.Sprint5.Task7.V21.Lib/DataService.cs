using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PiskulinIY.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pathsavefile = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint5\Tyuiu.PiskulinIY.Sprint5.Task7.V21\bin\Debug\net8.0\OutPutDataFileTask7V21.txt";

            FileInfo fileInfo = new FileInfo(pathsavefile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathsavefile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != ','))
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pathsavefile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathsavefile;

        }
    }
}
