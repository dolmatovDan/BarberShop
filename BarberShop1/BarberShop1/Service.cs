using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop1
{
    class Service
    {
        public string name;
        private int id;
        private static int cur_max_id = 0; //Добавляем static, что бы счётчик был одинаков, для всех и уведичивался, когда добавлялся новый пользователь
        public int price;
        
        public Service(int price, string name)
        {
            id = cur_max_id;
            cur_max_id++;

            this.name = name;
            this.price = price;
        }
        public void print()
        {
            Console.WriteLine("____________");
            Console.WriteLine("Услуга № " + id + ":");
            Console.WriteLine("Название - " + name);
            Console.WriteLine("Цена - " + price);
            Console.WriteLine("____________");
        }
        public bool is_compare(Service service)
        {
            if (id == service.id && name == service.name && price == service.price)
            { //можно без {}, т.к. выполняется только одна команда
                return true;
            }
            else //можно просто return false
            {
                return false;
            }
        }
    }
}
