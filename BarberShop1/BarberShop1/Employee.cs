using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop1
{
    class Employee
    {
        private int id;
        private static int cur_max_id;
        public string name;
        public string Lastname;
        public string position;

        public Employee(string name, string Lastname, string position)
        {
            id = cur_max_id;
            cur_max_id++;
            this.name = name;
            this.Lastname = Lastname;
            this.position = position;
        }
        public void print()
        {
            Console.WriteLine("______________");
            Console.WriteLine("Работник" + name + " " + Lastname);
            Console.WriteLine("id " + id);
            Console.WriteLine("позиция: " + position);
            Console.WriteLine("______________");
        }

        public bool is_compare(Employee employee)
        {
            if (id == employee.id && name == employee.name && Lastname == employee.Lastname && position == employee.position)
                return true;
            return false;
        }
    }
}
