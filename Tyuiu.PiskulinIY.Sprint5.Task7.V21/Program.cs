using Tyuiu.PiskulinIY.Sprint5.Task7.V21.Lib;
namespace Tyuiu.PiskulinIY.Sprint5.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Пискулин Игорь Юрьевич | ИСТНб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат, и печатает его на экране.                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");


            string path = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint5\Tyuiu.PiskulinIY.Sprint5.Task7.V21\bin\Debug\net8.0\InPutDataFileTask7V21.txt";
            string pathsavefile = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint5\Tyuiu.PiskulinIY.Sprint5.Task7.V21\bin\Debug\net8.0\OutPutDataFileTask7V21.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле: " );
            pathsavefile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathsavefile);
            Console.ReadKey();  

        }
    }
}
