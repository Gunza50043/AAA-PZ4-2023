using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA_PZ4_2023
{
    internal class Man
    {
        private string name = "Степан";
        private int age = 15;
        private string pol = "Муж";
        private int wight = 55;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }
        public int Wight
        {
            get { return wight; }
            set { wight = value; }
        }

        public void changeName(string n)
        {
                if (Name != n && n != null)
                {
                    Name = n;
                }
                else
                {
                    Name = Name;
                    Console.WriteLine("Имя уже используется");
                }
        }
        public void changeAge(int a)
        {
            if (Age != a)
            {
                Age = a;
            }
            else
            {
                Age = Age;
                Console.WriteLine("Возраст уже используется");
            }
        }
        public void changeWight(int w)
        {
            if (Wight != w)
            {
                Wight = w;
            }
            else
            {
                Wight = Wight;
                Console.WriteLine("Вес уже используется");
            }
        }





    }



}
