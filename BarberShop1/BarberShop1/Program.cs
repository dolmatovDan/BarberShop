using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void print_menu()
        {
            Console.WriteLine("Привет!!!");
            Console.WriteLine("Есть функции: ");

            Console.WriteLine("Добавить клиента - введите add_customer name Last_name ");
            Console.WriteLine("Добавить услугу - введите add_service price name  ");
            Console.WriteLine("Вывести информацию о Барбершопе - введите print");
            Console.WriteLine("Выйти - введите q");


        }
    }
}
