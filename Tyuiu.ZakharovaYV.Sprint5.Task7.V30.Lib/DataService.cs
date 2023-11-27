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
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if(fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                int numericValue;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    for(int i = 0; i < mas.Length; i++)
                    {
                        if (mas [i].Length == 1 && int.TryParse(mas[i], out numericValue))
                        {
                            strLine += " 9 ";
                        }
                        else 
                        {
                            strLine += mas[i] + " ";
                        }
                       
                    } 
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                        strLine = "";
                }
            }
            return pathSaveFile;

            

            //string res = File.ReadAllText(path);
            //int array = new char[res.Length];


            //for (int i = 0; i < res.Length; i++)
            {
               // if ((res[i] >= '0') & (res[i + 1] == ' '))
                {
                 //   res[i] = '9'; 
                }
                //else
                {
                  //  array[i] = res[i];
                }
            } 
              //  using (StreamWriter writer = new StreamWriter(pathSaveFile))
                {
                 //   writer.Write(array);
                } 
           // return pathSaveFile;
        }
           
    }
          
}
