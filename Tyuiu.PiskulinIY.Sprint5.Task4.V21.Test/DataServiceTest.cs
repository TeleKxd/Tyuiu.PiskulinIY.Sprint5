using Tyuiu.PiskulinIY.Sprint5.Task4.V21.Lib;
namespace Tyuiu.PiskulinIY.Sprint5.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\AeroC\AppData\Local\Temp\InPutDataFile.Task4V0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}