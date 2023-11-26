using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakharovaYV.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V30.txt";;

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] >= 0 && line[i] <= 9)
                        {
                            strLine += "9";
                        }

                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
