using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you age");
            bool isValid = int.TryParse(Console.ReadLine(), out int age);
            string message = isValid ? $"You are {age} Years old" : "Please enter valid age";
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void PrintArray(float[] ar)
        {
            foreach (var item in ar)
            {
                Console.Write(item.ToString() + " ");
            }
        }

        public static void CreateTraingle()
        {
            do
            {
                Console.WriteLine("enter side1/press 0 to close: ");
                double side1= Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter side2/press 0 to close: ");
                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter side3/press 0 to close: ");
                double side3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter color for traiangle/press 0 to close: ");
                string color = Console.ReadLine();

                Triangle triangle = new Triangle(side1, side2, side3, color, true);
                Console.WriteLine(triangle);

                Console.WriteLine($"area: {triangle.GetArea()} and Perimeter: {triangle.GetPerimeter()}");

                Console.WriteLine("enter 0 to close/anykey to continute: ");
                int checknum=Convert.ToInt32(Console.ReadLine());

                if (checknum==0)
                {
                    break;
                }
            } while (true);
        }
    }
}
