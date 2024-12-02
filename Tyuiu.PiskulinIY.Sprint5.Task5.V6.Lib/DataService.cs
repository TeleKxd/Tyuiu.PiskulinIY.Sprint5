using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PiskulinIY.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    
                    res = res + (Convert.ToDouble(line) / 20);
                }
            }

            return Math.Round(res, 3);

        }
    }
}
