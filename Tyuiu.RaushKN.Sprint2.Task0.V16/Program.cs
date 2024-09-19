﻿using Tyuiu.RaushKN.Sprint2.Task0.V16.Lib;

namespace Tyuiu.RaushKN.Sprint2.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1025;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #2                                                               #");
            Console.WriteLine("# Тема: Операции сравнения                                                #");
            Console.WriteLine("# Задание #0                                                              #");
            Console.WriteLine("# Вариант #16                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу из операций сравнений (==, !=, <, >, <=, >=,         #");
            Console.WriteLine("# последовательность операций не должна нарушаться) и арифметических      #");
            Console.WriteLine("# выражений, которая вернет логическую последовательность(массив):        #");
            Console.WriteLine("# (True, False, True, False, True, False), при x = 1025, y = 275          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ                                                         #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            for(int i = 0; i <6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
