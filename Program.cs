using System;

namespace КП1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GitHub !\n\n");
            Console.WriteLine("Hello World !\n");

            string answ;
            do
            {
                try
                {
                    //введення користувачем масиву n чисел та "заданого" числа
                    Console.WriteLine("Введiть кiлькiсть елементiв масиву");
                    int size = int.Parse(Console.ReadLine());
                    int[] array = new int[size];
                    Console.WriteLine("Введiть елементи масиву");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Введiть число, вiдносно якого буде проводитись обчислення");
                    int num = int.Parse(Console.ReadLine());
                    int count = 0;

                    //обчислення кількості елементів більше заданого числа
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > num)
                        {
                            count++;
                        }
                    }

                    //виведення результату
                    Console.WriteLine("Кiлькiсть елементiв бiльше заданого числа: " + count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Введiть 1, якщо хочете прожовжити виконання програми");
                    answ = Console.ReadLine();
                    if (answ == "1") Console.Clear();
                }
            } while (answ == "1");
        }
    }
}
