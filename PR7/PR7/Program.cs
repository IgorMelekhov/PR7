using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Практическая работа номер 7";
                Console.Write("Здравствуйте\nВведите Y чтобы продолжить или N чтобы выйти ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            try
                            {
                                try
                                {
                                    double Y = 0;
                                    uint N;
                                    double i;
                                    double j = 0;
                                    double k; ;
                                    Console.WriteLine("Здравствуйте");
                                    Console.Write("Введите натуральное число N=");
                                    N = uint.Parse(Console.ReadLine());
                                    for (i = 1; i <= N; i++)
                                    {
                                        j = Math.Sin(i) + j;
                                        k = 1 / j;
                                        Y += k;
                                    }
                                    double z=Math.Round(Y,3);
                                    Console.WriteLine($"Ответ={z}");                                  
                                    Console.ReadKey();
                                }
                                catch (DivideByZeroException db)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(db.Message);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                break;
                            }
                            catch (FormatException fe)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(fe.Message);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ex.Message);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;
                    case "N":
                        Console.WriteLine("До свидания");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
