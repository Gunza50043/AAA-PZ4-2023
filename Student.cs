using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA_PZ4_2023
{
    internal class Student:Man
    {
        private int ageStudy = 2020;
        public int AgeStudy
        {
            get { return ageStudy; }
            set { ageStudy = value; }
        }

        public void changeAgeStudy(int newChangeAgeStudy)
        {
            if (newChangeAgeStudy > 0 && newChangeAgeStudy > AgeStudy)
            { AgeStudy = newChangeAgeStudy; }
            else Console.WriteLine("Ошибка");
        }
        public void Displey()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Pol);
            Console.WriteLine(Wight);
            Console.WriteLine(AgeStudy);
            Console.WriteLine("-----------------------------------");
        }

    }
}
