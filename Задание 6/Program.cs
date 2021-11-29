using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое предложение без знаков препинания, разделяя слова пробелами:");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string stringMax = stringArray[0];
            foreach (string s  in stringArray)
            {
                if (s.Length>stringMax.Length)
                {
                    stringMax = s;
                }
            }
            Console.WriteLine("\nСамое длинное число в веденной строке:\t{0}",stringMax);
            Console.ReadKey();
        }
    }
}
