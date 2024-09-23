using Tyuiu.RaushKN.Sprint2.Task6.V3.Lib;

namespace Tyuiu.RaushKN.Sprint2.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #2                                                               #");
            Console.WriteLine("# Тема: Получение результата из switch                                    #");
            Console.WriteLine("# Задание #6                                                              #");
            Console.WriteLine("# Вариант #3                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Составить программу, которая в зависимости от порядкового номера дня    #");
            Console.WriteLine("# недели (1, 2, …, 7) выводит на экран его название (понедельник,         #");
            Console.WriteLine("# вторник, …, воскресенье).                                               #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int value;
            Console.WriteLine("Введите номер дня: ");
            value = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((value < 1) || (value > 7)) res = "Введено неверное значение";
            else res = "Это месяц: " + ds.FindDayName(value);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
