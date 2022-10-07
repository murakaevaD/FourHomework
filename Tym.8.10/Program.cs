using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tym._8._10
{
    internal class Program
    {
        public static void Number5_1() //метод, возвращающий наибольшее число
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Наибольшее число: " + Math.Max(a, b));
        }
        public static void Number5_2() //метод, меняющий местами числа
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Swap(ref a, ref b);
        }
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Меняем числа местами: " + a + "," + b);
        }
        static bool Number5_3(ref int num) //факториал с правдой/ложью
        {
            int y = num;
            num = 1;
            for (int i = 1; i <= y; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch { return false; }
            return true;
        }
        public static void Number5_4() //метод, вычисляющий факториал
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал введенного числа равен: " + Factorial(a));
        }
        public static long Factorial(int a)
        {
            long factor = 0;
            if (a == 1)
            {
                factor = 1;
            }
            else
            {
                factor = a * Factorial(a - 1);
            }
            return factor;
        }
        public static void DZ5_11() //НОД для двух чисел
        {
            int nod;
            Console.Write("введите первое число: ");
            int z = int.Parse(Console.ReadLine());
            Console.Write("введите второе число: ");
            int x = int.Parse(Console.ReadLine());
            while (x != z)
            {
                if (x > z)
                {
                    x = x - z;
                }
                else
                {
                    z = z - x;
                }
            }

            nod = z;
            Console.WriteLine("НОД: " + nod);
        }
        public static void DZ5_12() //НОД для трех чисел
        {
            Console.Write("введите первое число: ");
            int z = int.Parse(Console.ReadLine());
            Console.Write("введите второе число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("введите третье число: ");
            int v = int.Parse(Console.ReadLine());
            while (z != 0 && x != 0)
            {
                if (z > x)
                {
                    z = z % x;
                }
                else
                {
                    x = x % z;
                }
            }
            while (v != 0 && x != 0)
            {
                if (v > x)
                {
                    v = v % x;
                }
                else
                {
                    x = x % v;
                }
            }
            Console.WriteLine("НОД: " + Math.Max(z + x, x + v));
        }
        public static void DZ5_2() //значение числа ряда фибоначчи
        {
            Console.Write("Введите порядковый номер числа ряда Фибоначчи: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 48)
            {
                Console.WriteLine("число выходит за пределы интевского диапазона");
            }
            else if (num < 0)
            {
                Console.WriteLine("числа под таким номером в ряде не существует");
            }
            else
            {
                int chi = 1;
                int chi2 = 1;
                int sum;

                int s = 2;
                while (s <= num)
                {
                    sum = chi + chi2;
                    chi = chi2;
                    chi2 = sum;
                    s++;
                }
                Console.WriteLine("Под " + num + " номером в ряде Фибоначчи стоит число " + chi);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1 (метод, возвращающий наибольшее число)");
            Number5_1();
            Console.WriteLine("Упражнение 5.2 (метод, меняющий местами числа)");
            Number5_2();
            Console.WriteLine("Упражнение 5.3 (факториал с правдой/ложью)");
            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            bool flag = Number5_3(ref x);
            Console.WriteLine(Convert.ToString(flag) + ", факториал равен " + Convert.ToString(x));
            Console.WriteLine("Упражнение 5.4 (метод, вычисляющий факториал)");
            Number5_4();
            Console.WriteLine("ДЗ 5.1(1) (НОД для двух чисел)");
            DZ5_11();
            Console.WriteLine("ДЗ 5.1(2) (НОД для трех чисел)");
            DZ5_12();
            Console.WriteLine("ДЗ 5.2 (значение числа ряда фибоначчи)");
            DZ5_2();
        }
    }
}
