using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6._2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string urok = Console.ReadLine();
            urok = urok.Replace(" ", "");
            urok = urok.ToLower();
            char[] mas = urok.ToCharArray();

            Array.Reverse(mas);
            string koru = "";
            koru = new string(mas);

            if (urok == koru)
            {
                Console.WriteLine("Строка является полиандромом");
            }
            else
            {
                Console.WriteLine("Строка не является полиандромом!");
            }
            Console.ReadKey();
        }
    }
}
