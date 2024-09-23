using Tyuiu.RaushKN.Sprint2.Task7.V2.Lib;

namespace Tyuiu.RaushKN.Sprint2.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #2                                                               #");
            Console.WriteLine("# Тема: Создание итогового решения по спринту                             #");
            Console.WriteLine("# Задание #7                                                              #");
            Console.WriteLine("# Вариант #2                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу на C#, которая запрашивает исходные данные           #");
            Console.WriteLine("# (вещественные значения) и вычисляет, находится ли точка с координатами  #");
            Console.WriteLine("# X,Y в заштрихованной области         /                                  #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            double x, y;

            Console.WriteLine("Введите значение переменной x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y: ");
            y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            if (res) Console.WriteLine("Точка находится в заштрихованной области");
            else Console.WriteLine("Точка не находится в заштрихованной области");

            Console.ReadKey();
        }
    }
}
