﻿using Tyuiu.RaushKN.Sprint2.Task1.V29.Lib;

namespace Tyuiu.RaushKN.Sprint2.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #2                                                               #");
            Console.WriteLine("# Тема: Логические операции                                               #");
            Console.WriteLine("# Задание #1                                                              #");
            Console.WriteLine("# Вариант #29                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу из операций сравнений (==, !=, <, >, <=, >=,         #");
            Console.WriteLine("# последовательность можно чередовать, но использовать один раз в         #");
            Console.WriteLine("# выражении) и логических операций (|, &, ||, &&, !, ^,                   #");
            Console.WriteLine("# последовательность операций не должна нарушаться), а также              #");
            Console.WriteLine("# арифметических выражений, которая вернет логическую                     #");
            Console.WriteLine("# последовательность(массив): (True, True, True, False, True, True), при  #");
            Console.WriteLine("# a = 657, b = 654, c = 657, d = 657                                      #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("a = " + a);
            Console.WriteLine("a = " + b);
            Console.WriteLine("a = " + c);
            Console.WriteLine("a = " + d);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        
            Console.ReadKey();
        }
    }
}
