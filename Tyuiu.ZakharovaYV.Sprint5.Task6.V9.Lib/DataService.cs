using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakharovaYV.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {

            string z = File.ReadAllText(path);
            int count = 0;
            string[] words = z.Split(' ');
            foreach (string word in words)
                if (word.Length == 3)
                {
                    count++;
                }
            return count;

        }    
    }   
}
