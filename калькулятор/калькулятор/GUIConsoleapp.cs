using System;
using Basic;
using Massiv;

namespace Calculator
{
    internal class GUIConsoleapp
    {
        private double ReadDouble(string text)
        {
            double number;
            Console.Write(text);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Это не число, попробуй ещё раз: ");
            }
            return number;
        }

        private int ReadInt(string text)
        {
            int number;
            Console.Write(text);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Это не целое число, попробуй ещё раз: ");
            }
            return number;
        }

        private List<double> ReadList()
        {
            List<double> list = new List<double>();
            int n = ReadInt("Сколько чисел будем вводить? ");

            while (n <= 0)
            {
                n = ReadInt("Должно быть больше 0, повтори: ");
            }

            for (int i = 0; i < n; i++)
            {
                list.Add(ReadDouble("Число №" + (i + 1) + ": "));
            }
            return list;
        }

        private void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("========== КАЛЬКУЛЯТОР ==========");
            Console.WriteLine("1  - Сумма");
            Console.WriteLine("2  - Вычитание");
            Console.WriteLine("3  - Умножение");
            Console.WriteLine("4  - Деление");
            Console.WriteLine("5  - Деление нацело");
            Console.WriteLine("6  - Проценты");
            Console.WriteLine("7  - Депроценты");
            Console.WriteLine("8  - Считать");
            Console.WriteLine("9  - Макс");
            Console.WriteLine("10 - Мин");
            Console.WriteLine("11 - Факториал");
            Console.WriteLine("0  - Выход");
            Console.WriteLine("=================================");
        }

        public void Run()
        {
            bool work = true;

            while (work)
            {
                ShowMenu();
                int choice = ReadInt("Выбери пункт: ");

                try
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                double a = ReadDouble("Первое число: ");
                                double b = ReadDouble("Второе число: ");
                                Console.WriteLine("Результат: " + Massiv.Math.Sum(a, b));
                                break;
                            }
                        case 2:
                            {
                                double a = ReadDouble("Первое число: ");
                                double b = ReadDouble("Второе число: ");
                                Console.WriteLine("Результат: " + Massiv.Math.Sub(a,
                                    b));
                                break;
                            }
                        case 3:
                            {
                                double a = ReadDouble("Первое число: ");
                                double b = ReadDouble("Второе число: ");
                                Console.WriteLine("Результат: " + Massiv.Math.Mul(a, b));
                                break;
                            }
                        case 4:
                            {
                                double a = ReadDouble("Делимое: ");
                                double b = ReadDouble("Делитель: ");
                                Console.WriteLine("Результат: " + Massiv.Math.Div(a, b));
                                break;
                            }
                        case 5:
                            {
                                int a = ReadInt("Делимое: ");
                                int b = ReadInt("Делитель: ");
                                Console.WriteLine("Результат: " + Massiv.Math.IntDiv(a, b));
                                break;
                            }
                        case 6:
                            {
                                double number = ReadDouble("Число: ");
                                double percent = ReadDouble("Сколько процентов: ");
                                Console.WriteLine(percent + "% от " + number + " = " + Massiv.Math.Percent(number, percent));
                                break;

                            }
                        case 7:
                            {
                                double part = ReadDouble("Известная часть: ");
                                double percent = ReadDouble("Сколько это процентов: ");
                                Console.WriteLine("Целое число = " + Massiv.Math.DePercent(part, percent));
                                break;
                            }
                        case 8:
                            {
                                List<double> list = ReadList();
                                Console.WriteLine("Количество чисел: " + Massiv.Math.Count(list));
                                break;
                            }
                        case 9:
                            {
                                List<double> list = ReadList();
                                Console.WriteLine("Максимум: " + Massiv.Math.Max(list));
                                break;
                            }
                        case 10:
                            {
                                List<double> list = ReadList();
                                Console.WriteLine("Минимум: " + Massiv.Math.Min(list));
                                break;
                            }
                        case 11:
                            {
                                int n = ReadInt("Введи число: ");
                                Console.WriteLine(n + "! = " + Massiv.Math.Factorial(n));
                                break;
                            }
                        case 0:
                            work = false;
                            Console.WriteLine("Пока!");
                            break;
                        default:
                            Console.WriteLine("Нет такого пункта в меню :(");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
        }
    }
}