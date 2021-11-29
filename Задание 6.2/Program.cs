using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любую фразу без знаков препинания, разделяя слова пробелами:");
            string one = Console.ReadLine();
            string two = one.Replace(" ", "");
            char[] array = two.ToCharArray();
            Array.Reverse(array);
            string three = new string(array);
            if (two==three)
            {
                Console.WriteLine("\nВведенная фраза является палиндромом");
            }
            else
            {
                Console.WriteLine("\nВведенная фраза не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
