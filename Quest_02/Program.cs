using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Вероятность поражения мишени стрелком = 0.3"); 
            Console.WriteLine(" Найти Вероятность что при n выйстрелах цель будет пораженна от k до i раз.");


            Double P, C, p, q, X, n, k, i;

            Console.WriteLine("Введите n  число Выйстрелов");
            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите k число минимума попаданий");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите i число максимума попаданий");
            i = Convert.ToDouble(Console.ReadLine());


            for (double t = k; t < i; t++)
            {
                p = k / n;

                q = 1 - p;

                C = Prov(n) / Prov(k) * Prov(n - k);

                P = C * Math.Pow(p, k) * Math.Pow((1 - p), (n - k));

                X = p * 100;

                if (n < i)
                {
                    Console.WriteLine("Количество Выйстрелов не может быть меньше количества Попаданий");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(Math.Round(X, 2) + "%");
                    
                    Console.ReadLine();
                }
                
            }
            

        }
        private static double Prov(double n)
        {
            if (n == 0)
            {
                return 1;
            }

            double prov = 1;
            for (int i = 1; i <= n; i++)
            {
                prov *= i;
            }
            return prov;
        }

    }
}
        