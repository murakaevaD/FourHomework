using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Na._8._10
{
    public enum LevelVorch
    {
        Наиворчливейший = 0,
        Ворчун = 1,
        Редковорчливый = 2,
        Неворчун = 3
    }
    public struct Ded
    {
        public string Name;
        public LevelVorch level;
        public byte poboi;
        public string[] Phrases;
    }
    internal class Program
    {
        public static void Number_1(double a, double b, double c) //квадратное уравнение
        {
            double d = b * b - 4 * a * c;
            double x, x1, x2;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Корни уравнения равны " + x1 + " и " + x2);
            }
            else if (d == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine("Корень уравнения равен " + x);
            }
            else
            { Console.WriteLine("действительных корней нет"); }
        }
        static void Number_2() //поменять местами 2 числа из 20
        {
            Random rnd = new Random();
            int[] a = new int[20];
            a[0] = rnd.Next(0, 101);
            for (int i = 1; i < 20;)
            {
                int num = rnd.Next(0, 101);
                int j;
                for (j = 0; j < i; j++)
                {
                    if (num == a[j])
                        break;
                }
                if (j == i)
                {
                    a[i] = num;
                    i++;
                }
            }
            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine("введите 2 числа которые хотите поменять");
            int ind1 = Array.IndexOf(a, int.Parse(Console.ReadLine()));
            int ind2 = Array.IndexOf(a, int.Parse(Console.ReadLine()));
            (a[ind1], a[ind2]) = (a[ind2], a[ind1]);
            Console.WriteLine(string.Join(" ", a));
        }
        public static int[] Number_3(int[] rad, int q) //сортировка пузырьком
        {
            for (int w = 0; w < rad.Length; w++)
            {
                for (int e = 0; e < rad.Length - 1; e++)
                {
                    if (rad[e] > rad[e + 1])
                    {
                        q = rad[e + 1];
                        rad[e + 1] = rad[e];
                        rad[e] = q;
                    }
                }
            }
            for (int i = 0; i < rad.Length; i++)
                Console.Write(rad[i] + " ");
            Console.WriteLine();
            return rad;
        }
        public static int Number_4(ref int proizv, out double arif, params int[] riad) //массив
        {
            for (int i = 0; i < riad.Length; i++)
            {
                proizv *= riad[i];
            }
            Console.WriteLine("произведение массива: " + proizv);
            arif = riad.Sum() / riad.Length;
            Console.WriteLine("среднее арифметическое массива: " + arif);
            int n4 = riad.Sum();
            Console.WriteLine("сумма массива " + n4);
            return n4;
        }
        public static void Number_5() //числа,решетка или закрыть
        {
            Console.WriteLine("Если хотите завершить программу нажмите - 0; если хотите продолжить игру с цифрами - любое число");
            int chisloo = int.Parse(Console.ReadLine());
            if (chisloo == 0)
            {
                Console.WriteLine("Напишите закрыть или exit: ");
                string exite = Console.ReadLine();
                if (exite == "exit" || exite == "закрыть")
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                try
                {
                    Console.WriteLine("Введите число: ");
                    int chislo = int.Parse(Console.ReadLine());
                    if (chislo >= 0 & chislo <= 9)
                    {
                        if (chislo == 0)
                        {
                            Console.WriteLine("  ##");
                            Console.WriteLine(" #  #");
                            Console.WriteLine("#    #");
                            Console.WriteLine(" #  #");
                            Console.WriteLine("  ##");
                        }
                        else if (chislo == 1)
                        {
                            Console.WriteLine("  #");
                            Console.WriteLine(" ##");
                            Console.WriteLine("# #");
                            Console.WriteLine("  #");
                            Console.WriteLine("  #");
                            Console.WriteLine("  #");
                        }
                        else if (chislo == 2)
                        {
                            Console.WriteLine("  # # #");
                            Console.WriteLine(" #   #");
                            Console.WriteLine("#   #");
                            Console.WriteLine("   #");
                            Console.WriteLine("  #");
                            Console.WriteLine(" # # # #");
                        }
                        else if (chislo == 3)
                        {
                            Console.WriteLine("  # #");
                            Console.WriteLine(" #   #");
                            Console.WriteLine("    #");
                            Console.WriteLine("   #");
                            Console.WriteLine("    #");
                            Console.WriteLine(" #   #");
                            Console.WriteLine("  # #");
                        }
                        else if (chislo == 4)
                        {
                            Console.WriteLine("#   #");
                            Console.WriteLine("#   #");
                            Console.WriteLine("# # #");
                            Console.WriteLine("    #");
                            Console.WriteLine("    #");
                            Console.WriteLine("    #");
                        }
                        else if (chislo == 5)
                        {
                            Console.WriteLine("# # #");
                            Console.WriteLine("#");
                            Console.WriteLine("#  #");
                            Console.WriteLine("    #");
                            Console.WriteLine("     #");
                            Console.WriteLine("# # #");
                        }
                        else if (chislo == 6)
                        {
                            Console.WriteLine("# # #");
                            Console.WriteLine("#");
                            Console.WriteLine("# #");
                            Console.WriteLine("#   #");
                            Console.WriteLine("#    #");
                            Console.WriteLine("#  #  #");
                        }
                        else if (chislo == 7)
                        {
                            Console.WriteLine("# # # #");
                            Console.WriteLine("     #");
                            Console.WriteLine("    #");
                            Console.WriteLine("   #");
                            Console.WriteLine("  #");
                            Console.WriteLine(" #");
                        }
                        else if (chislo == 8)
                        {
                            Console.WriteLine("   # #");
                            Console.WriteLine("  #   #");
                            Console.WriteLine(" #     #");
                            Console.WriteLine("  #   #");
                            Console.WriteLine("    #");
                            Console.WriteLine("  #   #");
                            Console.WriteLine(" #     #");
                            Console.WriteLine("  #   #");
                            Console.WriteLine("   # #");
                        }
                        else if (chislo == 9)
                        {
                            Console.WriteLine("    # #");
                            Console.WriteLine("   #   #");
                            Console.WriteLine("  #     #");
                            Console.WriteLine("   #   #");
                            Console.WriteLine("     #");
                            Console.WriteLine("    #");
                            Console.WriteLine("   # ");
                            Console.WriteLine("  #");
                        }

                    }
                    else if (chislo < 0 || chislo > 9)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        Console.Clear();
                        Console.WriteLine("Ошибочка!");
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Это не число!");
                }
            }
        }
        public static void Number_6() //структура деда
        {
            string[] phrases = { "Проститутки!", "Гады!", "Суки!" };
            Ded ded1 = new Ded();
            ded1.Name = "Михалыч";
            ded1.level = LevelVorch.Ворчун;
            string[] s1 = { "Дураки", "Гады!", "собаки", "Проститутки!" };
            ded1.Phrases = s1;
            ded1.poboi = KolPoboi(ded1.Phrases, phrases);
            Console.WriteLine("Фингалов у " + ded1.Name + ": " + ded1.poboi);

            Ded ded2 = new Ded();
            ded2.Name = "Саныч";
            ded2.level = LevelVorch.Наиворчливейший;
            string[] s2 = { "самогон", "бляди", "Гады!", "Проститутки!", "Суки!" };
            ded2.Phrases = s2;
            ded2.poboi = KolPoboi(ded2.Phrases, phrases);
            Console.WriteLine("Фингалов у " + ded2.Name + ": " + ded2.poboi);

            Ded ded3 = new Ded();
            ded3.Name = "Федотыч";
            ded3.level = LevelVorch.Редковорчливый;
            string[] s3 = { "Идиоты", "Придурки", "Суки!", "пивас", "вертихвостки" };
            ded3.Phrases = s3;
            ded3.poboi = KolPoboi(ded3.Phrases, phrases);
            Console.WriteLine("Фингалов у " + ded3.Name + ": " + ded3.poboi);

            Ded ded4 = new Ded();
            ded4.Name = "Палыч";
            ded4.level = LevelVorch.Ворчун;
            string[] s4 = { "Дебилы", "пошли вон", "Проститутки!", "Суки!", "крысы подзаборные" };
            ded4.Phrases = s4;
            ded4.poboi = KolPoboi(ded4.Phrases, phrases);
            Console.WriteLine("Фингалов у " + ded4.Name + ": " + ded4.poboi);

            Ded ded5 = new Ded();
            ded5.Name = "Ильич";
            ded5.level = LevelVorch.Неворчун;
            string[] s5 = { "Мудаки", "дураки", "дебилы", "блин" };
            ded5.Phrases = s5;
            ded5.poboi = KolPoboi(ded5.Phrases, phrases);
            Console.WriteLine("Фингалов у " + ded5.Name + ": " + ded5.poboi);
        }
        public static byte KolPoboi(string[] array, params string[] words) //побои деда от бабки
        {
            byte b = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == array[i])
                    {
                        b++;
                    }
                }
            }
            return b;
        }

        public static int FindPivot(int[] numbers, int minIndex, int maxIndex) //быстрая сортировка(меньшие элементы,опорное число,большие элементы)
        {
            int pivot = minIndex - 1;
            int temp = 0;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (numbers[i] < numbers[maxIndex])
                {
                    pivot++;
                    temp = numbers[pivot];
                    numbers[pivot] = numbers[i];
                    numbers[i] = temp;
                }
            }
            pivot++;
            temp = numbers[pivot];
            numbers[pivot] = numbers[maxIndex];
            numbers[maxIndex] = temp;

            return pivot;
        }
        public static int[] QuickSort(int[] numbers, int minIndex, int maxIndex) //быстрая сортировка(перестановка до и после опорного)
        {
            if (minIndex >= maxIndex)
            {
                return numbers;
            }
            int pivot = FindPivot(numbers, minIndex, maxIndex);
            QuickSort(numbers, minIndex, pivot - 1);
            QuickSort(numbers, pivot + 1, maxIndex);
            return numbers;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("номер 1 (квадратное уравнение)");
            Console.Write("Введите значение a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение c:");
            double c = double.Parse(Console.ReadLine());
            Number_1(a, b, c);

            Console.WriteLine("номер 2 (поменять местами 2 числа из 20)");
            Number_2();

            Console.WriteLine("номер 3 (сортировка пузырьком)");
            int[] rad = { 67, 7474, 2, 44, -574, 7, 324, 32 };
            int q = 0;
            rad = Number_3(rad, q);

            Console.WriteLine("номер 4 (массив)");
            int proizv = 1;
            double arif = 1;
            int[] riad = { 1, 3, 2, 15, 6, 8, 10, 1, 9, 3 };
            Number_4(ref proizv, out arif, riad);

            Console.WriteLine("номер 5 (числа,решетка или закрыть)");
            Number_5();

            Console.WriteLine("номер 6 (структура деда)");
            Number_6();

            Console.WriteLine("номер 7 (быстрая сортировка)");
            int[] numbers = { 4, -12, 5, 56, 0, 9, 17, 6, 90 };
            numbers = QuickSort(numbers, 0, numbers.Length - 1);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
