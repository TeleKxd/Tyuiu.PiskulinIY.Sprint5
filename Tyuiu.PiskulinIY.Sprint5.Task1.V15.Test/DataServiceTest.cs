using Tyuiu.PiskulinIY.Sprint5.Task1.V15.Lib;
namespace Tyuiu.PiskulinIY.Sprint5.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint5\Tyuiu.PiskulinIY.Sprint5.Task1.V15\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}