using System;
using System.Diagnostics.Eventing.Reader;

namespace NET.DZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.Если число кратно 3(делится на 3 безостатка) нужно вывести слово Fizz. Если число кратно 5
            //нужно вывести слово Buzz. Если число кратно 3 и 5 нужнo вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести само число.
            //Если пользователь ввел значение не в диапазоне от 1до 100 требуется вывести сообщение об ошибке.

            Console.WriteLine("Enter a number from 1 to 100 using the keyboard-->");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("____________________________");
            if (a < 1 && a > 100) { Console.WriteLine("This number is not in the required range."); }
            else
            {
                if (a % 3 == 0 && a % 5 > 0) { Console.WriteLine("Fizz"); }
                else if (a % 3 > 0 && a % 5 == 0) { Console.WriteLine("Buzz"); }
                else if (a % 3 == 0 && a % 5 == 0) { Console.WriteLine("Fizz Buzz"); }
                else if (a % 3 > 0 && a % 5 > 0) { Console.WriteLine(a); }
            }
            Console.WriteLine("__________________________________________________________________");
            // Задание 2
            //Пользователь вводит с клавиатуры два числа. Первое число — это значение, второе число процент, который
            //необходимо посчитать. Например, мы ввели с клавиатуры 90 и 10.Требуется вывести на экран 10 процентов от 90.Результат: 9.
            Console.WriteLine("Enter a number using the keyboard-->");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 2number from 1 to 100 using the keyboard-->");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("____________________________");
            int d = Convert.ToInt32(0);
            if (c > 100 && c < 0) { Console.WriteLine("This number is not in the required range"); }
            else if (c > 0 && c < 100) { d = b * c / 100; Console.WriteLine(d); }

            Console.WriteLine("__________________________________________________________________");

            //Задание 3
            //Пользователь вводит с клавиатуры четыре цифры.Необходимо создать число, содержащее эти цифры.Например,
            //если с клавиатуры введено 1, 5, 7, 8 тогда нужно
            //сформировать число 1578.

            Console.WriteLine("Enter a number1 using the keyboard-->");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number2 using the keyboard-->");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number3 using the keyboard-->");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number4 using the keyboard-->");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.Write(e); Console.Write(f); Console.Write(g); Console.WriteLine(h);

            Console.WriteLine("__________________________________________________________________");

            //Задание 4
            //Пользователь вводит шестизначное число. После чего пользователь вводит номера разрядов для обмена цифр.
            //Например, если пользователь ввёл один и шесть — это значит, что надо обменять местами первую и шестую цифры.
            //Число 723895 должно превратиться в 523897.Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке

            Console.WriteLine("Enter a number1 using the keyboard-->");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k / 100000 < 1) { Console.WriteLine("This number is not in the required range"); }
            else if (k / 100000 >= 1)
            {
                int k6 = Convert.ToInt32(k % 10);
                int k5 = Convert.ToInt32(((k - k6) / 10) % 10);
                int k4 = Convert.ToInt32(((k - k % 100) / 100) % 10);
                int k3 = Convert.ToInt32(((k - k % 1000) / 1000) % 10);
                int k2 = Convert.ToInt32(((k - k % 10000) / 10000) % 10);
                int k1 = Convert.ToInt32(k / 100000);

                Console.WriteLine("Enter a number1 using the keyboard-->");
                int l1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number2 using the keyboard-->");
                int l2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("____________________________");
                if (l1 == 1 && l2 == 2 || l1 == 2 && l2 == 1) { Console.Write(k2); Console.Write(k1); Console.Write(k3); Console.Write(k4); Console.Write(k5); Console.Write(k6); }
                else if (l1 == 1 && l2 == 3 || l1 == 3 && l2 == 1) { Console.Write(k3); Console.Write(k2); Console.Write(k1); Console.Write(k4); Console.Write(k5); Console.Write(k6); }
                else if (l1 == 1 && l2 == 4 || l1 == 4 && l2 == 1) { Console.Write(k4); Console.Write(k2); Console.Write(k3); Console.Write(k1); Console.Write(k5); Console.Write(k6); }
                else if (l1 == 1 && l2 == 5 || l1 == 5 && l2 == 1) { Console.Write(k5); Console.Write(k2); Console.Write(k3); Console.Write(k4); Console.Write(k1); Console.Write(k6); }
                else if (l1 == 1 && l2 == 6 || l1 == 6 && l2 == 1) { Console.Write(k6); Console.Write(k2); Console.Write(k3); Console.Write(k4); Console.Write(k5); Console.Write(k1); }

                else if (l1 == 2 && l2 == 3 || l1 == 3 && l2 == 2) { Console.Write(k1); Console.Write(k3); Console.Write(k2); Console.Write(k4); Console.Write(k5); Console.Write(k6); }
                else if (l1 == 2 && l2 == 4 || l1 == 4 && l2 == 2) { Console.Write(k1); Console.Write(k4); Console.Write(k3); Console.Write(k2); Console.Write(k5); Console.Write(k6); }
                else if (l1 == 2 && l2 == 5 || l1 == 5 && l2 == 2) { Console.Write(k1); Console.Write(k5); Console.Write(k3); Console.Write(k4); Console.Write(k2); Console.Write(k6); }
                else if (l1 == 2 && l2 == 6 || l1 == 6 && l2 == 2) { Console.Write(k1); Console.Write(k6); Console.Write(k3); Console.Write(k4); Console.Write(k5); Console.Write(k2); }

                else if (l1 == 3 && l2 == 4 || l1 == 4 && l2 == 3) { Console.Write(k1); Console.Write(k2); Console.Write(k4); Console.Write(k3); Console.Write(k5); Console.Write(k6); }
                else if (l1 == 3 && l2 == 5 || l1 == 5 && l2 == 3) { Console.Write(k1); Console.Write(k2); Console.Write(k5); Console.Write(k4); Console.Write(k3); Console.Write(k6); }
                else if (l1 == 3 && l2 == 6 || l1 == 6 && l2 == 3) { Console.Write(k1); Console.Write(k2); Console.Write(k6); Console.Write(k4); Console.Write(k5); Console.Write(k3); }

                else if (l1 == 4 && l2 == 5 || l1 == 5 && l2 == 4) { Console.Write(k1); Console.Write(k2); Console.Write(k3); Console.Write(k5); Console.Write(k4); Console.Write(k6); }
                else if (l1 == 4 && l2 == 6 || l1 == 6 && l2 == 4) { Console.Write(k1); Console.Write(k2); Console.Write(k3); Console.Write(k6); Console.Write(k5); Console.Write(k4); }

                else if (l1 == 5 && l2 == 6 || l1 == 6 && l2 == 5) { Console.Write(k1); Console.Write(k2); Console.Write(k3); Console.Write(k4); Console.Write(k6); Console.Write(k5); }
            }
            Console.WriteLine(""); Console.WriteLine("__________________________________________________________________");

            //Задание 6
            //Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий или наоборот

            Console.WriteLine("Enter temperature -->");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Convert to Fahrenheit -1\r\nConvert to Celsius -2 -->");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1) { Console.WriteLine((t * 1.8 + 32)); }
            else if (ch == 2) { Console.WriteLine(((t - 32) / 1.8)); }
            Console.WriteLine("__________________________________________________________________");

            //Задание 7
            //показать все четные числа в указанном диапазоне.Если границы диапазона указаны неправильно требуется произвести нормализацию границ.Например, пользователь
            //ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.

            Console.WriteLine("Enter range start -->");
            int ns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter range end -->");
            int nf = Convert.ToInt32(Console.ReadLine());
            if (ns > nf)
            {
                for (int i = nf; i >= ns; i++)
                {
                    if (i % 2 == 0) { Console.Write(i); Console.Write("|"); }
                }
            }
            else if (ns < nf)
            {
                for (int i = ns; i >= nf; i++)
                {
                    if (i % 2 == 0) { Console.Write(i); Console.Write("|"); }
                }
            }
            Console.WriteLine("__________________________________________________________________");
        }
    }
}
