using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        // Смоделировать работу простого калькулятора.
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            
            try
            {
                Console.Write("Введите целое число X = ");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y = ");
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции: \n \t1 - Сложение\n \t2 - Вычитание\n \t3 - Умножение\n \t4 - Деление ");
                int Z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор: " + Z);

                switch (Z)
                {
                    case 1:
                        int sum = X + Y;
                        Console.WriteLine("Результат = {0}", sum);
                        break;
                    case 2:
                        int subtr = X - Y;
                        Console.WriteLine("Результат = {0}", subtr);
                        break;
                    case 3:
                        int prod = X * Y;
                        Console.WriteLine("Результат = {0}", prod);
                        break;
                    case 4:
                        double div = (double)(X / Y);
                        Console.WriteLine("Результат = {0:f2}", div);
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка! Деление на ноль запрещено");
            }
            catch (Exception)
            {
                Console.WriteLine("Нет операции с указанным номером");
            }

            Console.ReadKey();
        }
    }
}
