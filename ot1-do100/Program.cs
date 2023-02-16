using System;
using System.Threading;

namespace ot1_do100
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int sleep1 = random.Next(100, 150);
            int sleep2 = random.Next(70, 150);
            // создаем новый поток
            Thread myThread = new Thread(Print);
            // запускаем поток myThread
            myThread.Start();
            // действия, выполняемые в главном потоке
            for (int i = 0; i < s; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Главный поток: {i},{sleep1}");
                Thread.Sleep(sleep1);
            }
            // действия, выполняемые во втором потокке
            void Print()
            {
                for (int i = 0; i < r; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Второй поток: {i}, Рандомное число:{sleep2}");
                    Thread.Sleep(sleep2);
                }


            }
        }
    }
}
