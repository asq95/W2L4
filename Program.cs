using System;

namespace W2L4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }

        private static void Task5()
        {
            Console.Write("Enter the Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter the Surname: ");
            string Surname = Console.ReadLine();
            Console.Write("Enter the Telephone Number: ");
            long telNumber = long.Parse(Console.ReadLine());
            Console.Write("Enter the email adress: ");
            string email = Console.ReadLine();
            Console.Write("Enter the height: ");
            double height = int.Parse(Console.ReadLine());
            Console.Write("Enter the weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your data: {Name},{Surname},{telNumber},{email},{height},{weight}");


        }

        private static void Task4()
        {
            int numberInt = 10;
            string captionString = "Szkoła Dotneta";
            double numberDouble = 12.5;
        }

        private static void Task3()
        {
            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = double.Parse(Console.ReadLine());
            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine(diagonal);
        }

        private static void Task2()
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';
            Console.WriteLine($"{c}{b}{a}");
        }

        private static void Task1()
        {
            string imie, nazwisko;
            int wiek;
            char plec;
            long PESEL, nrPracownika;
        }
    }
}
