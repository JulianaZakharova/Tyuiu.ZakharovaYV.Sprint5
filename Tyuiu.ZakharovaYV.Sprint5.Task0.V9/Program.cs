using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint5.Task0.V9.Lib;

namespace Tyuiu.ZakharovaYV.Sprint5.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();
            Console.Title = "Спринт#4 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#5                                                                *");
            Console.WriteLine("* Тема:Класс File. Запись данных в текстовый файл                         *");
            Console.WriteLine("* Задание # 0                                                             *");
            Console.WriteLine("* Вариант # 9                                                             *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3,                        *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt и              *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
            Console.WriteLine("*  y = (x^3)/(x^2 -1)                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Фаил : " + res);
            Console.WriteLine("Создан !");
            Console.ReadKey();

        }
    }
}
