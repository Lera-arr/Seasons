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
            Console.WriteLine("крыса\nкорова\nтигра\nзаяц\nдракон\nзмея\nлошадь\nовца\nобезьяна\nкурицы\nсобаки\nсвиньи\n");
            Console.Write("Введите номер года");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x % 12)
            {
                case 4:
                    Console.WriteLine("крысы");
                    break;
                case 5:
                    Console.WriteLine("корова");
                    break;
                case 6:
                    Console.WriteLine("тигра");
                    break;
                case 7:
                    Console.WriteLine("заяц");
                    break;
                case 8:
                    Console.WriteLine("дракон");
                    break;
                case 9:
                    Console.WriteLine("змея");
                    break;
                case 10:
                    Console.WriteLine("лошадь");
                    break;
                case 11:
                    Console.WriteLine("овца");
                    break;
                case 0:
                    Console.WriteLine("обезьяна");
                    break;
                case 1:
                    Console.WriteLine("курица");
                    break;
                case 2:
                    Console.WriteLine("собака");
                    break;
                case 3:
                    Console.WriteLine("свинья");
                    break;
            }
            Console.ReadKey();



        }
    }
}
