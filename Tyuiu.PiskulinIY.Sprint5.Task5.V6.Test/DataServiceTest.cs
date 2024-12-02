using Tyuiu.PiskulinIY.Sprint5.Task5.V6.Lib;
namespace Tyuiu.PiskulinIY.Sprint5.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\AeroC\AppData\Local\Temp\InPutDataFile.Task5V6.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}