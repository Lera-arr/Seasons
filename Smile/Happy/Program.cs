using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Happy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int x;
            Console.WriteLine("nкрысы\nбыка\nтигра\nзаяц\nдракон\nзмея\nлошадь\nовца\nобезьяна\nкурицы\nсобаки\nсвиньи\n");
            Console.Write("Введите номер года: ");
            x = Convert.ToInt32(Console.ReadLine());
            string y;
            y = "год ";
            switch (x % 12)
            {
                case 4:
                    Console.WriteLine(y+"крысы");
                    break;
                case 5:
                    Console.WriteLine(y+"быка");
                    break;
                case 6:
                    Console.WriteLine(y + "тигра");
                    break;
                case 7:
                    Console.WriteLine(y + "зайца");
                    break;
                case 8:
                    Console.WriteLine(y + "дракона");
                    break;
                case 9:
                    Console.WriteLine(y + "год змеи");
                    break;
                case 10:
                    Console.WriteLine(y + "год лошади");
                    break;
                case 11:
                    Console.WriteLine(y + "год козы");
                    break;
                case 0:
                    Console.WriteLine(y + "год обезьяны");
                    break;
                case 1:
                    Console.WriteLine(y + "год петуха");
                    break;
                case 2:
                    Console.WriteLine(y + "год собаки");
                    break;
                case 3:
                    Console.WriteLine(y + "год свиньи");
                    break;
            }
            Console.ReadKey();



        }
    }
}
