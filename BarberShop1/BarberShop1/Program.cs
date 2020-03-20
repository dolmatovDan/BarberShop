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
            print_menu();
            string user_input = "";
            while (user_input != "q")
            {
                Console.WriteLine("Ведите команду");
                user_input = Console.ReadLine();
                string[] user_input_array = user_input.Split(' ');
                if (user_input_array.Length == 0)
                {
                    Console.WriteLine("Ведите команду");
                    continue;
                }
                switch (user_input_array[0])
                {
                    case "add_customer":
                        add_customer(user_input_array);
                        break;
                    case "add_service":
                        add_service(user_input_array);
                        break;
                    case "print_all":
                        BarberShop.print();
                        break;
                    case "q":
                        break;
                    case "add_emploee":
                        add_emploee(user_input_array);
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод!");
                        break;
                }
            }
        }

        public static void print_menu()
        {
            Console.WriteLine("Привет!!!");
            Console.WriteLine("Есть функции: ");

            Console.WriteLine("Добавить клиента - введите add_customer name Last_name ");
            Console.WriteLine("Добавить услугу - введите add_service price name  ");
            Console.WriteLine("Добавить работника - введите add_emploee name last_name position  ");
            Console.WriteLine("Вывести информацию о Барбершопе - введите print_all");
            Console.WriteLine("Выйти - введите q");


        }
        public static void add_service(string[] user_input_array)
        {
            if (user_input_array.Length < 3)
            {
                Console.WriteLine("Для добавления услуги необходимо название и цена!!!");
                return;
            }
            int price = 0;
            try
            {
                price = Convert.ToInt32(user_input_array[2]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Цена должна быть целым положительным числом");
                return;
            }
            if (price < 0)
            {
                Console.WriteLine("Цена должна быть целым положительным числом");
                return;
            }

            if (BarberShop.add_service(user_input_array[1], price))
            {
                Console.WriteLine("Услуга успешно добавлена!");
            }
            else
            {
                Console.WriteLine("Услуга не была добавлена :(((");
            }
        }
        public static void add_customer(string[] user_input_array)
        {
            if (user_input_array.Length < 3)
            {
                Console.WriteLine("Для добавления пользователя необходимо имя и фамилия!!!");
                return;
            }
            if (BarberShop.add_customer(user_input_array[1], user_input_array[2]))
            {
                Console.WriteLine("Клиент успешно добавлен!)");
            }
            else
            {
                Console.WriteLine("Клиент не был добавлен :(((");
            }
        }
        public static void add_emploee(string[] user_input_array)
        {
            if (user_input_array.Length < 4)
            {
                Console.WriteLine("Для добавления работника необходимо имя, фамилия и позиция!!!");
                return;
            }
            if (BarberShop.add_emloyee(user_input_array[1], user_input_array[2], user_input_array[3]))
            {
                Console.WriteLine("Клиент успешно добавлен!)");
            }
            else
            {
                Console.WriteLine("Клиент не был добавлен :(((");
            }
        }
    }
}
