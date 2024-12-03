using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PiskulinIY.Sprint5.Task6.V7.Lib
    
{
    public class DataService : ISprint5Task6V7
    {

        
        public int LoadFromDataFile(string path)
        {

            
            {
                string content = File.ReadAllText(@"C:\Users\AeroC\AppData\Local\Temp\InPutDataFile.Task6V7.txt");
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
