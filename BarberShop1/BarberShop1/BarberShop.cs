using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop1
{
    static class BarberShop //Делаем static, т.к. барбершоп 1. Дальнейшие поля должны быть тоже static
    {
        public static List<Customer> customers = new List<Customer>(); // Создание динамического массива

        public static List<Service> services = new List<Service>();

        public static int find_customer(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].is_compare(customer))
                {
                    return i; //для отслеживания покупателя. Это его номер в массиве
                }
            }
            return -1; // Если такого нет, то такого номера в массиве нет 
        }
        public static int find_service(Service service)
        {
            for (int i = 0; i < services.Count; i++)
            {
                if (services[i].is_compare(service))
                {
                    return i; //для отслеживания сервиса. Это его номер в массиве
                }
            }
            return -1; // Если такого нет, то такого номера в массиве нет 
        }

        public static bool add_customer(Customer customer)
        {
            int customer_index = find_customer(customer);
            if(customer_index != -1) //Проверяем есть ли такой пользователь
            {
                return false;
            }
            else
            {
                customers.Add(customer);
                return true;
            }
        }
        public static bool add_service(Service service)
        {
            int service_index = find_service(service); 
            if (service_index != -1)//Проверяем есть ли такой сервис
            {
                return false;
            }
            else
            {
                services.Add(service);
                return true;
            }
        }

        public static bool add_customer(string name, string Last_name)
        {
            return add_customer(new Customer(name, Last_name));
        }
        public static bool add_service(string name, int price)
        {
            return add_service(new Service(price, name));
        }

        public static void print()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("Пользователей пока нет");
            }
            else
            {
                Console.WriteLine("Пользователи");
                for(int i = 0; i < customers.Count; i++)
                {
                    customers[i].print();
                }
                     
            }
            if (services.Count == 0)
            {
                Console.WriteLine("Услуг пока нет");
            }
            else
            {
                Console.WriteLine("Услуги: ");
                for (int i = 0; i < services.Count; i++)
                {
                    services[i].print();
                }

            }
        }
    }
   
}
