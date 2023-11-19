using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZakharovaYV.Sprint5.Task3.V3.Lib;

namespace Tyuiu.ZakharovaYV.Sprint5.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\USER\source\repos\Tyuiu.ZakharovaYV.Sprint5\Tyuiu.ZakharovaYV.Sprint5.Task3.V3\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
