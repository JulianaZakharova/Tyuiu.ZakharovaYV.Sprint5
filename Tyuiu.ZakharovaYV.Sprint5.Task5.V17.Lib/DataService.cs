using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakharovaYV.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if ((Convert.ToInt32(Convert.ToDouble(line)) == Convert.ToDouble(line)) && (Convert.ToDouble(line) >= 0))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                    
                    
                }
                 res = 0;
                for (int i = 1; i <= Convert.ToDouble(line); i++)
                {
                    res = res + Convert.ToDouble(line);
                }
            }
            return res;
            
        }
    }
}
