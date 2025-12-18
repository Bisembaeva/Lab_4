using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public static class Main
    {
        public static void Start()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Главное меню ===");
                Console.WriteLine("1. Дан массив целых чисел. Определить,возрастающей последовательностью. Является ли он");
                Console.WriteLine("2. Найти в массиве, состоящем из целых чисел, возрастающую подпоследовательность максимальной длины. Под термином «подпоследовательность» будем понимать некоторый набор подряд идущих элементов массива.");
                Console.WriteLine("3. Найти в массиве целых чисел симметричную подпоследовательность максимальной длины. Под термином «подпоследовательность» будем понимать некоторый набор подряд идущих элементов массива.");
                Console.WriteLine("4. Найти в массиве, состоящем из целых чисел, возрастающую подпоследовательность максимальной длины. Под термином «подпоследовательность» будем понимать некоторый набор элементов массива, который можно получить путем вычеркивания некоторых элементов массива.");
                Console.WriteLine("5. Дан массив, состоящий из целых чисел. Определить количество элементов, встречающихся в нем по одному разу.");
                Console.WriteLine("6. Дан массив, состоящий из целых чисел. Найти элемент, который встречается в массиве максимальное число раз.");
                Console.WriteLine("7. Дан массив, состоящий из целых чисел. Определить количество различных элементов этого массива.");
                Console.WriteLine("8. Дан массив, элементами которого являются результаты забега спортсменов на 100 м. Составить команду из 4 лучших спортсменов.");
                Console.WriteLine("9. Даны два массива, состоящие из целых чисел. Определить количество элементов первого массива, которые содержатся также и во втором массиве.");
                Console.WriteLine("10. Дан массив, состоящий из целых чисел. Определить, образуют ли элементы массива множество (все элементы множества должны быть уникальны).");
                Console.WriteLine("11. Даны два массива, образующие элементы двух множеств целых чисел. Определить, равны ли эти множества (для множеств имеет значение только наличие элемента в множестве, а не порядок следования элементов в нем).");
                Console.WriteLine("12. Выход");
                Console.Write("Выберите пункт: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка ввода! Введите число от 1 до 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Task9();
                        break;
                    case 10:
                        Task10();
                        break;
                    case 11:
                        Task11();
                        break;
                    case 12:
                        Console.WriteLine("12. Выход из программы...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный пункт меню!");
                        Thread.Sleep(1000);
                        Start();
                        break;
                }

                Console.WriteLine();
            }
            while (choice != 12);
        }
        private static void PressToContinue()
        {
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }
        public static void Task1()
        {
            Console.Clear();
            Console.WriteLine("1. Дан массив целых чисел. Определить,возрастающей последовательностью. Является ли он");
            int[] mas = { 1, 5, 14, 16, 20 };
            ArrayHelper.OutpurArr(mas);
            Console.WriteLine(ArrayHelper.Task1(mas) ? "Истина": "Ложь");

            int[] mas1 = { 1, 5, 14, 16, 20, 13 };
            ArrayHelper.OutpurArr(mas1);
            Console.WriteLine(ArrayHelper.Task1(mas1) ? "Истина" : "Ложь");
            PressToContinue();
        }
        public static void Task2()
        {
            Console.Clear();
            Console.WriteLine("2. Найти в массиве, состоящем из целых чисел, возрастающую подпоследовательность максимальной длины. Под термином «подпоследовательность» будем понимать некоторый набор подряд идущих элементов массива.");
            int[] mas = { 1, 2, 3, 2, 3, 4, 5, 1, 2 };

            ArrayHelper.OutpurArr(mas);
            List<int> result = ArrayHelper.Task2(mas);
            Console.WriteLine($"Максимальная длина возрастающей подпоследовательности: {result.Count}");
            Console.Write("Подпоследовательность: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }

        public static void Task3()
        {
            Console.Clear();
            Console.WriteLine("3. Найти в массиве целых чисел симметричную подпоследовательность максимальной длины. Под термином «подпоследовательность» будем понимать некоторый набор подряд идущих элементов массива.");
            int[] mas = { 1, 2, 3, 2, 1, 4, 5 };
            ArrayHelper.OutpurArr(mas);
            List<int> result = ArrayHelper.Task3(mas);
            Console.WriteLine($"Максимальная длина симетричной подпоследовательности: {result.Count}");
            Console.Write("Подпоследовательность: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        public static void Task4()
        {
            Console.Clear();
            Console.WriteLine("4. Найти в массиве, состоящем из целых чисел, возрастающую подпоследовательность максимальной длины. Под термином «подпоследовательность» будем понимать некоторый набор элементов массива, который можно получить путем вычеркивания некоторых элементов массива.");
            int[] mas = { 3, 10, 2, 1, 20, 5, 6, 9, 12 };

            ArrayHelper.OutpurArr(mas);

            List<int> result = ArrayHelper.Task4(mas);
            Console.WriteLine($"Максимальная длина возрастающей подпоследовательности: {result.Count}");
            Console.Write("Подпоследовательность: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        public static void Task5()
        {
            Console.Clear();
            Console.WriteLine("5. Дан массив, состоящий из целых чисел. Определить количество элементов, встречающихся в нем по одному разу.");
            int[] mas = { 1, 2, 2, 3, 4, 4, 5 };
            ArrayHelper.OutpurArr(mas);
            List<int> result = ArrayHelper.Task5(mas);

            Console.WriteLine($"Количество встречающихся в массиве по одному разу - {result.Count}");
            Console.Write("Это: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        public static void Task6()
        {
            Console.Clear();
            Console.WriteLine("6. Дан массив, состоящий из целых чисел. Найти элемент, который встречается в массиве максимальное число раз.");
            int[] mas = { 1, 2, 2, 3, 3, 3, 4, 2 };
            ArrayHelper.OutpurArr(mas);

            List<int> result = ArrayHelper.Task6(mas);
            Console.WriteLine($"Количество встречающихся в массиве элементов наибольшее количество раз - {result.Count}");
            Console.Write("Это: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        public static void Task7()
        {
            Console.Clear();
            Console.WriteLine("7. Дан массив, состоящий из целых чисел. Определить количество различных элементов этого массива.");
            int[] mas = { 1, 2, 2, 3, 4, 4, 5 };
            ArrayHelper.OutpurArr(mas);

            List<int> result = ArrayHelper.Task7(mas);
            Console.WriteLine($"Количество различных уникальных элементов в массиве - {result.Count}");
            Console.Write("Это: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        public static void Task8()
        {
            Console.Clear();
            Console.WriteLine("8. Дан массив, элементами которого являются результаты забега спортсменов на 100 м. Составить команду из 4 лучших спортсменов.");
            int[] mas = { 12, 11, 15, 10, 13, 9, 14 };
            ArrayHelper.OutpurArr(mas);

            List<int> result = ArrayHelper.Task8(mas);
            Console.Write("Это: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        public static void Task9()
        {
            Console.Clear();
            Console.WriteLine("9. Даны два массива, состоящие из целых чисел. Определить количество элементов первого массива, которые содержатся также и во втором массиве.");
            int[] mas1 = { 1, 2, 3, 4, 5 }; 
            int[] mas2 = { 3, 4, 5, 6, 7 };
            ArrayHelper.OutpurArr(mas1);
            ArrayHelper.OutpurArr(mas2);

            List<int> result = ArrayHelper.Task9(mas1, mas2);

            Console.WriteLine($"Количество элементов первого массива которые есть во втором: {result.Count}");

            Console.Write("Это: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            PressToContinue();
        }
        public static void Task10()
        {
            Console.Clear();
            Console.WriteLine("10. Дан массив, состоящий из целых чисел. Определить, образуют ли элементы массива множество (все элементы множества должны быть уникальны).");
            int[] mas = { 1, 2, 3, 4, 5, 6 };
            ArrayHelper.OutpurArr(mas);
            Console.WriteLine($"Данный массив : {(ArrayHelper.Task10(mas) ? "является множество": "не является множеством")}");
            int[] mas1 = { 1, 2, 3, 4, 5, 6, 6 };
            ArrayHelper.OutpurArr(mas1);
            Console.WriteLine($"Данный массив : {(ArrayHelper.Task10(mas1) ? "является множество" : "не является множеством")}");
            PressToContinue();
        }
        public static void Task11()
        {
            Console.Clear();
            Console.WriteLine("11. Даны два массива, образующие элементы двух множеств целых чисел. Определить, равны ли эти множества (для множеств имеет значение только наличие элемента в множестве, а не порядок следования элементов в нем).");

            int[] mas1 = { 1, 2, 3, 4, 5 }; 
            int[] mas2 = { 5, 4, 3, 2, 1 };
            ArrayHelper.OutpurArr(mas1);
            ArrayHelper.OutpurArr(mas2);

            Console.WriteLine($"Данные массивы (множества) {(ArrayHelper.Task11(mas1, mas2) ? "равны" : "не равны")}");

            int[] mas3 = { 1, 2, 3, 4, 5 };
            int[] mas4 = { 2, 4, 3, 2, 1 };
            ArrayHelper.OutpurArr(mas3);
            ArrayHelper.OutpurArr(mas4);

            Console.WriteLine($"Данные массивы (множества) {(ArrayHelper.Task11(mas3, mas4) ? "равны" : "не равны")}");
            PressToContinue();
        }
    }
}
