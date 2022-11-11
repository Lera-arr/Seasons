using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("крысы\nбыка\nтигра\nзаяц\nдракон\nзмея\nлошадь\nовца\nобезьяна\nкурицы\nсобаки\nсвиньи\n");
            Console.Write("Введите номер года: ");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x % 12)
            {
                case 4:
                    Console.WriteLine("год крысы");
                    break;
                case 5:
                    Console.WriteLine("год коровы");
                    break;
                case 6:
                    Console.WriteLine("год тигра");
                    break;
                case 7:
                    Console.WriteLine("год зайца");
                    break;
                case 8:
                    Console.WriteLine("год дракона");
                    break;
                case 9:
                    Console.WriteLine("год змеи");
                    break;
                case 10:
                    Console.WriteLine("год лошади");
                    break;
                case 11:
                    Console.WriteLine("год козы");
                    break;
                case 0:
                    Console.WriteLine("год обезьяны");
                    break;
                case 1:
                    Console.WriteLine("год петуха");
                    break;
                case 2:
                    Console.WriteLine("год собаки");
                    break;
                case 3:
                    Console.WriteLine("год свиньи");
                    break;
            }
            Console.ReadKey();



        }
    }
}
