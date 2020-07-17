using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace ZooManagement
{
    static class Program
    {
        public static Zoo zooList = new Zoo();
        public static Cote animalList = new Cote();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("0/exit");
                Console.WriteLine("1/add cote");
                Console.WriteLine("2/view cote");
                Console.WriteLine("3/delete cote");
                Console.WriteLine("4/add animal");
                Console.WriteLine("5/delete animal");
                Console.WriteLine("6/view all of animal");
                
                int checkNum = Convert.ToInt32(Console.ReadLine());
                if (checkNum == 0)
                {
                    break;
                }

                switch (checkNum)
                {
                    case 1:
                        addNewCote();
                        break;
                    case 2:
                        zooList.viewCote();
                        break;
                    case 3:
                        DeleteCote();
                        break;
                    case 4:
                        addAnimal();
                        break;
                    case 5:
                       
                        break;

                    case 6:
                        animalList.SoundOfAnimal();
                        break;
                }

            } while (true);

        }

        public static void addNewCote()
        {
            Cote cote = new Cote();
            Zoo zoo = new Zoo();
            zooList.AddCote(cote);
        }

        public static void DeleteCote()
        {
            Console.WriteLine("enter cote's id: ");
            int idCote =Convert.ToInt32(Console.ReadLine());
            zooList.DeleteCote(idCote);
        }

        public static void DeleteAnimal()
        {
            Console.WriteLine("enter animal's id you want to remove");
        }

        public static void addAnimal() 
        {
            Console.WriteLine("choose the kind of animal: ");
            Console.WriteLine("1/cat");
            Console.WriteLine("2/dog");
            Console.WriteLine("3/tiger");
            int kindAnimal =Convert.ToInt32(Console.ReadLine());
            switch (kindAnimal)
            {
                case 1:
                    Console.Write("enter name of cat: ");
                    string catName = Console.ReadLine();

                    Console.Write("enter age of cat: ");
                    int catAge =Convert.ToInt32(Console.ReadLine());

                    Console.Write("enter dessciption of cat: ");
                    string catDescription = Console.ReadLine();

                    Cat cat = new Cat(catName,catAge,catDescription);
                    animalList.AddAnimal(cat);
                    break;
                case 2:
                    Console.Write("enter name of dog: ");
                    string dogName = Console.ReadLine();

                    Console.Write("enter age of dog: ");
                    int dogAge = Convert.ToInt32(Console.ReadLine());

                    Console.Write("enter dessciption of dog: ");
                    string dogDescription = Console.ReadLine();

                    Dog dog= new Dog(dogName, dogAge, dogDescription);
                    animalList.AddAnimal(dog);
                    break;
                case 3:
                    Console.Write("enter name of tiger: ");
                    string tigerName = Console.ReadLine();

                    Console.Write("enter age of tiger: ");
                    int tigerAge = Convert.ToInt32(Console.ReadLine());

                    Console.Write("enter dessciption of tiger: ");
                    string tigerDescription = Console.ReadLine();

                    Tiger tiger = new Tiger(tigerName, tigerAge, tigerDescription);
                    animalList.AddAnimal(tiger);
                    break;
                default:
                    break;
            }
            
        }


    }
}
