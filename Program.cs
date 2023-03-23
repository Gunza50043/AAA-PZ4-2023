namespace AAA_PZ4_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Student student = new Student();
            Console.WriteLine("Hello, World!");
            student.Displey();

            Console.WriteLine("Новое имя: ");
            man.changeName(Console.ReadLine());
            Console.WriteLine("Новый возраст: ");
            man.changeAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Новый вес: ");
            man.changeWight(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите новый год обучения");
            student.changeAgeStudy(Convert.ToInt32(Console.ReadLine()));

            student.Displey();

            
        }
    }
}