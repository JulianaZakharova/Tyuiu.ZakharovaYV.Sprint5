using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.ZakharovaYV.Sprint5.Task5.V17.Lib;

namespace Tyuiu.ZakharovaYV.Sprint5.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт#5 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#5                                                                *");
            Console.WriteLine("* Тема:Чтение набора данных из текстового файла                           *");
            Console.WriteLine("* Задание # 5                                                             *");
            Console.WriteLine("* Вариант # 17                                                            *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти сумму всех простых целых чисел в файле.Полученный результат       *");
            Console.WriteLine("* вывести на консоль. У вещественных значений округлить до трёх знаков   * ");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask5V17.txt";

            Console.WriteLine(" Данные находятся в файле : " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма элементов файла : "+ res);
            Console.ReadKey();
        }
    }
}
