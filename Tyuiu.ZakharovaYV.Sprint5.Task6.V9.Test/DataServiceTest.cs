using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ZakharovaYV.Sprint5.Task6.V9.Lib;

namespace Tyuiu.ZakharovaYV.Sprint5.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            
            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";

            DataService DataService = new DataService();
            int count = 2;
            int res = DataService.LoadFromDataFile(path);
            Assert.AreEqual(count, res);
        }
    }
}
