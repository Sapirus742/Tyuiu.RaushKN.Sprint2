﻿using Tyuiu.RaushKN.Sprint2.Task2.V22.Lib;

namespace Tyuiu.RaushKN.Sprint2.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #2                                                               #");
            Console.WriteLine("# Тема: Оператор if – полная и короткая форма записи                      #");
            Console.WriteLine("# Задание #2                                                              #");
            Console.WriteLine("# Вариант #22                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу на, которая запрашивает целые значения с клавиатуры  #");
            Console.WriteLine("# и вычисляет находится ли точка с координатами X,Y в заштрихованной      #");
            Console.WriteLine("# области.                                                                #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Введите значение переменной x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
