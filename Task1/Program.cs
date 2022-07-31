using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число N для вычисления N!");
            int amount = Convert.ToInt32(Console.ReadLine());
            // Запуск асинхронного метода
            GetFactorialAsync(amount);

            //Запуск метода в основном потоке для проверки работы
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }

            Console.ReadKey();
        }

        static void GetFactorial(int amount)
        {
            int result = 1;
            for (int i = 1; i <= amount; i++)
            {
                result *= i;
                Thread.Sleep(50);
            }
            Console.WriteLine($"Факториал числ {amount} равен {result}");
        }

        static async void GetFactorialAsync(int amount)
        {
            await Task.Run(() => GetFactorial(amount));
        }


    }
}
