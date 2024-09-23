using Tyuiu.RaushKN.Sprint2.Task4.V5.Lib;

namespace Tyuiu.RaushKN.Sprint2.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #2                                                               #");
            Console.WriteLine("# Тема: Тернарный оператор                                                #");
            Console.WriteLine("# Задание #4                                                              #");
            Console.WriteLine("# Вариант #5                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу, которая вычисляет требуемое значение с              #");
            Console.WriteLine("# использованием тернарного оператора, где пользователь вводит значение   #");
            Console.WriteLine("# переменных x,y с клавиатуры                                             #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            double x, y;
            Console.WriteLine("Введите значение переменной x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y: ");
            y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
