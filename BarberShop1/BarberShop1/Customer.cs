using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop1
{
    class Customer
    {
        private static int cur_max_id = 0; //Добавляем static, что бы счётчик был одинаков, для всех и уведичивался, когда добавлялся новый пользователь

        int id; //по умолчанию private

        public string name;
        public string Last_name;

        public Customer(string name, string Last_name)
        {
            id = cur_max_id;
            cur_max_id++;
            this.name = name;
            this.Last_name = Last_name; //что бы не было одинаковых имён указываем this, или меняем переменную параметра конструктора. 
        } 

        public void print()
        {
            Console.WriteLine("____________");
            Console.WriteLine("Клент № " + id + ":");
            Console.WriteLine(name + " " + Last_name);
            Console.WriteLine("____________");
        }

        public bool is_compare(Customer customer)
        {
            if (id == customer.id && name == customer.name && Last_name == customer.Last_name)
            {
                return true;
            }
            else //можно просто return false
            {
                return false;
            }
        }
    }
}
