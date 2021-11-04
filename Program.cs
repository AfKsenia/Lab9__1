using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 1;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое значение ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе значение ");
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exe)
                {
                    Console.WriteLine(exe.Message);
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Выберите операцию \n1 - сложение\n2 - вычитание\n3 - умножение\n4 - деление");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат сложения = {0}", a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат вычитания = {0}", a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат умножения = {0}", a * b);
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                Console.WriteLine("Результат деления = {0}", a / b);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Список возможных операций для кого написан?");
                        break;
                }
                Console.ReadKey();
                break;
            }
        }
    }
}
