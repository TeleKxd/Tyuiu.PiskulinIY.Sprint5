using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PiskulinIY.Sprint5.Task6V7.Lib
    
{
    public class DataService : ISprint5Task6V7
    {

        
        public int LoadFromDataFile(string path)
        {

            
            {
                string content = File.ReadAllText(@"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint5\Tyuiu.PiskulinIY.Sprint5.Task6V7\bin\Debug\net8.0\InPutDataFile.Task6V7.txt");
                int count = 0;
                
                foreach (char c in content)
                {
                    if (char.IsLower(c))
                    {
                        count++;
                    }
                }
                return count;
            }
            
        }
    }
}
